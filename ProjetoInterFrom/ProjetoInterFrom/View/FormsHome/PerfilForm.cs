using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjetoInterFrom.Model;
using Refit;
using ProjetoInterFrom.Controller;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;
using System.Net.Http.Formatting;
using ProjetoInterFront;

namespace ProjetoInterFrom.View.FormsHome
{
    public partial class PerfilForm : Form
    {
        

        public PerfilForm()
        {
            InitializeComponent();
            PessoaController api = new PessoaController();
            string id = idToken.id;
            var result = api.GetPessoa(id);
            Pessoa pessoa = result[0];

            labelNome.Text = pessoa.nome;
            labelDtNasc.Text = pessoa.dateNasc;
            labelTel.Text = pessoa.telefone;
            labelEnd.Text = pessoa.endereco;
            labelCPF.Text = pessoa.cpf;
        }
    }
}
