using System;

namespace Exer_Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 'S';
            Agenda agend = new Agenda();


           do{

               Console.Clear();
               Console.WriteLine("###Agenda de Contatos####" );
               // criando o objeto cc da classe Contato
               Contato cc = new Contato();

               Console.WriteLine("Digite o nome: ");
               cc.nome = Console.ReadLine();

               Console.WriteLine("Digite o email: ");
               cc.email = Console.ReadLine();

               Console.WriteLine("Digite o whatsapp: ");
               cc.whatsapp = Console.ReadLine();

               /*adicionando o objeto cc da classe "Contato" na classe Agenda pelo metodo AdicionarContatos*/
               agend.AdicionarContatos(cc);
              
               

               Console.WriteLine("Seseja continuar? (S) (N)");
               continuar = char.Parse(Console.ReadLine());

           }while (continuar == 'S');

           agend.ListarContatos();
           Console.WriteLine("Total de contatos na agenda: " + agend.TotalizarContatos());
         
        }
    }
}
