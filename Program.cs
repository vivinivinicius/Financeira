using System;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Contrato> list = new List<Contrato>();


Console.WriteLine("FINANCEIRA");


Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine();

Console.Write("Entre com o número de contratos: ");
int num = int.Parse(Console.ReadLine());

for (int cont = 1; cont <= num; cont++)
{

    Console.WriteLine();

    Console.WriteLine($"Dados contrato #{cont} -");


    Console.Write("Qual o tipo do contrato - Jurídico ou Físico (J/F)?  ");
    char escolha = char.Parse(Console.ReadLine());

    do
    {
        if (escolha == 'j' || escolha == 'J' || escolha == 'f' || escolha == 'F')
        {
            break;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("Comando inválido. Insira uma opção válida...");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine();
        Console.WriteLine($"Dados contrato #{cont} -");

        Console.Write("Qual o tipo do contrato - Jurídico ou Físico (J/F)?  ");
        escolha = char.Parse(Console.ReadLine());

    } while (escolha != 'j' || escolha != 'J' || escolha != 'f' || escolha != 'F');



    if (escolha == 'j' || escolha == 'J')
    {
        Console.Write("Numero: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Contratante: ");
        string contratante = Console.ReadLine();
        Console.Write("Valor: $");
        double valor = double.Parse(Console.ReadLine());
        Console.Write("Prazo [meses]: ");
        int prazo = int.Parse(Console.ReadLine());
        Console.Write("Cnpj: ");
        string cnpj = Console.ReadLine();
        Console.Write("Inscrição estadual: ");
        string inscricaoEstadual = Console.ReadLine();

        ContratoPessoaJuridica a = new ContratoPessoaJuridica();

        a.CalcularPrestacao();

        list.Add(new ContratoPessoaJuridica(numero, contratante, valor, prazo, cnpj, inscricaoEstadual));
    }

    else if (escolha == 'f' || escolha == 'F')
    {
        Console.Write("Numero: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Contratante: ");
        string contratante = Console.ReadLine();
        Console.Write("Valor: $");
        double valor = double.Parse(Console.ReadLine());
        Console.Write("Prazo [meses]: ");
        int prazo = int.Parse(Console.ReadLine());
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();
        Console.Write("Idade contratante: ");
        int idadeContratante = int.Parse(Console.ReadLine());

        ContratoPessoaFisica i = new ContratoPessoaFisica();

        i.CalcularPrestacao();

        list.Add(new ContratoPessoaFisica(numero, contratante, valor, prazo, cpf, idadeContratante));
    }






}



Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("Informações Inseridas --");
Console.ForegroundColor = ConsoleColor.White;

foreach (Contrato a in list)
{

    Console.WriteLine();
    Console.WriteLine(a.ExibirInfo());
}

Console.ReadKey();
        }
    }
}