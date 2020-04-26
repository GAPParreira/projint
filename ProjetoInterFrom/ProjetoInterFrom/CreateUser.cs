using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterFront
{
    public partial class CreateUser : Form
    {
        Login login;
        public CreateUser(Login value)
        {
            InitializeComponent();
            login = value;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxEmail.Text = "";
            textBoxLogin.Text = "";
            textBoxPass.Text = "";
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            string name = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPass.Text;
            MessageBox.Show(name + "\n" + email + "\n" + login + "\n" + password);
            this.Dispose();
        }
    }
}
