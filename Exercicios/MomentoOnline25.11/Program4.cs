using System;
using System.Collections.Generic;// A lista só funciona se usar esse pacote

namespace MomentoOnline25._11
{
    class Program4
    {
        private static double calculo;

        static void Main(string[] args)
        {

            //Definindo as minhas Listas
            List<String> lista_nome = new List<string>();
            List<double> lista_imc = new List<double>();
            

            char continua = 'S';
            double altura,peso;

            do
            {
                // Faz alguma coisa aqui
                // aRMAZENANDO NA LISTA DE NOMES

                Console.WriteLine(" Informe o nome do Paciente: ");
                lista_nome.Add(Console.ReadLine());

                // obtendo altura do paciente
                Console.WriteLine( "Informe altura do paciente: ");
                altura = double.Parse(Console.ReadLine());

                // Obtendo peso do paciente
                Console.WriteLine("Informe o peso do paciente: ");
                peso = double.Parse(Console.ReadLine());
                //calculo do imc
                calculo = peso / (altura*altura);
                // Armazenando o calculo na lista de imc
                lista_imc.Add(calculo);


                Console.WriteLine(" Deseja continumar ? (S) sim (N) não");
                continua = Char.Parse(Console.ReadLine());


            } while (continua == 'S');
            // EXIBINDO OS DADOS DA LISTA DE NOMES
            foreach(String nomes in lista_nome){
                 Console.WriteLine(nomes);

                 // EXIBINDO OS DADOS DA LISTA IMC
            foreach(double retorno in lista_imc){
                 Console.WriteLine(retorno);

            } 
            // VINCULAR LISTA DE NOME COM IMC

            for(int i = 0; i < lista_nome.Count; i++){
                Console.WriteLine(" Paciente " + lista_nome[i] + " seu IMC é: " + lista_imc[i]);
            }
           

        }
    
    }
}

}

