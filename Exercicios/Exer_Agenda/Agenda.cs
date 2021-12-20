using System;
using System.Collections.Generic;

namespace Exer_Agenda
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

        private void AdicionarContatos1(Contato c)
        {
            lista.Add(c);
        }

        private int TotalizarContatos1()
        {// se uso void tem return
            return lista.Count;
        }

        private void ListarContatos1()
        {
            foreach (Contato cc in lista)
            {/* classe, variavel interna , in, lista*/
                Console.WriteLine("=====================");
                Console.WriteLine("Nome: " + cc.nome);
                Console.WriteLine("Email: " + cc.email);
                Console.WriteLine("Whatsapp:" + cc.whatsapp);

            }
        }

        internal void AdicionarContatos(Contato cc)
        {
            throw new NotImplementedException();
        }

        internal string TotalizarContatos()
        {
            throw new NotImplementedException();
        }

        internal void ListarContatos()
        {
            throw new NotImplementedException();
        }
    }  
}

    
