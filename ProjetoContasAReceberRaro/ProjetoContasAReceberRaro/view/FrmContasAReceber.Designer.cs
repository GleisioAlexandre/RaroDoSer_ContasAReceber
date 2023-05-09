namespace ProjetoContasAReceberRaro.view
{
    partial class FrmContasAReceber
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
            this.dtgContasAReceber = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venciemnto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAReceber)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgContasAReceber
            // 
            this.dtgContasAReceber.AllowUserToAddRows = false;
            this.dtgContasAReceber.AllowUserToDeleteRows = false;
            this.dtgContasAReceber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgContasAReceber.BackgroundColor = System.Drawing.Color.White;
            this.dtgContasAReceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContasAReceber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.cliente,
            this.entrada,
            this.valor,
            this.documento,
            this.classe,
            this.venciemnto,
            this.pagamento,
            this.situacao});
            this.dtgContasAReceber.Location = new System.Drawing.Point(-1, 0);
            this.dtgContasAReceber.Name = "dtgContasAReceber";
            this.dtgContasAReceber.ReadOnly = true;
            this.dtgContasAReceber.Size = new System.Drawing.Size(802, 449);
            this.dtgContasAReceber.TabIndex = 0;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "id_contasareceber";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "column1";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // entrada
            // 
            this.entrada.DataPropertyName = "data_entrada";
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // classe
            // 
            this.classe.DataPropertyName = "column3";
            this.classe.HeaderText = "Classe";
            this.classe.Name = "classe";
            this.classe.ReadOnly = true;
            // 
            // venciemnto
            // 
            this.venciemnto.DataPropertyName = "data_vencimento";
            this.venciemnto.HeaderText = "Vencimento";
            this.venciemnto.Name = "venciemnto";
            this.venciemnto.ReadOnly = true;
            // 
            // pagamento
            // 
            this.pagamento.DataPropertyName = "data_pagamento";
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "column2";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // FrmContasAReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgContasAReceber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmContasAReceber";
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.FrmContasAReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContasAReceber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgContasAReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn venciemnto;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
    }
}