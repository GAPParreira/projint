using ProjetoInterFrom.Controller;
using ProjetoInterFrom.Model;
using ProjetoInterFront;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterFrom.View
{
    public partial class FormCreateLogin : Form
    {
        public FormCreateLogin()
        {
            InitializeComponent();
            
        }

        private void buttonCadastro_Click(object sender, EventArgs e)
        {
            string cpf = textBoxCpf.Text;            
            Pessoa pessoa = new Pessoa();
            PessoaController apiP = new PessoaController();
            LoginController api = new LoginController();
            var result = apiP.GetPessoaId(cpf);
            pessoa = result[0];
            LoginMod loginM = new LoginMod(textBoxLogin.Text, textBoxPassword.Text);
            loginM = new LoginMod(pessoa);                        
            CreateUserMod loginUser = loginM.returnCreate();
            api.PostLogin(loginUser);

            Login login = new Login();
            this.Hide();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}
