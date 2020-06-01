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

namespace ProjetoInterFrom.View.FormsHome
{
    public partial class PerfilForm : Form
    {
        

        public PerfilForm()
        {
            InitializeComponent();
            PessoaController api = new PessoaController();
            var result = api.GetPessoa("11");
            Pessoa pessoa = result[0];

            labelNome.Text = pessoa.Nome;
            labelDtNasc.Text = pessoa.DataNascimento;
            labelTel.Text = pessoa.Telefone;
            labelEnd.Text = pessoa.Endereco;
            labelCPF.Text = pessoa.CPF;
        }
    }
}
