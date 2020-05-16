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

namespace ProjetoInterFrom.View.FormsHome
{
    public partial class PerfilForm : Form
    {
        string nome;
        DateTime dataNascimento;
        long telefone;
        string endereco;
        string cPF;

        public PerfilForm()
        {
            InitializeComponent();
            string sourceFilePath = @"C:\Users\gabri\OneDrive\Documentos\projint\Pessoa.csv";
            string[] lines = File.ReadAllLines(sourceFilePath);

            string[] fields = lines[0].Split(',');
            nome = fields[0];
            dataNascimento = DateTime.Parse(fields[1]);
            telefone = long.Parse(fields[2]);
            endereco = fields[3];
            cPF = fields[4];

            // Pessoa usuario = new Pessoa(nome, dataNascimento, telefone, endereco, cPF);

            labelNome.Text = nome;
            labelDtNasc.Text = Convert.ToString(dataNascimento);
            labelTel.Text = Convert.ToString(telefone);
            labelEnd.Text = endereco;
            labelCPF.Text = Convert.ToString(cPF);
        }
    }
}
