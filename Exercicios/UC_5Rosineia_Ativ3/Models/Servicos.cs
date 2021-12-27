using System;
using System.Collections.Generic;

namespace UC_5Rosineia_Ativ3.Models
{
    public class Servicos
    {
         private List<Agendamento> lista;

        public Servicos()
        {
            lista = new List<Agendamento>();
        }

            public void AdicionarAgendamento(Agendamento item)
        {
            lista.Add(item);
        }
        public int TotalizarAgendamento()
        {
            return lista.Count;
        }
        public List<Agendamento> ListarAgendamento()
        {
            return lista;
        }

    }
}