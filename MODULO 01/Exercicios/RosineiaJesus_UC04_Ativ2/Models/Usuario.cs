using System;

namespace RosineiaJesus_UC04_Ativ2.Models
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