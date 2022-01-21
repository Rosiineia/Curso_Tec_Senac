using System;

namespace Exer_Imc
{

    public class Imc
    {
        // Atributos da classe
        private String nome;
        private double altura, peso;

        // metodos

        public Imc()
        {
            // metodo construtor
        }

        public String nomePublico
        {
             set { nome = value; }
            get { return nome; }
        }
           public double alturaPublico
        {
             set { altura = value; }
            get { return altura; }
        }
         public double pesoPublico
        {
             set { peso = value; }
            get { return peso; }
        }
        public double calcularImc(){
            double calculo;

            calculo = peso /(altura*altura);
            return calculo;

        }


    }
}