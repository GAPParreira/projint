﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInterFrom.Model
{
    class MontarAluguel
    {
        public string id;
        public DateTime tempo_inicio;
        public DateTime tempo_final;
        public string tempo_ini;
        public string tempo_fin;
        //Bicicleta bicicleta = new Bicicleta();
        public string bicicleta = "11";
        public string multa = "0";
        public string status = "11";
        //Pessoa pessoa = new Pessoa();
        // MetododePagamento metodo = new MetododePagamento();
        public string usuario = idToken.idLogin;
        public string metodoDePagamento = "11";

        public MontarAluguel()
        {
        }

        public MontarAluguel(string bicicleta, string multa, string status, string pessoa, string metodo)
        {
            this.bicicleta = bicicleta;
            this.multa = multa;
            this.status = status;
            this.usuario = pessoa;
            this.metodoDePagamento = metodo;
        }

        public MontarAluguel(string tempo_ini, string tempo_fin)
        {
            this.tempo_ini = tempo_ini;
            this.tempo_fin = tempo_fin;
        }

        public MontarAluguel(DateTime tempo_inicio, DateTime tempo_final)
        {
            this.tempo_inicio = tempo_inicio;
            this.tempo_final = tempo_final;
        }



        /*public MontarAluguel(Bicicleta bicicleta, string multa, string status, Pessoa pessoa, MetododePagamento metodo)
        {
            this.bicicleta = bicicleta;
            this.multa = multa;
            this.status = status;
            this.pessoa = pessoa;
            this.metodo = metodo;
        }*/


    }
}