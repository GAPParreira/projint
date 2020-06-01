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
            string sourcePath = @"C:\Users\gabri\OneDrive\Documentos\projint\Aluguel.csv";         
            string[] lines = File.ReadAllLines(sourcePath);

            string[] fields = lines[0].Split(',');
            dtInitial = Convert.ToDateTime(fields[0]);
            hrs = Convert.ToInt32(fields[2]);
            valor = Convert.ToDouble(fields[3]);

            
        }
    }
}
