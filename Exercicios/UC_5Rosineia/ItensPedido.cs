using System;

namespace UC_5Rosineia
{
    public class ItensPedido
    {

        private string descricao;
        private double valor_unitario, quantidade;


        public ItensPedido()
        {


        }
        public String descricaoPublico
        {

            set { descricao = value; }
            get { return descricao; }

        }
        public double valor_unitarioPublico
        {

            set { valor_unitario = value; }
            get { return valor_unitario; }

        }

        public double quantidadePublico
        {

            set { quantidade = value; }
            get { return quantidade; }
        }

        public double calcularItensPedido()
        {
            double calculo;
            calculo = valor_unitario * quantidade;
            return calculo;


        }

    }
}



