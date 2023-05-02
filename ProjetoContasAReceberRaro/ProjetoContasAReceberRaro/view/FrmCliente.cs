using FirebirdSql.Data.FirebirdClient;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            dtgCliente.DataSource = crud.CarregaGridCliente();
            dtgCliente.Sort(dtgCliente.Columns[0], ListSortDirection.Ascending);
        }

        private void lblInseir_Click(object sender, EventArgs e)
        {
            FrmInserirCliente inserirCliente = new FrmInserirCliente();
            inserirCliente.ShowDialog();
        }

        private void lblDeletar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgCliente.CurrentRow.Cells["codigo"].Value.ToString());
           if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja remover o registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                ClassCrudCliente crud = new ClassCrudCliente();
                crud.DeletarCliente(id);
                dtgCliente.DataSource = crud.CarregaGridCliente();
                dtgCliente.Sort(dtgCliente.Columns[0], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Operação canelada pelo usuários !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void lblAtualizar_Click(object sender, EventArgs e)
        {
            ClassCrudCliente crud = new ClassCrudCliente();
            dtgCliente.DataSource = crud.CarregaGridCliente();
            dtgCliente.Sort(dtgCliente.Columns[0], ListSortDirection.Ascending);
        }
    }
}
