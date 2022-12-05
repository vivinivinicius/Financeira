using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ConsoleApp1;
using System.Drawing;

namespace ConsoleApp1
{
    class ContratoPessoaJuridica : Contrato
    {
        public string CNPJ { get; protected set; }
        public string InscricaoEstadual { get; protected set; }

        public ContratoPessoaJuridica()
        {
        }

        public ContratoPessoaJuridica(int numero, string contratante, double valor, int prazo, string cnpj, string inscricaoEstadual)
             : base(numero, contratante, valor, prazo)
        {
            CNPJ = cnpj;
            InscricaoEstadual = inscricaoEstadual;
        }

        public override double CalcularPrestacao()
        {

            return (Valor / Prazo) + 3;

        }

        public override string ExibirInfo()
        {
            return " - Número: "
                + Numero
            + "\n - Valor: $"
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + "\n - Prazo: "
                + Prazo
                + " meses"
                + "\n - Valor Prestação: $"
                + CalcularPrestacao().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}