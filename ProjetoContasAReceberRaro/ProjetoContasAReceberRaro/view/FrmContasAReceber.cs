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
            dtgContasAReceber.RowPrePaint += dtgContasAReceber_RowPrePaint;
        }
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dtgContasAReceber.Rows[e.RowIndex];
                string situacao = linha.Cells["situacao"].Value.ToString();
                if (situacao == "ATRASADO")
                {
                    linha.DefaultCellStyle.BackColor = Color.Red;
                    linha.DefaultCellStyle.ForeColor = Color.White;
                }else if (situacao == "EM DIA")
                {
                    linha.DefaultCellStyle.BackColor = Color.Blue;
                    linha.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    linha.DefaultCellStyle.BackColor = Color.Green;
                    linha.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            rbTodos.Checked = true;
            string cliente = "column1";
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            DataTable dt = new DataTable();
            dt = crud.CarregaGridConatas();
            dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'",cliente, txtFiltro.Text);
            dtgContasAReceber.DataSource = dt;
            txtFiltro.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string emdia = null;
            if (rbEmDia.Checked == true)
            {
                emdia = "EM DIA";
            }
            else
            {
                emdia = null;
            }
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            DataTable dt = new DataTable();
            dt = crud.CarregaGridConatas();
            dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "column2", emdia);
            dtgContasAReceber.DataSource = dt;
        }

        private void rbPago_CheckedChanged(object sender, EventArgs e)
        {
            string pago = null;
            if (rbPago.Checked == true)
            {
                pago = "PAGO";
            }
            else
            {
                pago = null;
            }
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            DataTable dt = new DataTable();
            dt = crud.CarregaGridConatas();
            dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "column2", pago);
            dtgContasAReceber.DataSource = dt;
        }

        private void Atrasado_CheckedChanged(object sender, EventArgs e)
        {
            string atrasado = null;
            if (rbAtrasado.Checked == true)
            {
                atrasado = "ATRASADO";
            }
            else
            {
                atrasado = null;
            }
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            DataTable dt = new DataTable();
            dt = crud.CarregaGridConatas();
            dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "column2", atrasado);
            dtgContasAReceber.DataSource = dt;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            ClassCrudContasAReceber crud = new ClassCrudContasAReceber();
            DataTable dt = new DataTable();
            dt = crud.CarregaGridConatas();
            dt.DefaultView.RowFilter = string.Format("[{0}] like '%{1}%'", "column2", "");
            dtgContasAReceber.DataSource = dt;
        }
    }
}
