namespace PI_Parte_3.Rosineia.Models
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