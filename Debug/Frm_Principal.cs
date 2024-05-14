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
    public partial class Frm_Principal : Form
    {

        string ipCatraca = null;
        private HttpClient _httpClient;
        public Frm_Principal()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            //_httpClient.BaseAddress = new Uri("http://localhost:5032/Debug/");

            
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

                HttpResponseMessage response = await _httpClient.GetAsync(url);
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

            HttpResponseMessage response = await _httpClient.GetAsync(url);
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

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Liberação realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao liberar catraca.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            ipCatraca = txt_IpCatraca.Text;
        }

    }
}
