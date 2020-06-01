using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterFrom.View.FormsHome
{
    public partial class StatusForm : Form
    {
        public DateTime dtInitial { get; set; }
        public DateTime dtEnd { get; set; }
        public TimeSpan dtNow { get; set; }
        public int hrs { get; set; }
        public double valor { get; set; }
        public double tempoRestante { get; set; }
        public double Multa = 0.00;
        public double ValorMulta = 0.00;

        public StatusForm()
        {
            InitializeComponent();
            string sourcePath = @"C:\Users\gabri\OneDrive\Documentos\projint\Aluguel.csv";
            string[] lines = File.ReadAllLines(sourcePath);

            string[] fields = lines[0].Split(',');
            dtInitial = Convert.ToDateTime(fields[0]);
            dtEnd = Convert.ToDateTime(fields[1]);
            hrs = Convert.ToInt32(fields[2]);
            valor = Convert.ToDouble(fields[3]);

            dtNow = dtEnd.Subtract(DateTime.Today);
            tempoRestante = dtNow.TotalHours;
            double minutos = ((tempoRestante) - (int)(tempoRestante)) * 100;

            labeldtInitial.Text = Convert.ToString(dtInitial);
            labeldtEnd.Text = Convert.ToString(dtEnd);
            labelTmpRestante.Text = Convert.ToString((int)(tempoRestante) + " Horas e " + minutos.ToString("F0") + " Minutos");
            labelMulta.Text = Convert.ToString(Multa.ToString("F2",CultureInfo.InvariantCulture));
            labelVrMulta.Text = Convert.ToString(ValorMulta.ToString("F2", CultureInfo.InvariantCulture));
            labelValor.Text = Convert.ToString(valor+Multa + " Reais");
        }

        private void SemAluguel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labeldtInitial_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
