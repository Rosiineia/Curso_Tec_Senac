using System;
using System.Collections.Generic;

namespace PI_Parte_3.Rosineia.Models
{
    public class Agendamento
    {
        public string nome { get; set; }
        public string Descrição { get; set; }

        public string Serviço { get; set; }

        public ulong telefone { get; set; }


        public DateTime data { get; set; }

        public Agendamento()
        {

        }

    }
}