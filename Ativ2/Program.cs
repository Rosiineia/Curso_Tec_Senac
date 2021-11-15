using System;

namespace Ativ2
{
    class Program
    {
        static void Main(string[] args)
        {

        int idade;
        int nome;


        Console.WriteLine("Informe sua  idade:");
        idade = int.Parse(Console.ReadLine());
        Console.WriteLine(" Informar Nome:");
        nome = int.Parse(Console.ReadLine());

        if(idade <=18){
            Console.WriteLine( "Sua Senha é :" +  nome + idade );     
         }else {
                Console.WriteLine("Sua senha é:"  +  idade + nome);
            }
        }
    }
}
