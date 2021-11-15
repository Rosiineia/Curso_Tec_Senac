using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            //definição e variaveis
            //int n1,numero2;
            //int soma;
            //atribuição de valores
            //n1 = 3;
            //numero2 = 5;

            

            //atribuição de valores
            //Console.WriteLine("Informe o valor 1:");

            //n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor 2");
            //numero2 = int.Parse(Console.ReadLine());

            //processamento
            //soma = n1 + numero2;
            
            //escreve na tela
            //Console.WriteLine("numero 1 informado " + n1);
            //Console.WriteLine("numero 2 " +  numero2);
            //Console.WriteLine("O resultado da soma é:" + soma);


  //definição e variaveis
           // int n1,numero2;
            //int soma;
            int ano_nascimento;
            int ano_atual;
            int idade;

            ano_atual= 2021;

            //atribuição de valores
            //n1 = 3;
            //numero2 = 5;
            
            
            
            Console.WriteLine("Você nasceu em que ano? ");
            ano_nascimento = int.Parse(Console.ReadLine());
            

            idade = ano_atual - ano_nascimento;
           
            //ano_atual= (Console.WriteLine());
            Console.WriteLine("Sua idade é:" + idade);





            

        }
    }
}
