using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoInterFrom.View;

namespace ProjetoInterFront
{
    public partial class Login : Form
    {
        int X = 0;
        int Y = 0;

        string user = "admin";
        string password = "admin";

        public Login()
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
            this.Close();
        }



        private void statusUser_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            statusUser.Text = "";
            statusPass.Text = "";
            if (textBoxUser.Text == user && textBoxPassword.Text == password)
            {
                Home home = new Home(this);
                this.Hide();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            if (textBoxUser.Text != user)
            {
                statusUser.Text = "Usuario não existe!";
            }
            else
            {
                statusUser.Text = "";
                if (textBoxUser.Text == user)
                {
                    if (textBoxPassword.Text != password)
                    {
                        statusPass.Text = "Senha esta incorreta!";
                    }
                }
            }
        }



        private void Registrar_Click(object sender, EventArgs e)
        {
            CreateUser create = new CreateUser(this);
            create.ShowDialog();
        }

        private void buttonEmail_Click(object sender, EventArgs e)
        {
            String email = "acsupp@gmail.com";
            MessageBox.Show(email);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
