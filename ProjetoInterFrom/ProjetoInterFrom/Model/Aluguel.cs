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
            string sourcePath = @"C:\Users\gabri\OneDrive\Documentos\projint\Aluguel.csv";           
            using (StreamWriter sw = File.AppendText(sourcePath))
            {                
                    sw.WriteLine(Convert.ToString(dtInitial) + "," +  Convert.ToString(dtEnd) + "," + hrs + "," + valor.ToString("f2"));                
            }
        }
    }
}
