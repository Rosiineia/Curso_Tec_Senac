namespace PI_Parte_2.Rosineia.Models
{
     public static class Dados
    {

        public static Pedido PedidoAtual { get; set;}

        static Dados()

        {
            PedidoAtual = new Pedido();
        }
    }
}