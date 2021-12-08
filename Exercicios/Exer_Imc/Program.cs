using System;

namespace Exer_Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            char continua = 'S';

            do
            {

                Imc paciente = new Imc();

                Console.WriteLine("Informe o nome do paciente: ");
                paciente.nomePublico = Console.ReadLine();


                Console.WriteLine("Informe o peso do paciente: ");
                paciente.pesoPublico = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe altura do paciente: ");
                paciente.alturaPublico = double.Parse(Console.ReadLine());


                Console.WriteLine(" Atenção: IMC é: " + paciente.calcularImc());

                Console.WriteLine(" Deseja continumar ? (S) sim (N) não");
                continua = Char.Parse(Console.ReadLine());


            } while (continua == 'S');


        }
    }
}
