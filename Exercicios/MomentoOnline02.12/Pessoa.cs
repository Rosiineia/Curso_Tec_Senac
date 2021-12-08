using System;

namespace MomentoOnline02._12
{
    public class Pessoa
    {

        // bloco dos ATRIBUTOS ou propriedades ou 
        public string nome;

        public double altura, peso;

        public DateTime data_nasc;

        // metodo construtor

        public Pessoa(){


        }

        public Pessoa(String n,  double a, double p){
            nome = n;
            altura = a;
            peso = p;

        }


        // bloco dos METODOS ou funcionalidades


        public void acordar()
        {

            Console.WriteLine("Acordando! " + nome + " Bom dia!!");
        }

        public void caminhar()
        {

            Console.WriteLine(nome + "Iniciando Caminhada");

        }

        public void dormir()
        {

            Console.WriteLine(nome + " Dormindo! Boa noite!!");

        }

        public void exibirinformacoes()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Data de nascimento: " + data_nasc);
            Console.WriteLine("---------------------------------");

        }
        public void gerarSenha()
        {

            int idade;
            string senha;
            idade = DateTime.Now.Year - data_nasc.Year;

            if(idade>18){
                senha = nome+idade;

            }else{
                senha = idade + nome;
                
            }
            Console.WriteLine("Senha:" + senha);
            Console.ReadLine();
        }
    }



}