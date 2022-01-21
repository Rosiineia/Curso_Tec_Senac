namespace UC_5Rosineia_Ativ3.Models
{
    public class Dados
    {
        public static Servicos AgendamentoAtual { get; set;}

        static Dados()

        {
            AgendamentoAtual = new Servicos();
        }
    }
}