namespace ProjetoContasAReceberRaro.view
{
    partial class FrmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precocusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precovenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProduto
            // 
            this.dtgProduto.AllowUserToAddRows = false;
            this.dtgProduto.AllowUserToDeleteRows = false;
            this.dtgProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.Descricao,
            this.codigoDeBarras,
            this.grupo,
            this.precocusto,
            this.precovenda});
            this.dtgProduto.Location = new System.Drawing.Point(-2, 1);
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.ReadOnly = true;
            this.dtgProduto.Size = new System.Drawing.Size(1114, 496);
            this.dtgProduto.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1111, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "ID_PRODUTO";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "NOME_PRODUTO";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descricao.DataPropertyName = "DESCRICAO";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            // 
            // codigoDeBarras
            // 
            this.codigoDeBarras.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoDeBarras.DataPropertyName = "CODIGO_DE_BARRAS";
            this.codigoDeBarras.HeaderText = "Código de Barras";
            this.codigoDeBarras.Name = "codigoDeBarras";
            this.codigoDeBarras.ReadOnly = true;
            // 
            // grupo
            // 
            this.grupo.DataPropertyName = "GRUPO_PRODUTO";
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            // 
            // precocusto
            // 
            this.precocusto.DataPropertyName = "PRECO_CUSTO";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precocusto.DefaultCellStyle = dataGridViewCellStyle1;
            this.precocusto.HeaderText = "Preço de Custo";
            this.precocusto.Name = "precocusto";
            this.precocusto.ReadOnly = true;
            this.precocusto.Width = 174;
            // 
            // precovenda
            // 
            this.precovenda.DataPropertyName = "PRECO_VENDA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.precovenda.DefaultCellStyle = dataGridViewCellStyle2;
            this.precovenda.HeaderText = "Preço de Venda";
            this.precovenda.Name = "precovenda";
            this.precovenda.ReadOnly = true;
            this.precovenda.Width = 174;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dtgProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProduto;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precocusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precovenda;
    }
}