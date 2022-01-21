using System;

namespace Exer_Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            char continua = 'S';
            Atendimento atender = new Atendimento();// Lista de antendimento

            do
            {

                Imc paciente = new Imc();

                Console.WriteLine("Informe o nome do paciente: ");
                paciente.nomePublico = Console.ReadLine();


                Console.WriteLine("Informe o peso do paciente: ");
                paciente.pesoPublico = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe altura do paciente: ");
                paciente.alturaPublico = double.Parse(Console.ReadLine());

                atender.adicionar(paciente);// Adicioando dados do paceinte na lista


                //Console.WriteLine(" Atenção: IMC é: " + paciente.calcularImc());

                Console.WriteLine(" Deseja continumar ? (S) sim (N) não");
                continua = Char.Parse(Console.ReadLine());


            } while (continua == 'S');

            atender.Listar();// exibindo o calculo do imc da lista
            atender.TotalRegistros(); 

            Console.WriteLine( "A Média de altura dos pacientes é: " + atender.MediaAlturaPacientes());


        }
    }
}
