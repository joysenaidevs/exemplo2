using System;
using exemplo2.classe;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Joyce", "Santos");

            Console.WriteLine($"Bem Vindo {p.Nome} {p.SobreNome}");

            Pessoa joyce = new Pessoa("joyce");

            //ou
            /*Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu Sobrenome");
            string sobreNome = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, sobreNome);*/
            


            
        }
    }
}
