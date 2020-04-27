using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoInterFront.View;

namespace ProjetoInterFront
{
    public partial class CreateUser : Form
    {
        int X = 0;
        int Y = 0;
        public CreateUser(Login value)
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form3_MouseDown);
            this.MouseMove += new MouseEventHandler(Form3_MouseMove);
        }
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
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
