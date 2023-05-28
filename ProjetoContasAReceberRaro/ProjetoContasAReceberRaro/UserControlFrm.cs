using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoContasAReceberRaro
{
    public partial class UserControlFrm : UserControl
    {
        Thread thread;
        public UserControlFrm()
        {
            InitializeComponent();
        }
        private void AbrirJanela(object obj)
        {
            Application.Run(new FrmHome());
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            thread = new Thread(AbrirJanela);
            string user = "gleisio";
            string password = "000";
            if (txtUser.Text.Equals(user) == true & txtPassword.Text.Equals(password) == true)
            {
                FrmHome home = new FrmHome();
                home.Show();
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else
            {
                MessageBox.Show("Usuário o senha incorretos, verifique se os dados estão corretos!", "Erro" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
