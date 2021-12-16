using System;

namespace Exer_Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 'S';
            Agenda agend = new Agenda;


           do{

               agend.AdicionarContatos();
               agend.ListarContatos();
               

               Console.WriteLine("Seseja continuar? (S) (N)");
               continuar= char.Parse(Console.WriteLine());





           }while (continuar == 'S')
           {
                
           }
        }
    }
}
