namespace UC_5Rosineia.Jesus_Ativ2.Models
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