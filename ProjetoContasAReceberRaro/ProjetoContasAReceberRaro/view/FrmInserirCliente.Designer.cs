namespace ProjetoContasAReceberRaro.view
{
    partial class FrmInserirCliente
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.txtPessoa = new System.Windows.Forms.MaskedTextBox();
            this.cbxPessoa = new System.Windows.Forms.CheckBox();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btnCadatrar = new System.Windows.Forms.Button();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(6, 16);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 20);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(10, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoa.Location = new System.Drawing.Point(6, 76);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(43, 20);
            this.lblPessoa.TabIndex = 50;
            this.lblPessoa.Text = "CPF";
            // 
            // txtPessoa
            // 
            this.txtPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPessoa.Location = new System.Drawing.Point(10, 99);
            this.txtPessoa.Mask = "###,###,###-##";
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(121, 26);
            this.txtPessoa.TabIndex = 2;
            // 
            // cbxPessoa
            // 
            this.cbxPessoa.AutoSize = true;
            this.cbxPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxPessoa.Location = new System.Drawing.Point(409, 15);
            this.cbxPessoa.Name = "cbxPessoa";
            this.cbxPessoa.Size = new System.Drawing.Size(139, 24);
            this.cbxPessoa.TabIndex = 4;
            this.cbxPessoa.TabStop = false;
            this.cbxPessoa.Text = "Pessoa Jurídica";
            this.cbxPessoa.UseVisualStyleBackColor = true;
            this.cbxPessoa.CheckedChanged += new System.EventHandler(this.cbxPessoa_CheckedChanged);
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.txtPessoa);
            this.gpbDadosPessoais.Controls.Add(this.cbxPessoa);
            this.gpbDadosPessoais.Controls.Add(this.lblDescricao);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lblPessoa);
            this.gpbDadosPessoais.Enabled = false;
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 32);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(554, 139);
            this.gpbDadosPessoais.TabIndex = 5;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.cbxCidade);
            this.gpbEndereco.Controls.Add(this.cbxEstado);
            this.gpbEndereco.Controls.Add(this.label7);
            this.gpbEndereco.Controls.Add(this.label6);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.label5);
            this.gpbEndereco.Controls.Add(this.txtComplemento);
            this.gpbEndereco.Controls.Add(this.label4);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.label3);
            this.gpbEndereco.Controls.Add(this.txtLogradouro);
            this.gpbEndereco.Controls.Add(this.label2);
            this.gpbEndereco.Controls.Add(this.txtCep);
            this.gpbEndereco.Controls.Add(this.label1);
            this.gpbEndereco.Enabled = false;
            this.gpbEndereco.Location = new System.Drawing.Point(12, 188);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(554, 211);
            this.gpbEndereco.TabIndex = 6;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // cbxCidade
            // 
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Location = new System.Drawing.Point(151, 156);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(318, 28);
            this.cbxCidade.TabIndex = 8;
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "18"});
            this.cbxEstado.Location = new System.Drawing.Point(486, 155);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(62, 28);
            this.cbxEstado.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(482, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(147, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(11, 157);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(120, 26);
            this.txtBairro.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bairro";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(151, 97);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(397, 26);
            this.txtComplemento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(147, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(11, 97);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(95, 26);
            this.txtNumero.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(151, 42);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(397, 26);
            this.txtLogradouro.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logradouro";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtCep.Location = new System.Drawing.Point(11, 42);
            this.txtCep.Mask = "#####-###";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(95, 26);
            this.txtCep.TabIndex = 3;
            this.txtCep.Validated += new System.EventHandler(this.txtCep_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP";
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(23, 421);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 7;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btnCadatrar
            // 
            this.btnCadatrar.Enabled = false;
            this.btnCadatrar.Location = new System.Drawing.Point(127, 421);
            this.btnCadatrar.Name = "btnCadatrar";
            this.btnCadatrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadatrar.TabIndex = 8;
            this.btnCadatrar.Text = "Cadastrar";
            this.btnCadatrar.UseVisualStyleBackColor = true;
            this.btnCadatrar.Click += new System.EventHandler(this.btnCadatrar_Click);
            // 
            // FrmInserirCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 456);
            this.Controls.Add(this.btnCadatrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInserirCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.FrmInserirCliente_Load);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.MaskedTextBox txtPessoa;
        private System.Windows.Forms.CheckBox cbxPessoa;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btnCadatrar;
        private System.Windows.Forms.ComboBox cbxCidade;
    }
}