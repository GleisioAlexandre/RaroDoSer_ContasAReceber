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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }
        public void CarregaGridUsuario()
        {
           
            ClassCrudUsuario crud = new ClassCrudUsuario();
            dtgUsuario.DataSource = crud.CarregaUsuario();

        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregaGridUsuario();
        }

        private void lblInseriri_Click(object sender, EventArgs e)
        {
            FrmCadUser cadUser = new FrmCadUser();
            cadUser.ShowDialog();
        }
    }
}
