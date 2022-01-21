using System.Collections.Generic;


namespace UC_5Rosineia_Ativ2
{
    public class ItensPedido
    {

        
        public string descricao { get; set; }
        public double valor_unitario { get; set; }

        public int quantidade { get; set; }

        public ItensPedido()
        {

        }
       
       /* public double calcularItensPedido(){
        
            double calculo;
            calculo = valor_unitario * quantidade;
            return calculo;


        }*/


    }
}