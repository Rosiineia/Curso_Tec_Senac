using System;
using System.Collections.Generic;

namespace Exer_Imc

{

    public class Atendimento
    {

        // Atributos
        private List<Imc> lista;

        //metodos
        public Atendimento()
        {
            lista = new List<Imc>();

        }

        public void adicionar(Imc item)
        {
            lista.Add(item);
        }
        public void Listar()
        {
            foreach (Imc i in lista)
            {

                Console.WriteLine("O IMC de " + i.nomePublico + " é: " + i.calcularImc());

            }

        }
        public void TotalRegistros()
        {
            Console.WriteLine("O total de pacientes cadastrados são: " + lista.Count);// Lista nomes digitados
        } 
        public double MediaAlturaPacientes(){

            double somaAltura = 0;
            for(int i = 0; i < lista.Count; i++){
                somaAltura = somaAltura + lista[i].alturaPublico;// acumulador
            }
            return somaAltura/ lista.Count;


        }
    }


}




