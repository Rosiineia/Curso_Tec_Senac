using System;
using System.Collections.Generic;

namespace UC_5Rosineia
{
    public class Pedido
    {

        private List<ItensPedido> lista;


        public Pedido()
        {
            lista = new List<ItensPedido>();
        }
        public void Incluir(ItensPedido item)
        {
            lista.Add(item);
        }
        public void Listar()
        {
            foreach (ItensPedido i in lista)
            {
                Console.WriteLine("Valor do " + i.descricaoPublico + " " + i.calcularItensPedido());

            }
        }

        public void TotalDeItens()
        {
            Console.WriteLine("Total de itens cadastrados na base: " + lista.Count);
        }


    }


}