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
                Start = Convert.ToDateTime(dateTimePickerInicial.Text);
                End = Convert.ToDateTime(dateTimePickerFinal.Text);
                if(Start < End) 
                {
                    TimeSpan date = End.Subtract(Start);
                    double totalHours = date.TotalHours;
                    double PagarT = totalHours * precoHour;
                    MessageBox.Show("Preco do aluguel ficou em: " + totalHours.ToString("F2") + " Horas por " + PagarT.ToString("F2") + " Reais");
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
            Start = Convert.ToDateTime(dateTimePickerInicial.Text);
            End = Convert.ToDateTime(dateTimePickerFinal.Text);
            if(Start < End)
            {                
                TimeSpan date = End.Subtract(Start);
                double totalHours = date.TotalHours;
                totalHours = Math.Ceiling(totalHours);
                double PagarT = totalHours * precoHour;
                labelDias.Text = Convert.ToString(totalHours.ToString("F0") + " Horas");
                labelPagar.Text = Convert.ToString(PagarT.ToString("F2") + " Reais");
                consultaValidacao = true;
            }
            else
            {
                MessageBox.Show("A data final tem que ser maior que a data inicial.");
            }
        }
    }
}
