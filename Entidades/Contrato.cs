﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Contrato
    {
        public int Numero { get; protected set; }

        public string Contratante { get; set; }

        public double Valor { get; set; }

        public int Prazo { get; set; }

        public Contrato()
        {

        }

        public Contrato(int numero, string contratante, double valor, int prazo)
        {
            Numero = numero;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;
        }

        public virtual double CalcularPrestacao()
        {
            return 0;

        }
        public virtual string ExibirInfo()
        {
            return " ";
        }

    }

}