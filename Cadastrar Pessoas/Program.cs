using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_Pessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] primeiroNome = new string[4];
            string[] segundoNome = new string[4];
            string[] anoNascimento = new string[4];

            Console.WriteLine("Digite o Primeiro Nome:");
            primeiroNome[0] = Console.ReadLine();

            Console.WriteLine("Digite o Sobrenome:");
            segundoNome[0] = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Nascimento:");
            anoNascimento[0] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Primeiro Nome:");
            primeiroNome[1] = Console.ReadLine();

            Console.WriteLine("Digite o Sobrenome:");
            segundoNome[1] = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Nascimento:");
            anoNascimento[1] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Primeiro Nome:");
            primeiroNome[2] = Console.ReadLine();

            Console.WriteLine("Digite o Sobrenome:");
            segundoNome[2] = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Nascimento:");
            anoNascimento[2] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite o Primeiro Nome:");
            primeiroNome[3] = Console.ReadLine();

            Console.WriteLine("Digite o Sobrenome:");
            segundoNome[3] = Console.ReadLine();

            Console.WriteLine("Digite o Ano de Nascimento:");
            anoNascimento[3] = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(primeiroNome[0] + " " + segundoNome[0] + " " + anoNascimento[0]);
            Console.WriteLine(primeiroNome[1] + " " + segundoNome[1] + " " + anoNascimento[1]);
            Console.WriteLine(primeiroNome[2] + " " + segundoNome[2] + " " + anoNascimento[2]);
            Console.WriteLine(primeiroNome[3] + " " + segundoNome[3] + " " + anoNascimento[3]);

            Console.ReadKey();
        }
    }
}
