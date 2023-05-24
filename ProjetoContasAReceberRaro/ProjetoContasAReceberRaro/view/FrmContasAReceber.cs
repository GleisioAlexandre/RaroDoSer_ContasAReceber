using ProjetoContasAReceberRaro.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContasAReceberRaro.view
{
    public partial class FrmContasAReceber : Form
    {

        public FrmContasAReceber()
        {
            InitializeComponent();
            dtgContasAReceber.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dtgContasAReceber_RowPrePaint);
        }
        //**********************Metodos******************************
        public void CarregaGridContas()
        {
            try
            {
                ClassCrudContasAReceber contasARecber = new ClassCrudContasAReceber();
                dtgContasAReceber.DataSource = contasARecber.CarregaGridConatas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o banco de dados!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SomaGrid()
        {
            double emdia = 0;
            double atrasado = 0;
            double pago = 0;
            foreach (DataGridViewRow coluna in dtgContasAReceber.Rows)
            {
                if (coluna.Cells["situacao"].Value.ToString() == "EM DIA")
                {
                    double valorEmDia = Convert.ToDouble(coluna.Cells["Valor"].Value);
                    emdia += valorEmDia;
                }
                else if (coluna.Cells["situacao"].Value.ToString() == "ATRASADO")
                {
                    double ValorAtrasado = Convert.ToDouble(coluna.Cells["Valor"].Value);
                    atrasado += ValorAtrasado;
                }
                else 
                {
                    double valorPAgo = Convert.ToDouble(coluna.Cells["valor"].Value);
                    pago += valorPAgo;
                }
                lblEmdia.Text = emdia.ToString("C2");
                lblAtrasado.Text = atrasado.ToString("C2");
                lblPago.Text = pago.ToString("C2");
            }
        }
        //***********************************************************
        private void FrmContasAReceber_Load(object sender, EventArgs e)
        {
            CarregaGridContas();
            SomaGrid();
           
        }
        private void lblInserir_Click(object sender, EventArgs e)
        {
            view.FrmIncluirContasAReceber CadContas = new FrmIncluirContasAReceber(this);
            CadContas.ShowDialog();
        }


        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            CarregaGridContas();
        }

        private void dtgContasAReceber_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            string status = dtgContasAReceber.Rows[e.RowIndex].Cells[8].Value.ToString();
            if (status == "EM DIA")
            {
                dtgContasAReceber.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Blue;
            }
        }
    }
}
