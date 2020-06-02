using ProjetoInterFrom.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class Aluguel
    {            
        private double precoHour = 2.0;
        public DateTime dtInitial { get; set; }
        public DateTime dtEnd { get; set; }
        public double valor { get; set; }
        public double hrs { get; set; }
        Bicicleta bicicleta = new Bicicleta();
        public string multa = "0";
        public string status = "11";
        Pessoa pessoa = new Pessoa();
        MetododePagamento metodo = new MetododePagamento();
        LoginMod loginm = new LoginMod();


        public Aluguel()
        {
        }

        public Aluguel(DateTime dtInitial, DateTime dtEnd)
        {
            this.dtInitial = dtInitial;
            this.dtEnd = dtEnd;
        }

        public void Alugar()
        {
            TimeSpan date = dtEnd.Subtract(dtInitial);
            hrs = date.TotalHours;
            hrs = Math.Ceiling(hrs);
            valor = hrs * precoHour;
            

        }

        public MontarAluguel returnAluguel(string dataini, string datafin)
        {
            MontarAluguel aluguel = new MontarAluguel(datafin, datafin);
            return aluguel;
        }
    }
}
