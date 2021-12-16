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
            lista = new List<Contato>(){// nome da classe>();
        }
        /*modificador de acesso, tipo de retorno, nomde do metodos(parametro de entrada){
            corpo do metodos
            }*/

            public void AdicionarContatos(Contato c){
                lista.Add(c);
            }

            public int TotalizarContatos(){// se uso void tem return
             return lista.Count;
            }

            public void ListarContatos(){
                foreach (Contato cc in lista)/* classe, variavel interna , in, lista*/{
                    Console.WriteLine("=====================");
                    Console.WriteLine("Nome: " + cc.nome);
                    Console.WriteLine("Email: " + cc.email);
                    Console.WriteLine("Whatsapp: " cc.whatsapp);
                    
                }
            }
    }
    
    }