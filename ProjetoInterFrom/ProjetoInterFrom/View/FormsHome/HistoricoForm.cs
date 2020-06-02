using ProjetoInterFrom.Controller;
using ProjetoInterFrom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterFrom.View.FormsHome
{
    public partial class HistoricoForm : Form
    {
        public DateTime dtInitial { get; set; }
        public DateTime dtEnd { get; set; }
        public int hrs { get; set; }
        public double valor { get; set; }

        public HistoricoForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AluguelController api = new AluguelController();
            List<Aluguel> aluguel = new List<Aluguel>();
            aluguel = api.GetAlugueis(idToken.nome);

            dataGridView1.DataSource = aluguel;
           

            
        }
    }
}
