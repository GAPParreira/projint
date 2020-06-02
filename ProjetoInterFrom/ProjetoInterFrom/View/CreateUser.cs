using ProjetoInterFrom.Controller;
using ProjetoInterFrom.Model;
using ProjetoInterFrom.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBoxEndereco.Text = "";
            textBoxTel.Text = "";
            textBoxCPF.Text = "";
            dateTimePickerDtNasc.Text = "01/01/01";
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || textBoxEndereco.Text == "" || textBoxTel.Text == "" || textBoxCPF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                string nome = textBoxNome.Text;
                string endereco = textBoxEndereco.Text;
                string tel = textBoxTel.Text;
                string cpf = textBoxCPF.Text;
                string data = dateTimePickerDtNasc.Text;
                Pessoa pessoa = new Pessoa(cpf, data, endereco, nome, tel);
                PessoaController api = new PessoaController();
                api.PostPessoa(pessoa);
                FormCreateLogin createLogin = new FormCreateLogin();

            }            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
