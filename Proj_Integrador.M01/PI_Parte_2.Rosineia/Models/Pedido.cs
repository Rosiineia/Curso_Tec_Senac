using System;
using System.Collections.Generic;

namespace PI_Parte_2.Rosineia.Models
{
    public class Pedido
    {

        private List<ItensPedido> lista;

        public Pedido()
        {
            lista = new List<ItensPedido>();
        }
        public void AdicionarItensPedido(ItensPedido item)
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