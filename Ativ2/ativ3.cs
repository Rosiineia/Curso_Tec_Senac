
using System;

namespace Ativ3
{
    class Program
    {
        static void Main(string[] args)
        {

        string nome;
        int dia, mes, ano =0;
        int idade;
        int ano_atual =2021;

        Console.WriteLine( "Qual seu nome?");
        nome= Console.ReadLine();
        Console.WriteLine( "Qual  dia você nasceu?");
        dia=int.Parse( Console.ReadLine());
        Console.WriteLine( "Qual mês nasceu?");
        mes= int.Parse( Console.ReadLine());
        Console.WriteLine( "Qual ano você nasceu nome?");
        ano=int.Parse( Console.ReadLine());


        idade=ano_atual-ano;
        if (idade > 18){
               Console.WriteLine("Sua Senha é :" + nome + idade);
            }
            else
            {
                Console.WriteLine("Sua senha é:" + idade + nome);
            }






        }
    }
}
