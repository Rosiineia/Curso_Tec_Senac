using System.Collections.Generic;

namespace Exerc_AgendaMVC.Models
{
    public class Agenda
    {
         //Atributos

        private List<Contato> lista; // nome da classe> lista;

        //metodos

        public Agenda(){
            //metodo constutor
           lista = new List<Contato>();// nome da classe>();
       }

        public void AdicionarContato(Contato c)
        {
            lista.Add(c);
        }

        public int TotalizarContato()
        {// se uso void tem return
            return lista.Count;
        }

        public List<Contato> ListarContato()
        {
            return lista;
           /* foreach (Contato cc in lista)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("Nome: " + cc.nome);
                Console.WriteLine("Email: " + cc.email);
                Console.WriteLine("Whatsapp:" + cc.whatsapp);
            }*/
        }
    }
}