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
        }
        //**********************Metodos******************************
        //Metodo usado para carregar as contas a receberem
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
        private void InteracaoGrid()
        {
           
                double emdia = 0;
            double atrasado = 0;
                foreach (DataGridViewRow coluna in dtgContasAReceber.Rows)
                {
                    if (coluna.Cells["situacao"].Value.ToString() == "EM DIA")
                    {
                        double valorEmdia = Convert.ToDouble(coluna.Cells["Valor"].Value);
                        emdia += valorEmdia;
                    }else if (coluna.Cells["situacao"].Value.ToString() == "ATRASADO")
                    {
                        double ValorAtrasado = Convert.ToDouble(coluna.Cells["Valor"].Value);
                        atrasado += ValorAtrasado;
                }
                else
                {

                }
                    lblEmdia.Text = emdia.ToString();
                lblAtrasado.Text = atrasado.ToString();
                }
            
        }
        //***********************************************************
        private void FrmContasAReceber_Load(object sender, EventArgs e)
        {
            CarregaGridContas();
            InteracaoGrid();
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
    }
}
