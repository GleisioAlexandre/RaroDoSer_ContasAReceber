namespace ProjetoContasAReceberRaro.view
{
    partial class FrmCadastroContasAReceber
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
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpbDivida = new System.Windows.Forms.GroupBox();
            this.txtDataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.txtDataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.txtDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.lbl_id_Conta = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxSituacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxClasse = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisarDivida = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gpbCliente.SuspendLayout();
            this.gpbDivida.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCliente.Controls.Add(this.lblCodigo);
            this.gpbCliente.Controls.Add(this.txtCliente);
            this.gpbCliente.Controls.Add(this.btnPesquisar);
            this.gpbCliente.Enabled = false;
            this.gpbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCliente.Location = new System.Drawing.Point(12, 49);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(518, 104);
            this.gpbCliente.TabIndex = 0;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Cliente";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(15, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(15, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "0";
            this.lblCodigo.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(18, 50);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(375, 26);
            this.txtCliente.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(419, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 27);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gpbDivida
            // 
            this.gpbDivida.Controls.Add(this.txtDataPagamento);
            this.gpbDivida.Controls.Add(this.txtDataVencimento);
            this.gpbDivida.Controls.Add(this.txtDataEntrada);
            this.gpbDivida.Controls.Add(this.lbl_id_Conta);
            this.gpbDivida.Controls.Add(this.txtValor);
            this.gpbDivida.Controls.Add(this.cbxSituacao);
            this.gpbDivida.Controls.Add(this.label7);
            this.gpbDivida.Controls.Add(this.cbxClasse);
            this.gpbDivida.Controls.Add(this.txtDocumento);
            this.gpbDivida.Controls.Add(this.label6);
            this.gpbDivida.Controls.Add(this.label5);
            this.gpbDivida.Controls.Add(this.label4);
            this.gpbDivida.Controls.Add(this.label3);
            this.gpbDivida.Controls.Add(this.label2);
            this.gpbDivida.Controls.Add(this.label1);
            this.gpbDivida.Enabled = false;
            this.gpbDivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDivida.Location = new System.Drawing.Point(12, 192);
            this.gpbDivida.Name = "gpbDivida";
            this.gpbDivida.Size = new System.Drawing.Size(518, 221);
            this.gpbDivida.TabIndex = 1;
            this.gpbDivida.TabStop = false;
            this.gpbDivida.Text = "Dados da Divida";
            // 
            // txtDataPagamento
            // 
            this.txtDataPagamento.Location = new System.Drawing.Point(403, 55);
            this.txtDataPagamento.Mask = "00/00/0000";
            this.txtDataPagamento.Name = "txtDataPagamento";
            this.txtDataPagamento.Size = new System.Drawing.Size(100, 22);
            this.txtDataPagamento.TabIndex = 18;
            this.txtDataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataVencimento
            // 
            this.txtDataVencimento.Location = new System.Drawing.Point(204, 53);
            this.txtDataVencimento.Mask = "00/00/0000";
            this.txtDataVencimento.Name = "txtDataVencimento";
            this.txtDataVencimento.Size = new System.Drawing.Size(100, 22);
            this.txtDataVencimento.TabIndex = 17;
            this.txtDataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(9, 53);
            this.txtDataEntrada.Mask = "00/00/0000";
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(100, 22);
            this.txtDataEntrada.TabIndex = 16;
            this.txtDataEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_id_Conta
            // 
            this.lbl_id_Conta.AutoSize = true;
            this.lbl_id_Conta.Location = new System.Drawing.Point(436, 161);
            this.lbl_id_Conta.Name = "lbl_id_Conta";
            this.lbl_id_Conta.Size = new System.Drawing.Size(15, 16);
            this.lbl_id_Conta.TabIndex = 15;
            this.lbl_id_Conta.Text = "0";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(204, 122);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(109, 22);
            this.txtValor.TabIndex = 10;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbxSituacao
            // 
            this.cbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSituacao.FormattingEnabled = true;
            this.cbxSituacao.Location = new System.Drawing.Point(6, 180);
            this.cbxSituacao.Name = "cbxSituacao";
            this.cbxSituacao.Size = new System.Drawing.Size(121, 24);
            this.cbxSituacao.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Situação";
            // 
            // cbxClasse
            // 
            this.cbxClasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClasse.FormattingEnabled = true;
            this.cbxClasse.Location = new System.Drawing.Point(402, 120);
            this.cbxClasse.Name = "cbxClasse";
            this.cbxClasse.Size = new System.Drawing.Size(110, 24);
            this.cbxClasse.TabIndex = 11;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(6, 122);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(109, 22);
            this.txtDocumento.TabIndex = 9;
            this.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Classe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vencimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(135, 432);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Inserir";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(18, 432);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisarDivida
            // 
            this.btnPesquisarDivida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarDivida.Location = new System.Drawing.Point(260, 432);
            this.btnPesquisarDivida.Name = "btnPesquisarDivida";
            this.btnPesquisarDivida.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarDivida.TabIndex = 4;
            this.btnPesquisarDivida.Text = "Pesquisar";
            this.btnPesquisarDivida.UseVisualStyleBackColor = true;
            this.btnPesquisarDivida.Click += new System.EventHandler(this.btnPesquisarDivida_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(360, 432);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmCadastroContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 478);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPesquisarDivida);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbDivida);
            this.Controls.Add(this.gpbCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroContasAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Contas a Receber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadastroContasAReceber_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadastroContasAReceber_Load);
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbDivida.ResumeLayout(false);
            this.gpbDivida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gpbDivida;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSituacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxClasse;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisarDivida;
        private System.Windows.Forms.Label lbl_id_Conta;
        private System.Windows.Forms.MaskedTextBox txtDataVencimento;
        private System.Windows.Forms.MaskedTextBox txtDataEntrada;
        private System.Windows.Forms.MaskedTextBox txtDataPagamento;
        private System.Windows.Forms.Button btnEditar;
    }
}