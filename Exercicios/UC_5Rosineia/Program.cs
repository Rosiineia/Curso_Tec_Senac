using System;

namespace UC_5Rosineia
{
    class Program
    {
        static void Main(string[] args)
        {
            char continua = 'S';

            Pedido fazerPedido = new Pedido();

            do
            {

                ItensPedido cliente = new ItensPedido();

                Console.WriteLine("Descreva o pedido pedido: ");
                cliente.descricaoPublico = Console.ReadLine();

                Console.WriteLine("Informe o valor unitario: ");
                cliente.valor_unitarioPublico = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a quantidade: ");
                cliente.quantidadePublico = double.Parse(Console.ReadLine());

                fazerPedido.Incluir(cliente);

                Console.WriteLine("Deseja continuar? (S) / (N)");
                continua = char.Parse(Console.ReadLine());

            } while (continua == 'S');

            fazerPedido.Listar();
            fazerPedido.TotalDeItens();

        }
    }
}
