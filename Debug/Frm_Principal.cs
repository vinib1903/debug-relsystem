using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SQLite;

namespace Debug
{
    public partial class Frm_Principal : Form
    {

        string ipCatraca = null;
        static string ipServidor = "";
        
        
        // // ID digitado pelo usuário
        // static string userInputId = "";
        // // Senha digitada pelo usuário
        // static string senhaInputId = "";
        
        
        private HttpClient _httpClient;
        public Frm_Principal()
        {
            
            
            InitializeComponent();
            _httpClient = new HttpClient();
            
            //_httpClient.BaseAddress = new Uri("http://localhost:5032/Debug/");

            
        }
        
        private async void btn_Conectar_Click(object sender, EventArgs e)
        {
            string ip = GetLocalIPAddress();
            ipServidor = ip;
            ipCatraca = txt_IpCatraca.Text;
            
            await SendHttpRequest();
            await StartTcpServer(ip);
            
            MessageBox.Show($"IP SETADO = {ipCatraca}!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task StartTcpServer(string ip)
        {
            TcpListener listener = new TcpListener(IPAddress.Parse(ip), 8055);
            listener.Start();
            Console.WriteLine("Servidor TCP iniciado. Aguardando requisições...");
            Console.WriteLine("------------------------------------------------------------------------------");

            Task.Run(() =>
            {
                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Task.Run(() => HandleClient(client));
                }
            });
        }
        
        private async void HandleClient(TcpClient client)
        {
            using (NetworkStream stream = client.GetStream())
            {
                byte[] buffer = new byte[client.ReceiveBufferSize];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string requestString = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                (string idRecebido, string senhaRecebida) = GetIdAndSenhaFromRequest(requestString);

                
                

                bool isAuthorized = CheckPasswordInDatabase(senhaRecebida);
                
                // Atualizar o texto da Label com a senha recebida
                
                lbl_senhaRecebida.Text = senhaRecebida;
                lbl_senhaRecebida.ForeColor = isAuthorized ? Color.Green : Color.Red;

                var responseObject = isAuthorized 
                    ? new { liberacao = 1, sentidoGiro = 1 } 
                    : new { liberacao = 2, sentidoGiro = 0 };

                string jsonResponse = Newtonsoft.Json.JsonConvert.SerializeObject(responseObject);
                string responseString = $"HTTP/1.1 200 OK\r\nContent-Type: application/json\r\nContent-Length: {jsonResponse.Length}\r\n\r\n{jsonResponse}";
                byte[] responseBuffer = Encoding.UTF8.GetBytes(responseString);

                await stream.WriteAsync(responseBuffer, 0, responseBuffer.Length);
            }

            client.Close();
        }
        
        private bool CheckPasswordInDatabase(string senha)
        {
            bool exists = false;
            using (var connection = new SQLiteConnection("Data Source=C:\\Program Files (x86)\\Next Fit\\Controle de acesso\\banco.db3"))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CLIENTES WHERE SENHACATRACA = @senha OR SENHACATRACA IN (SELECT SENHACATRACA FROM USUARIO WHERE SENHACATRACA = @senha)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@senha", senha);
                    exists = Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
            return exists;
        }
        
        private (string id, string senha) GetIdAndSenhaFromRequest(string request)
        {
            string id = "";
            string senha = "";

            if (request.Contains("/recebeSenha?id="))
            {
                int startIndex = request.IndexOf("/recebeSenha?id=") + "/recebeSenha?id=".Length;
                int endIndex = request.IndexOf('&', startIndex);

                if (endIndex != -1)
                {
                    id = request.Substring(startIndex, endIndex - startIndex);

                    int senhaStartIndex = request.IndexOf("senha=", endIndex) + "senha=".Length;
                    int senhaEndIndex = request.IndexOf(' ', senhaStartIndex);
                    if (senhaEndIndex == -1) senhaEndIndex = request.Length;

                    senha = request.Substring(senhaStartIndex, senhaEndIndex - senhaStartIndex);
                }
            }

            return (id, senha);
        }

        
        static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        
        public async Task SendHttpRequest()
        {
            Console.WriteLine("Enviando servidor para catraca...");
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"http://{ipCatraca}:80/salvaOperacao?online=1&servidor=http://{ipServidor}:8055/API";
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Servidor enviado com sucesso!");
                    //Console.WriteLine(responseBody);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("Erro ao enviar servidor:");
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Configuracoes f = new Frm_Configuracoes();
            f.ReceberIpCatraca(ipCatraca);
            f.ShowDialog();
        }

        private async void btn_LiberaEntrada_Click(object sender, EventArgs e)
        {
            

            try
            {
                string url = $"http://{ipCatraca}/liberacaoGiro?libera=2";

                //HttpResponseMessage response = await _httpClient.GetAsync(url);
                var content = new StringContent("{\"libera\":2}", Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Liberação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao liberar catraca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar a requisição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_LiberarSaída_Click(object sender, EventArgs e)
        {
            string url = $"http://{ipCatraca}/liberacaoGiro?libera=3";

            //HttpResponseMessage response = await _httpClient.GetAsync(url);
            var content = new StringContent("{\"libera\":3}", Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Liberação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao liberar catraca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_LiberarEntradaSaida_Click(object sender, EventArgs e)
        {
            string url = $"http://{ipCatraca}/liberacaoGiro?libera=1";

            //HttpResponseMessage response = await _httpClient.GetAsync(url);
            var content = new StringContent("{\"libera\":1}", Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Liberação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao liberar catraca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
