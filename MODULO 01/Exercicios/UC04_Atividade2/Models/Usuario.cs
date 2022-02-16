using System;




namespace Rosineia_UC04_Atividade2.Models
{
    public class Usuario
    {
        public int Id {get;set;}

        public string Nome {get;set;}

        public string Login{get;set;}

        public string Senha {get;set;}

        public  DateTime DataNascimento  {get;set;}
    }
}