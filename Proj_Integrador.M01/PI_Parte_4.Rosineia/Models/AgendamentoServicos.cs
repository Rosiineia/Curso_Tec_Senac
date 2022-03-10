using System;

namespace PI_Parte_4.Rosineia.Models
{
    public class AgendamentoServicos
    {
        public int Id {get;set;}

        public string Nome {get;set;}

        public DateTime DataSolicitacao {get;set;}

        public string  Servico {get;set;}

        public int Usuario  {get;set;}

    }
}