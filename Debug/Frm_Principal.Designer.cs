﻿namespace Debug
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_LiberaEntrada = new System.Windows.Forms.Button();
            this.btn_LiberarEntradaSaida = new System.Windows.Forms.Button();
            this.btn_LiberarSaída = new System.Windows.Forms.Button();
            this.lbl_IpCatraca = new System.Windows.Forms.Label();
            this.txt_IpCatraca = new System.Windows.Forms.TextBox();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(93, 34);
            this.configurarToolStripMenuItem.Text = "Configurar";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click);
            // 
            // btn_LiberaEntrada
            // 
            this.btn_LiberaEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LiberaEntrada.Location = new System.Drawing.Point(21, 139);
            this.btn_LiberaEntrada.Name = "btn_LiberaEntrada";
            this.btn_LiberaEntrada.Size = new System.Drawing.Size(230, 121);
            this.btn_LiberaEntrada.TabIndex = 3;
            this.btn_LiberaEntrada.Text = "Liberar entrada";
            this.btn_LiberaEntrada.UseVisualStyleBackColor = true;
            this.btn_LiberaEntrada.Click += new System.EventHandler(this.btn_LiberaEntrada_Click);
            // 
            // btn_LiberarEntradaSaida
            // 
            this.btn_LiberarEntradaSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LiberarEntradaSaida.Location = new System.Drawing.Point(537, 139);
            this.btn_LiberarEntradaSaida.Name = "btn_LiberarEntradaSaida";
            this.btn_LiberarEntradaSaida.Size = new System.Drawing.Size(230, 121);
            this.btn_LiberarEntradaSaida.TabIndex = 5;
            this.btn_LiberarEntradaSaida.Text = "Liberar ambos";
            this.btn_LiberarEntradaSaida.UseVisualStyleBackColor = true;
            this.btn_LiberarEntradaSaida.Click += new System.EventHandler(this.btn_LiberarEntradaSaida_Click);
            // 
            // btn_LiberarSaída
            // 
            this.btn_LiberarSaída.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LiberarSaída.Location = new System.Drawing.Point(278, 139);
            this.btn_LiberarSaída.Name = "btn_LiberarSaída";
            this.btn_LiberarSaída.Size = new System.Drawing.Size(230, 121);
            this.btn_LiberarSaída.TabIndex = 4;
            this.btn_LiberarSaída.Text = "Liberar saída";
            this.btn_LiberarSaída.UseVisualStyleBackColor = true;
            this.btn_LiberarSaída.Click += new System.EventHandler(this.btn_LiberarSaída_Click);
            // 
            // lbl_IpCatraca
            // 
            this.lbl_IpCatraca.AutoSize = true;
            this.lbl_IpCatraca.Location = new System.Drawing.Point(18, 57);
            this.lbl_IpCatraca.Name = "lbl_IpCatraca";
            this.lbl_IpCatraca.Size = new System.Drawing.Size(170, 16);
            this.lbl_IpCatraca.TabIndex = 4;
            this.lbl_IpCatraca.Text = "Digite o atual IP da catraca:";
            // 
            // txt_IpCatraca
            // 
            this.txt_IpCatraca.Location = new System.Drawing.Point(205, 54);
            this.txt_IpCatraca.Name = "txt_IpCatraca";
            this.txt_IpCatraca.Size = new System.Drawing.Size(203, 22);
            this.txt_IpCatraca.TabIndex = 1;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Conectar.Location = new System.Drawing.Point(414, 53);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(94, 23);
            this.btn_Conectar.TabIndex = 2;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseVisualStyleBackColor = true;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(792, 297);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.txt_IpCatraca);
            this.Controls.Add(this.lbl_IpCatraca);
            this.Controls.Add(this.btn_LiberarSaída);
            this.Controls.Add(this.btn_LiberarEntradaSaida);
            this.Controls.Add(this.btn_LiberaEntrada);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debug";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.Button btn_LiberaEntrada;
        private System.Windows.Forms.Button btn_LiberarEntradaSaida;
        private System.Windows.Forms.Button btn_LiberarSaída;
        private System.Windows.Forms.Label lbl_IpCatraca;
        private System.Windows.Forms.TextBox txt_IpCatraca;
        private System.Windows.Forms.Button btn_Conectar;
    }
}

