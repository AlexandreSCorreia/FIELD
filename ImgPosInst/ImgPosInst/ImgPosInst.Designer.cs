namespace ImgPosInst
{
    partial class ImgPosInst
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
            this.label11 = new System.Windows.Forms.Label();
            this.mskTxtBoxSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.txtInformacoes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.grpBoxConfiguracoes = new System.Windows.Forms.GroupBox();
            this.ckdListBoxOpcoes = new System.Windows.Forms.CheckedListBox();
            this.cbBoxUnidades = new System.Windows.Forms.ComboBox();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.cbBoxTipoMaquina = new System.Windows.Forms.ComboBox();
            this.btnGerarHostname = new System.Windows.Forms.Button();
            this.lblTipoMaquina = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.lblControleAtivos = new System.Windows.Forms.Label();
            this.cbControleAtivos = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.grpBoxConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(13, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(318, 37);
            this.label11.TabIndex = 121;
            this.label11.Text = "As credenciais informadas no campo abaixo, servem para poder ingressar a máquina " +
    "no dominio.";
            // 
            // mskTxtBoxSenha
            // 
            this.mskTxtBoxSenha.Location = new System.Drawing.Point(92, 200);
            this.mskTxtBoxSenha.Name = "mskTxtBoxSenha";
            this.mskTxtBoxSenha.Size = new System.Drawing.Size(199, 20);
            this.mskTxtBoxSenha.TabIndex = 120;
            this.mskTxtBoxSenha.UseSystemPasswordChar = true;
            // 
            // txtBoxUsuario
            // 
            this.txtBoxUsuario.Location = new System.Drawing.Point(92, 169);
            this.txtBoxUsuario.MaxLength = 20;
            this.txtBoxUsuario.Name = "txtBoxUsuario";
            this.txtBoxUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtBoxUsuario.TabIndex = 119;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(13, 202);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 14);
            this.lblSenha.TabIndex = 118;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(13, 171);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 14);
            this.lblUsuario.TabIndex = 117;
            this.lblUsuario.Text = "Usuário (ID)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(12, 97);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 18);
            this.label15.TabIndex = 116;
            this.label15.Text = "Credenciais do Técnico";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.AutoSize = true;
            this.lblInformacoes.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacoes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.ForeColor = System.Drawing.Color.Black;
            this.lblInformacoes.Location = new System.Drawing.Point(13, 238);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(83, 14);
            this.lblInformacoes.TabIndex = 114;
            this.lblInformacoes.Text = "Informações";
            this.lblInformacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInformacoes
            // 
            this.txtInformacoes.BackColor = System.Drawing.Color.White;
            this.txtInformacoes.Location = new System.Drawing.Point(16, 263);
            this.txtInformacoes.Multiline = true;
            this.txtInformacoes.Name = "txtInformacoes";
            this.txtInformacoes.ReadOnly = true;
            this.txtInformacoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInformacoes.Size = new System.Drawing.Size(443, 141);
            this.txtInformacoes.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 25);
            this.label7.TabIndex = 113;
            this.label7.Text = "solicitado para iniciar a ferramenta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 25);
            this.label8.TabIndex = 112;
            this.label8.Text = "Preencha os dados conforme";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 5);
            this.label10.TabIndex = 111;
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.BackColor = System.Drawing.Color.Transparent;
            this.lblVersao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.ForeColor = System.Drawing.Color.Black;
            this.lblVersao.Location = new System.Drawing.Point(13, 433);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(219, 13);
            this.lblVersao.TabIndex = 110;
            this.lblVersao.Text = "Versão 0.1.0 ImgPosInst AlexandreSCorreia";
            // 
            // grpBoxConfiguracoes
            // 
            this.grpBoxConfiguracoes.Controls.Add(this.ckdListBoxOpcoes);
            this.grpBoxConfiguracoes.Controls.Add(this.cbBoxUnidades);
            this.grpBoxConfiguracoes.Controls.Add(this.lblUnidades);
            this.grpBoxConfiguracoes.Controls.Add(this.lblHostname);
            this.grpBoxConfiguracoes.Controls.Add(this.cbBoxTipoMaquina);
            this.grpBoxConfiguracoes.Controls.Add(this.btnGerarHostname);
            this.grpBoxConfiguracoes.Controls.Add(this.lblTipoMaquina);
            this.grpBoxConfiguracoes.Controls.Add(this.txtHostname);
            this.grpBoxConfiguracoes.Controls.Add(this.lblControleAtivos);
            this.grpBoxConfiguracoes.Controls.Add(this.cbControleAtivos);
            this.grpBoxConfiguracoes.Location = new System.Drawing.Point(477, 10);
            this.grpBoxConfiguracoes.Name = "grpBoxConfiguracoes";
            this.grpBoxConfiguracoes.Size = new System.Drawing.Size(188, 394);
            this.grpBoxConfiguracoes.TabIndex = 109;
            this.grpBoxConfiguracoes.TabStop = false;
            this.grpBoxConfiguracoes.Text = "Configurações";
            // 
            // ckdListBoxOpcoes
            // 
            this.ckdListBoxOpcoes.BackColor = System.Drawing.SystemColors.Control;
            this.ckdListBoxOpcoes.FormattingEnabled = true;
            this.ckdListBoxOpcoes.Location = new System.Drawing.Point(9, 254);
            this.ckdListBoxOpcoes.Name = "ckdListBoxOpcoes";
            this.ckdListBoxOpcoes.Size = new System.Drawing.Size(168, 124);
            this.ckdListBoxOpcoes.TabIndex = 14;
            // 
            // cbBoxUnidades
            // 
            this.cbBoxUnidades.FormattingEnabled = true;
            this.cbBoxUnidades.Location = new System.Drawing.Point(9, 144);
            this.cbBoxUnidades.Name = "cbBoxUnidades";
            this.cbBoxUnidades.Size = new System.Drawing.Size(168, 21);
            this.cbBoxUnidades.TabIndex = 0;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Location = new System.Drawing.Point(9, 125);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(52, 13);
            this.lblUnidades.TabIndex = 2;
            this.lblUnidades.Text = "Unidades";
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Location = new System.Drawing.Point(6, 177);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(55, 13);
            this.lblHostname.TabIndex = 13;
            this.lblHostname.Text = "Hostname";
            // 
            // cbBoxTipoMaquina
            // 
            this.cbBoxTipoMaquina.FormattingEnabled = true;
            this.cbBoxTipoMaquina.Location = new System.Drawing.Point(9, 42);
            this.cbBoxTipoMaquina.Name = "cbBoxTipoMaquina";
            this.cbBoxTipoMaquina.Size = new System.Drawing.Size(168, 21);
            this.cbBoxTipoMaquina.TabIndex = 1;
            // 
            // btnGerarHostname
            // 
            this.btnGerarHostname.Location = new System.Drawing.Point(9, 219);
            this.btnGerarHostname.Name = "btnGerarHostname";
            this.btnGerarHostname.Size = new System.Drawing.Size(168, 23);
            this.btnGerarHostname.TabIndex = 11;
            this.btnGerarHostname.Text = "Gerar Hostname";
            this.btnGerarHostname.UseVisualStyleBackColor = true;
            this.btnGerarHostname.Click += new System.EventHandler(this.btnGerarHostname_Click);
            // 
            // lblTipoMaquina
            // 
            this.lblTipoMaquina.AutoSize = true;
            this.lblTipoMaquina.Location = new System.Drawing.Point(6, 23);
            this.lblTipoMaquina.Name = "lblTipoMaquina";
            this.lblTipoMaquina.Size = new System.Drawing.Size(72, 13);
            this.lblTipoMaquina.TabIndex = 3;
            this.lblTipoMaquina.Text = "Tipo Maquina";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(9, 193);
            this.txtHostname.MaxLength = 15;
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(168, 20);
            this.txtHostname.TabIndex = 10;
            // 
            // lblControleAtivos
            // 
            this.lblControleAtivos.AutoSize = true;
            this.lblControleAtivos.Location = new System.Drawing.Point(6, 76);
            this.lblControleAtivos.Name = "lblControleAtivos";
            this.lblControleAtivos.Size = new System.Drawing.Size(93, 13);
            this.lblControleAtivos.TabIndex = 5;
            this.lblControleAtivos.Text = "Controle de Ativos";
            // 
            // cbControleAtivos
            // 
            this.cbControleAtivos.FormattingEnabled = true;
            this.cbControleAtivos.Location = new System.Drawing.Point(9, 95);
            this.cbControleAtivos.Name = "cbControleAtivos";
            this.cbControleAtivos.Size = new System.Drawing.Size(168, 21);
            this.cbControleAtivos.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(590, 423);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 108;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // ImgPosInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 457);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskTxtBoxSenha);
            this.Controls.Add(this.txtBoxUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblInformacoes);
            this.Controls.Add(this.txtInformacoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.grpBoxConfiguracoes);
            this.Controls.Add(this.btnIniciar);
            this.MaximizeBox = false;
            this.Name = "ImgPosInst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta de Pós-Instalação de Imagem";
            this.Load += new System.EventHandler(this.ImgPosInst_Load);
            this.grpBoxConfiguracoes.ResumeLayout(false);
            this.grpBoxConfiguracoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mskTxtBoxSenha;
        private System.Windows.Forms.TextBox txtBoxUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.TextBox txtInformacoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.GroupBox grpBoxConfiguracoes;
        private System.Windows.Forms.CheckedListBox ckdListBoxOpcoes;
        private System.Windows.Forms.ComboBox cbBoxUnidades;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.ComboBox cbBoxTipoMaquina;
        private System.Windows.Forms.Button btnGerarHostname;
        private System.Windows.Forms.Label lblTipoMaquina;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.Label lblControleAtivos;
        private System.Windows.Forms.ComboBox cbControleAtivos;
        private System.Windows.Forms.Button btnIniciar;
    }
}

