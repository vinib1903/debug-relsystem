using Debug.Models;

namespace Debug
{
    partial class Frm_Configuracoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Configuracoes));
            this.grp_Ip = new System.Windows.Forms.GroupBox();
            this.lbl_Gateway = new System.Windows.Forms.Label();
            this.lbl_Porta = new System.Windows.Forms.Label();
            this.lbl_Mascara = new System.Windows.Forms.Label();
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.txt_Mascara = new System.Windows.Forms.TextBox();
            this.txt_Ip = new System.Windows.Forms.TextBox();
            this.txt_Porta = new System.Windows.Forms.TextBox();
            this.txt_Gateway = new System.Windows.Forms.TextBox();
            this.btn_EnviarRede = new System.Windows.Forms.Button();
            this.grp_Usuario = new System.Windows.Forms.GroupBox();
            this.btn_EnviarLogin = new System.Windows.Forms.Button();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.grp_Acionamento = new System.Windows.Forms.GroupBox();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.btn_EnviarTempoAcionamento = new System.Windows.Forms.Button();
            this.txt_TempoAcionamento = new System.Windows.Forms.TextBox();
            this.grp_SentidoGiro = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_EnviarSentidoGiro = new System.Windows.Forms.Button();
            this.lbl_SentidoGiro = new System.Windows.Forms.Label();
            this.txt_SentidoGiro = new System.Windows.Forms.TextBox();
            this.chk_InverteGiro = new System.Windows.Forms.CheckBox();
            this.grp_Leitoras = new System.Windows.Forms.GroupBox();
            this.txt_Leitoras = new System.Windows.Forms.TextBox();
            this.lbl_TipoLeitor = new System.Windows.Forms.Label();
            this.btn_EnviarLeitoras = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grp_Ip.SuspendLayout();
            this.grp_Usuario.SuspendLayout();
            this.grp_Acionamento.SuspendLayout();
            this.grp_SentidoGiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_Leitoras.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Ip
            // 
            this.grp_Ip.Controls.Add(this.lbl_Gateway);
            this.grp_Ip.Controls.Add(this.lbl_Porta);
            this.grp_Ip.Controls.Add(this.lbl_Mascara);
            this.grp_Ip.Controls.Add(this.lbl_Ip);
            this.grp_Ip.Controls.Add(this.txt_Mascara);
            this.grp_Ip.Controls.Add(this.txt_Ip);
            this.grp_Ip.Controls.Add(this.txt_Porta);
            this.grp_Ip.Controls.Add(this.txt_Gateway);
            this.grp_Ip.Controls.Add(this.btn_EnviarRede);
            this.grp_Ip.Location = new System.Drawing.Point(12, 12);
            this.grp_Ip.Name = "grp_Ip";
            this.grp_Ip.Size = new System.Drawing.Size(224, 270);
            this.grp_Ip.TabIndex = 1;
            this.grp_Ip.TabStop = false;
            this.grp_Ip.Text = "Rede";
            // 
            // lbl_Gateway
            // 
            this.lbl_Gateway.AutoSize = true;
            this.lbl_Gateway.Location = new System.Drawing.Point(6, 170);
            this.lbl_Gateway.Name = "lbl_Gateway";
            this.lbl_Gateway.Size = new System.Drawing.Size(60, 16);
            this.lbl_Gateway.TabIndex = 8;
            this.lbl_Gateway.Text = "Gateway";
            // 
            // lbl_Porta
            // 
            this.lbl_Porta.AutoSize = true;
            this.lbl_Porta.Location = new System.Drawing.Point(6, 123);
            this.lbl_Porta.Name = "lbl_Porta";
            this.lbl_Porta.Size = new System.Drawing.Size(39, 16);
            this.lbl_Porta.TabIndex = 7;
            this.lbl_Porta.Text = "Porta";
            // 
            // lbl_Mascara
            // 
            this.lbl_Mascara.AutoSize = true;
            this.lbl_Mascara.Location = new System.Drawing.Point(6, 71);
            this.lbl_Mascara.Name = "lbl_Mascara";
            this.lbl_Mascara.Size = new System.Drawing.Size(60, 16);
            this.lbl_Mascara.TabIndex = 6;
            this.lbl_Mascara.Text = "Máscara";
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Location = new System.Drawing.Point(6, 21);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(19, 16);
            this.lbl_Ip.TabIndex = 5;
            this.lbl_Ip.Text = "IP";
            // 
            // txt_Mascara
            // 
            this.txt_Mascara.Location = new System.Drawing.Point(6, 90);
            this.txt_Mascara.Name = "txt_Mascara";
            this.txt_Mascara.Size = new System.Drawing.Size(212, 22);
            this.txt_Mascara.TabIndex = 2;
            // 
            // txt_Ip
            // 
            this.txt_Ip.Location = new System.Drawing.Point(6, 40);
            this.txt_Ip.Name = "txt_Ip";
            this.txt_Ip.Size = new System.Drawing.Size(212, 22);
            this.txt_Ip.TabIndex = 1;
            // 
            // txt_Porta
            // 
            this.txt_Porta.Location = new System.Drawing.Point(6, 142);
            this.txt_Porta.Name = "txt_Porta";
            this.txt_Porta.Size = new System.Drawing.Size(212, 22);
            this.txt_Porta.TabIndex = 3;
            // 
            // txt_Gateway
            // 
            this.txt_Gateway.Location = new System.Drawing.Point(6, 189);
            this.txt_Gateway.Name = "txt_Gateway";
            this.txt_Gateway.Size = new System.Drawing.Size(212, 22);
            this.txt_Gateway.TabIndex = 4;
            // 
            // btn_EnviarRede
            // 
            this.btn_EnviarRede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EnviarRede.Location = new System.Drawing.Point(67, 228);
            this.btn_EnviarRede.Name = "btn_EnviarRede";
            this.btn_EnviarRede.Size = new System.Drawing.Size(75, 23);
            this.btn_EnviarRede.TabIndex = 5;
            this.btn_EnviarRede.Text = "Enviar";
            this.btn_EnviarRede.UseVisualStyleBackColor = true;
            this.btn_EnviarRede.Click += new System.EventHandler(this.btn_EnviarRede_Click);
            // 
            // grp_Usuario
            // 
            this.grp_Usuario.Controls.Add(this.btn_EnviarLogin);
            this.grp_Usuario.Controls.Add(this.txt_Senha);
            this.grp_Usuario.Controls.Add(this.txt_Usuario);
            this.grp_Usuario.Controls.Add(this.lbl_Senha);
            this.grp_Usuario.Controls.Add(this.lbl_Usuario);
            this.grp_Usuario.Location = new System.Drawing.Point(261, 118);
            this.grp_Usuario.Name = "grp_Usuario";
            this.grp_Usuario.Size = new System.Drawing.Size(232, 164);
            this.grp_Usuario.TabIndex = 4;
            this.grp_Usuario.TabStop = false;
            this.grp_Usuario.Text = "Login";
            // 
            // btn_EnviarLogin
            // 
            this.btn_EnviarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EnviarLogin.Location = new System.Drawing.Point(79, 122);
            this.btn_EnviarLogin.Name = "btn_EnviarLogin";
            this.btn_EnviarLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_EnviarLogin.TabIndex = 13;
            this.btn_EnviarLogin.Text = "Enviar";
            this.btn_EnviarLogin.UseVisualStyleBackColor = true;
            this.btn_EnviarLogin.Click += new System.EventHandler(this.btn_EnviarLogin_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(6, 89);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(212, 22);
            this.txt_Senha.TabIndex = 12;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(6, 45);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(212, 22);
            this.txt_Usuario.TabIndex = 11;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(6, 70);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(46, 16);
            this.lbl_Senha.TabIndex = 1;
            this.lbl_Senha.Text = "Senha";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(6, 26);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(54, 16);
            this.lbl_Usuario.TabIndex = 0;
            this.lbl_Usuario.Text = "Usuário";
            // 
            // grp_Acionamento
            // 
            this.grp_Acionamento.Controls.Add(this.lbl_Tempo);
            this.grp_Acionamento.Controls.Add(this.btn_EnviarTempoAcionamento);
            this.grp_Acionamento.Controls.Add(this.txt_TempoAcionamento);
            this.grp_Acionamento.Location = new System.Drawing.Point(12, 299);
            this.grp_Acionamento.Name = "grp_Acionamento";
            this.grp_Acionamento.Size = new System.Drawing.Size(224, 112);
            this.grp_Acionamento.TabIndex = 2;
            this.grp_Acionamento.TabStop = false;
            this.grp_Acionamento.Text = "Tempo de Acionamento";
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.AutoSize = true;
            this.lbl_Tempo.Location = new System.Drawing.Point(6, 27);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(80, 16);
            this.lbl_Tempo.TabIndex = 2;
            this.lbl_Tempo.Text = "Tempo (ms)";
            // 
            // btn_EnviarTempoAcionamento
            // 
            this.btn_EnviarTempoAcionamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EnviarTempoAcionamento.Location = new System.Drawing.Point(92, 46);
            this.btn_EnviarTempoAcionamento.Name = "btn_EnviarTempoAcionamento";
            this.btn_EnviarTempoAcionamento.Size = new System.Drawing.Size(75, 23);
            this.btn_EnviarTempoAcionamento.TabIndex = 7;
            this.btn_EnviarTempoAcionamento.Text = "Enviar";
            this.btn_EnviarTempoAcionamento.UseVisualStyleBackColor = true;
            this.btn_EnviarTempoAcionamento.Click += new System.EventHandler(this.btn_EnviarTempoAcionamento_Click);
            // 
            // txt_TempoAcionamento
            // 
            this.txt_TempoAcionamento.Location = new System.Drawing.Point(6, 46);
            this.txt_TempoAcionamento.Name = "txt_TempoAcionamento";
            this.txt_TempoAcionamento.Size = new System.Drawing.Size(80, 22);
            this.txt_TempoAcionamento.TabIndex = 6;
            // 
            // grp_SentidoGiro
            // 
            this.grp_SentidoGiro.Controls.Add(this.pictureBox1);
            this.grp_SentidoGiro.Controls.Add(this.btn_EnviarSentidoGiro);
            this.grp_SentidoGiro.Controls.Add(this.lbl_SentidoGiro);
            this.grp_SentidoGiro.Controls.Add(this.txt_SentidoGiro);
            this.grp_SentidoGiro.Controls.Add(this.chk_InverteGiro);
            this.grp_SentidoGiro.Location = new System.Drawing.Point(261, 12);
            this.grp_SentidoGiro.Name = "grp_SentidoGiro";
            this.grp_SentidoGiro.Size = new System.Drawing.Size(232, 100);
            this.grp_SentidoGiro.TabIndex = 3;
            this.grp_SentidoGiro.TabStop = false;
            this.grp_SentidoGiro.Text = "Sentido de Giro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Valores:\n1 - Entrada e saída liberadas\n2- Controla saída\n3 - Controla entrada\nund" +
        "efined (entrada e saída bloqueadas)");
            // 
            // btn_EnviarSentidoGiro
            // 
            this.btn_EnviarSentidoGiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EnviarSentidoGiro.Location = new System.Drawing.Point(113, 49);
            this.btn_EnviarSentidoGiro.Name = "btn_EnviarSentidoGiro";
            this.btn_EnviarSentidoGiro.Size = new System.Drawing.Size(84, 23);
            this.btn_EnviarSentidoGiro.TabIndex = 10;
            this.btn_EnviarSentidoGiro.Text = "Enviar";
            this.btn_EnviarSentidoGiro.UseVisualStyleBackColor = true;
            this.btn_EnviarSentidoGiro.Click += new System.EventHandler(this.btn_EnviarSentidoGiro_Click);
            // 
            // lbl_SentidoGiro
            // 
            this.lbl_SentidoGiro.AutoSize = true;
            this.lbl_SentidoGiro.Location = new System.Drawing.Point(6, 24);
            this.lbl_SentidoGiro.Name = "lbl_SentidoGiro";
            this.lbl_SentidoGiro.Size = new System.Drawing.Size(101, 16);
            this.lbl_SentidoGiro.TabIndex = 2;
            this.lbl_SentidoGiro.Text = "Sentido do giro:";
            // 
            // txt_SentidoGiro
            // 
            this.txt_SentidoGiro.Location = new System.Drawing.Point(113, 21);
            this.txt_SentidoGiro.Name = "txt_SentidoGiro";
            this.txt_SentidoGiro.Size = new System.Drawing.Size(84, 22);
            this.txt_SentidoGiro.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txt_SentidoGiro, "\r\n");
            // 
            // chk_InverteGiro
            // 
            this.chk_InverteGiro.AutoSize = true;
            this.chk_InverteGiro.Location = new System.Drawing.Point(13, 52);
            this.chk_InverteGiro.Name = "chk_InverteGiro";
            this.chk_InverteGiro.Size = new System.Drawing.Size(73, 20);
            this.chk_InverteGiro.TabIndex = 9;
            this.chk_InverteGiro.Text = "Inverter";
            this.chk_InverteGiro.UseVisualStyleBackColor = false;
            // 
            // grp_Leitoras
            // 
            this.grp_Leitoras.Controls.Add(this.txt_Leitoras);
            this.grp_Leitoras.Controls.Add(this.lbl_TipoLeitor);
            this.grp_Leitoras.Controls.Add(this.btn_EnviarLeitoras);
            this.grp_Leitoras.Location = new System.Drawing.Point(261, 299);
            this.grp_Leitoras.Name = "grp_Leitoras";
            this.grp_Leitoras.Size = new System.Drawing.Size(232, 112);
            this.grp_Leitoras.TabIndex = 5;
            this.grp_Leitoras.TabStop = false;
            this.grp_Leitoras.Text = "Leitoras";
            // 
            // txt_Leitoras
            // 
            this.txt_Leitoras.Location = new System.Drawing.Point(9, 47);
            this.txt_Leitoras.Name = "txt_Leitoras";
            this.txt_Leitoras.Size = new System.Drawing.Size(100, 22);
            this.txt_Leitoras.TabIndex = 14;
            // 
            // lbl_TipoLeitor
            // 
            this.lbl_TipoLeitor.AutoSize = true;
            this.lbl_TipoLeitor.Location = new System.Drawing.Point(8, 27);
            this.lbl_TipoLeitor.Name = "lbl_TipoLeitor";
            this.lbl_TipoLeitor.Size = new System.Drawing.Size(55, 16);
            this.lbl_TipoLeitor.TabIndex = 1;
            this.lbl_TipoLeitor.Text = "Leitoras";
            // 
            // btn_EnviarLeitoras
            // 
            this.btn_EnviarLeitoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EnviarLeitoras.Location = new System.Drawing.Point(122, 47);
            this.btn_EnviarLeitoras.Name = "btn_EnviarLeitoras";
            this.btn_EnviarLeitoras.Size = new System.Drawing.Size(75, 23);
            this.btn_EnviarLeitoras.TabIndex = 15;
            this.btn_EnviarLeitoras.Text = "Enviar";
            this.btn_EnviarLeitoras.UseVisualStyleBackColor = true;
            this.btn_EnviarLeitoras.Click += new System.EventHandler(this.btn_EnviarLeitoras_Click);
            // 
            // Frm_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 423);
            this.Controls.Add(this.grp_Leitoras);
            this.Controls.Add(this.grp_SentidoGiro);
            this.Controls.Add(this.grp_Acionamento);
            this.Controls.Add(this.grp_Usuario);
            this.Controls.Add(this.grp_Ip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Configuracoes";
            this.Text = "Configurações";
            this.grp_Ip.ResumeLayout(false);
            this.grp_Ip.PerformLayout();
            this.grp_Usuario.ResumeLayout(false);
            this.grp_Usuario.PerformLayout();
            this.grp_Acionamento.ResumeLayout(false);
            this.grp_Acionamento.PerformLayout();
            this.grp_SentidoGiro.ResumeLayout(false);
            this.grp_SentidoGiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_Leitoras.ResumeLayout(false);
            this.grp_Leitoras.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Ip;
        private System.Windows.Forms.Label lbl_Porta;
        private System.Windows.Forms.Label lbl_Mascara;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.TextBox txt_Mascara;
        private System.Windows.Forms.TextBox txt_Ip;
        private System.Windows.Forms.TextBox txt_Porta;
        private System.Windows.Forms.TextBox txt_Gateway;
        private System.Windows.Forms.Button btn_EnviarRede;
        private System.Windows.Forms.Label lbl_Gateway;
        private System.Windows.Forms.GroupBox grp_Usuario;
        private System.Windows.Forms.Button btn_EnviarLogin;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.GroupBox grp_Acionamento;
        private System.Windows.Forms.Label lbl_Tempo;
        private System.Windows.Forms.Button btn_EnviarTempoAcionamento;
        private System.Windows.Forms.TextBox txt_TempoAcionamento;
        private System.Windows.Forms.GroupBox grp_SentidoGiro;
        private System.Windows.Forms.CheckBox chk_InverteGiro;
        private System.Windows.Forms.Label lbl_SentidoGiro;
        private System.Windows.Forms.TextBox txt_SentidoGiro;
        private System.Windows.Forms.Button btn_EnviarSentidoGiro;
        private System.Windows.Forms.GroupBox grp_Leitoras;
        private System.Windows.Forms.TextBox txt_Leitoras;
        private System.Windows.Forms.Label lbl_TipoLeitor;
        private System.Windows.Forms.Button btn_EnviarLeitoras;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}