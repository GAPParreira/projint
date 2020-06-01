using ProjetoInterFrom.Model;
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
        DateTime Start = new DateTime();
        DateTime End = new DateTime();
        Aluguel aluguel;
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
                    MessageBox.Show("Preco do aluguel ficou em: " + aluguel.hrs.ToString("F2") + " Horas por " + aluguel.valor.ToString("F2") + " Reais");
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
                aluguel = new Aluguel(Start, End);
                aluguel.Alugar();
                labelDias.Text = Convert.ToString(aluguel.hrs.ToString("F0") + " Horas");
                labelPagar.Text = Convert.ToString(aluguel.valor.ToString("F2") + " Reais");
                consultaValidacao = true;
            }
            else
            {
                MessageBox.Show("A data final tem que ser maior que a data inicial.");
            }
        }
    }
}
