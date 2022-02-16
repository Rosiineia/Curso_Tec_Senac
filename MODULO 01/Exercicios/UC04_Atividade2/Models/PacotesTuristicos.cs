using System;



namespace Rosineia_UC04_Atividade2.Models
{
    public class PacotesTuristicos
    {
        public int id {get;set;}
        
        public string Nome {get;set;}

        public string Origem{get;set;}

        public string Destino{get;set;}

        public string Atrativos {get;set;}

        public DateTime Saida {get;set;}

        public DateTime Retorno {get;set;}

        public  int Usuario {get;set;}
    }
}