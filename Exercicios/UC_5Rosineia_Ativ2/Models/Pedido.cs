using System;
using System.Collections.Generic;

namespace UC_5Rosineia_Ativ2
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
        public int TotalizarItensPedido()
        {
            return lista.Count;

        }
        public List<ItensPedido> ListarItensPedido()
        {
            return lista;
        }
    }
}