using System;

namespace MomentoOnline02._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pele = new Pessoa();// tipo de dado; variavel(objeto criado); new; construtor utilizado para instanciar o objeto
            Pessoa neymar = new Pessoa("Neymar Jr", 1.70, 60);
            Pessoa xuxa = new Pessoa("Maria da graça", 1.80, 62);

              neymar.exibirinformacoes();
              xuxa.exibirinformacoes();

            // acessando atributos classe pessoas
            pele.nome = "Edson";
            pele.peso = 80.10;
            pele.altura = 1.86;
            pele.data_nasc = DateTime.Parse ("1985 - 12 - 02");

            // Atribuir inf. aos atributos do objeto
            pele.nome = "Edson";
            xuxa.nome = "Maria da Graça";
            neymar.nome = "Neymar Jr.";



            // acessando os metodos da classe pessoa
            neymar.acordar();
            xuxa.acordar();
            pele.exibirinformacoes();
            pele.gerarSenha();

      


        }
    }
}
