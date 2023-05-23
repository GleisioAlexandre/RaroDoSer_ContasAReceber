namespace ProjetoContasAReceberRaro.view
{
    partial class FrmConfiguracao
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbConfigBd = new System.Windows.Forms.GroupBox();
            this.txtCaminhoBanco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbConfigBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(887, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(142, 34);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gpbConfigBd
            // 
            this.gpbConfigBd.Controls.Add(this.txtCaminhoBanco);
            this.gpbConfigBd.Controls.Add(this.label5);
            this.gpbConfigBd.Controls.Add(this.txtPorta);
            this.gpbConfigBd.Controls.Add(this.label4);
            this.gpbConfigBd.Controls.Add(this.txtSenha);
            this.gpbConfigBd.Controls.Add(this.label3);
            this.gpbConfigBd.Controls.Add(this.txtUsuario);
            this.gpbConfigBd.Controls.Add(this.label2);
            this.gpbConfigBd.Controls.Add(this.txtServidor);
            this.gpbConfigBd.Controls.Add(this.label1);
            this.gpbConfigBd.Enabled = false;
            this.gpbConfigBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConfigBd.Location = new System.Drawing.Point(12, 12);
            this.gpbConfigBd.Name = "gpbConfigBd";
            this.gpbConfigBd.Size = new System.Drawing.Size(1017, 298);
            this.gpbConfigBd.TabIndex = 11;
            this.gpbConfigBd.TabStop = false;
            this.gpbConfigBd.Text = "Informações do Banco de Dados";
            // 
            // txtCaminhoBanco
            // 
            this.txtCaminhoBanco.Location = new System.Drawing.Point(10, 248);
            this.txtCaminhoBanco.Name = "txtCaminhoBanco";
            this.txtCaminhoBanco.Size = new System.Drawing.Size(999, 26);
            this.txtCaminhoBanco.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Caminho do Banco";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(860, 61);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(149, 26);
            this.txtPorta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(856, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Porta";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(10, 188);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(205, 26);
            this.txtSenha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(10, 123);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuário";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(10, 61);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(335, 26);
            this.txtServidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Servidor";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(710, 316);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(142, 34);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 355);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gpbConfigBd);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.FrmConfiguracao_Load);
            this.gpbConfigBd.ResumeLayout(false);
            this.gpbConfigBd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbConfigBd;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaminhoBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
    }
}