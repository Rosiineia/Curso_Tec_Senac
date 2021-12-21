using System;
using System.Collections.Generic;

namespace UC_5Rosineia_Ativ2
{
    public class ItensPedido
    {

        public string descricao;
        public double valor_unitario, quantidade;


        public ItensPedido()
        {


        }
        public String descricaoPublico { get; set; }
        public double valor_unitarioPublico { get; set; }

        public double quantidadePublico { get; set; }

        
       
       /* public double calcularItensPedido()
        
            double calculo;
            calculo = valor_unitario * quantidade;
            return calculo;


        }*/


    }
}