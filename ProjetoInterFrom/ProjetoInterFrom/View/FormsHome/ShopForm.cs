using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInterFrom.View.FormsHome
{
    public partial class ShopForm : Form
    {
        bool consultaValidacao = false;
        double precoHour = 2.00;
        DateTime Start = new DateTime();
        DateTime End = new DateTime();
        public ShopForm()
        {
            InitializeComponent();
            
            
            
        }

        private void iconButtonAlugar_Click(object sender, EventArgs e)
        {
            if(checkBoxConfirmed.Checked == true && consultaValidacao == true)
            {
                Start = Convert.ToDateTime(textBoxDateInitial.Text);
                End = Convert.ToDateTime(textBoxDateEnd.Text);
                if(Start < End) 
                {
                    TimeSpan date = End.Subtract(Start);
                    double totalHours = date.TotalHours;
                    double PagarT = totalHours * precoHour;
                    MessageBox.Show("Preco do aluguel ficou em: " + totalHours + " Horas por " + PagarT + " Reais");
                    consultaValidacao = false;
                }
                else
                {
                    MessageBox.Show("A data final tem que ser maior que a data inicial.");
                }
            }
            else if(consultaValidacao == true)
            {
                MessageBox.Show("Voce Precisa Confirmar o Aluguel");
            }
            else
            {
                MessageBox.Show("Voce Precisa Consultar o Preco Primeiro");
            }
        }

        private void iconButtonConsultar_Click(object sender, EventArgs e)
        {
            Start = Convert.ToDateTime(textBoxDateInitial.Text);
            End = Convert.ToDateTime(textBoxDateEnd.Text);
            if(Start < End)
            {
                TimeSpan date = End.Subtract(Start);
                double totalHours = date.TotalHours;
                double PagarT = totalHours * precoHour;
                labelDias.Text = Convert.ToString(totalHours + " Horas");
                labelPagar.Text = Convert.ToString(PagarT + " Reais");
                consultaValidacao = true;
            }
            else
            {
                MessageBox.Show("A data final tem que ser maior que a data inicial.");
            }
        }
    }
}
