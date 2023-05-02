namespace ProjetoContasAReceberRaro.view
{
    partial class FrmCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblInseir = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAtualizar = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDeletar = new System.Windows.Forms.ToolStripStatusLabel();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complemento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.cpf,
            this.cnpj,
            this.cep,
            this.logradouro,
            this.numero,
            this.complemento,
            this.bairro,
            this.cidade,
            this.estado});
            this.dtgCliente.Location = new System.Drawing.Point(0, 0);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(1245, 571);
            this.dtgCliente.TabIndex = 0;
            this.dtgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellClick);
            this.dtgCliente.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellEndEdit);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInseir,
            this.lblAtualizar,
            this.lblDeletar});
            this.StatusStrip.Location = new System.Drawing.Point(0, 574);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1243, 26);
            this.StatusStrip.TabIndex = 1;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // lblInseir
            // 
            this.lblInseir.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblInseir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblInseir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblInseir.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.lblInseir.Name = "lblInseir";
            this.lblInseir.Size = new System.Drawing.Size(51, 21);
            this.lblInseir.Text = "Inserir";
            this.lblInseir.Click += new System.EventHandler(this.lblInseir_Click);
            // 
            // lblAtualizar
            // 
            this.lblAtualizar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblAtualizar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAtualizar.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.lblAtualizar.Name = "lblAtualizar";
            this.lblAtualizar.Size = new System.Drawing.Size(67, 21);
            this.lblAtualizar.Text = "Atualizar";
            this.lblAtualizar.Click += new System.EventHandler(this.lblAtualizar_Click);
            // 
            // lblDeletar
            // 
            this.lblDeletar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblDeletar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblDeletar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeletar.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.lblDeletar.Name = "lblDeletar";
            this.lblDeletar.Size = new System.Drawing.Size(57, 21);
            this.lblDeletar.Text = "Deletar";
            this.lblDeletar.Click += new System.EventHandler(this.lblDeletar_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_cliente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle7;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome_cliente";
            this.nome.HeaderText = "Nome / Rasão Social";
            this.nome.Name = "nome";
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf_cliente";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // cnpj
            // 
            this.cnpj.DataPropertyName = "cnpj_cliente";
            this.cnpj.HeaderText = "CNPJ";
            this.cnpj.Name = "cnpj";
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep_cliente";
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            // 
            // logradouro
            // 
            this.logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.logradouro.DataPropertyName = "logradouro_cliente";
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero_cliente";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numero.DefaultCellStyle = dataGridViewCellStyle8;
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            // 
            // complemento
            // 
            this.complemento.DataPropertyName = "complemento_cliente";
            this.complemento.HeaderText = "Complemento";
            this.complemento.Name = "complemento";
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro_cliente";
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "column1";
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            // 
            // estado
            // 
            this.estado.DataPropertyName = "column2";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estado.DefaultCellStyle = dataGridViewCellStyle9;
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 600);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.dtgCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblInseir;
        private System.Windows.Forms.ToolStripStatusLabel lblAtualizar;
        private System.Windows.Forms.ToolStripStatusLabel lblDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}