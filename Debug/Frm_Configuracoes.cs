using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Debug
{
    public partial class Frm_Configuracoes : Form
    {

        public string ipCatracaFormPrincipal;
        
        private HttpClient _httpClient;
        public Frm_Configuracoes()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            //_httpClient.BaseAddress = new Uri("http://localhost:5032/Debug/");
            
        }

        public void ReceberIpCatraca(string ipCatraca)
        {
            ipCatracaFormPrincipal = ipCatraca;
            // Use ipCatracaConfigurado conforme necessário
        }

        private async void btn_EnviarRede_Click(object sender, EventArgs e)
        {
            string ip = txt_Ip.Text;
            string mascara = txt_Mascara.Text;
            string gateway = txt_Gateway.Text;
            string porta = txt_Porta.Text;

            string url = $"http://{ipCatracaFormPrincipal}/setIP?ip={ip}&mascara={mascara}&gateway={gateway}&porta={porta}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Configuração de IP realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao configurar IP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_EnviarTempoAcionamento_Click(object sender, EventArgs e)
        {
            int tempoAcionamento = Convert.ToInt32(txt_TempoAcionamento.Text);

            string url = $"http://{ipCatracaFormPrincipal}/setAcionamento?tempoAcionamento={tempoAcionamento}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Tempo de acionamento configurado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao configurar tempo de acionamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_EnviarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text;
            string senha = txt_Senha.Text;

            string url = $"http://{ipCatracaFormPrincipal}/setLogin?usuario={usuario}&senha={senha}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Credenciais alteradas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao alterar credenciais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_EnviarSentidoGiro_Click(object sender, EventArgs e)
        {
            string sentidoGiroID = txt_SentidoGiro.Text;
            string inverteGiro = chk_InverteGiro.Checked ? "1" : "2";

            string url = $"http://{ipCatracaFormPrincipal}/setConfigGiro?sentidoGiroID={sentidoGiroID}&inverteGiro={inverteGiro}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Parâmetros definidos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao definir parâmetros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_EnviarLeitoras_Click(object sender, EventArgs e)
        {
            int tipoGiro = Convert.ToInt32(txt_Leitoras.Text);

            string url = $"http://{ipCatracaFormPrincipal}/setTipoGiro?tipoGiro={tipoGiro}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Parâmetros definidos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao definir parâmetros.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    
}
