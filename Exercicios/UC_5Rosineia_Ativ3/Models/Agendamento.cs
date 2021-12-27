using System;
using System.Collections.Generic;

namespace UC_5Rosineia_Ativ3.Models
{
    public class Agendamento
    {
        public string nome { get; set; }
        public string animal { get; set; }

        public string necessidade { get; set; }

        public double telefone { get; set; }


        public DateTime data { get; set; }

        public Agendamento()
        {

        }

    }
}