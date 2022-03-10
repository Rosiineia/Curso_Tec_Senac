using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

using MySqlConnector;


namespace PI_Parte_4.Rosineia.Models
{
    public class UsuarioRepository
    {
       private const string DadosConexao = "Database=LojaPG;Data Source=localhost;User Id=root;";

        public void TestarConexao(){
            //Aqui iremos conectar com o banco de dados

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();//abert o a conexão com o banco

            Console.WriteLine("Banco de Dados Funcionando");

            Conexao.Close();//Fechada conexão com o banco
        }
        public  Usuario ValidarLogin(Usuario usuario){

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();

            //Criar usuario vazio com null
             Usuario usuarioEncontrado = null;  

            //preparar Query
            String Query = "SELECT * FROM Usuario WHERE Login=@Login and Senha=@Senha";

            //Preparar  comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);

            //Trata do SQL injection
            Comando.Parameters.AddWithValue("@Login",usuario.Login);
            Comando.Parameters.AddWithValue("@Senha",usuario.Senha);

            //recuparar registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();
            //Percurso
            if(Reader.Read()){

                usuarioEncontrado = new Usuario();
                usuarioEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                usuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                usuarioEncontrado.Login = Reader.GetString("Login");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                usuarioEncontrado.Senha = Reader.GetString("Senha");
                }
                
            }        
            //fecha conexão
            Conexao.Close();
            //Se não localizado retorna NULL
            return usuarioEncontrado;
        }


        //4 metodos para CRUD
        // Inserir, alterar, listar, e excluir ususarios no banco de dados

        public void incluir(Usuario novoUser){
            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();
            //preparar Query

            String Query = "INSERT INTO Usuario (Nome,Login,Senha) VALUES( @Nome, @Login, @Senha)";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Nome",novoUser.Nome);
             Comando.Parameters.AddWithValue("@Login",novoUser.Login);
             Comando.Parameters.AddWithValue("@Senha",novoUser.Senha);
             

             //Executr no banco
             Comando.ExecuteNonQuery(); 

            //fecha conexão
            Conexao.Close();
        }
        public void alterar(Usuario user){
            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();
            //preparar Query

            String Query = "UPDATE Usuario SET Nome=@Nome,Login=@Login,Senha=@Senha, WHERE Id=@Id";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Nome",user.Nome);
             Comando.Parameters.AddWithValue("@Login",user.Login);
             Comando.Parameters.AddWithValue("@Senha",user.Senha);
             Comando.Parameters.AddWithValue("@Id",user.Id);

             //Executr no banco
             Comando.ExecuteNonQuery();

            //fecha conexão
            Conexao.Close();
        }
        public void excluir(Usuario user){

            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();

            //Infor. uma Query do obj.conexão
            String Query = "DELETE FROM Usuario WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Aqui executamos o comando
            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.ExecuteNonQuery();

            //fecha conexão
            Conexao.Close();
        }
        public Usuario BuscarPorID(int Id){

            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //Criar usuario vazio
             Usuario usuarioEncontrado = new Usuario();            
            //preparar Query
            String Query = "SELECT * FROM  Usuario WHERE Id=@Id";
            //Preparar  comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            //Trata do SQL injection
            Comando.Parameters.AddWithValue("@Id", Id);
            //recuparar registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();
            //Percurso
            if(Reader.Read()){        
                usuarioEncontrado.Id = Reader.GetInt32("Id");
                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                usuarioEncontrado.Nome = Reader.GetString("Nome");
                }
                if(!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                usuarioEncontrado.Login = Reader.GetString("Login");
                }
                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                usuarioEncontrado.Senha = Reader.GetString("Senha");
                }                               
            }         
            //fecha conexão
            Conexao.Close();
            //retornar usuario encontrado
            return usuarioEncontrado;
        }

        public List<Usuario> Listar(){
            //abrir conexão
              MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();

            List<Usuario> ListaDeUsuarios = new List<Usuario>();
            //Infor. uma Query do obj.conexão
            String Query = "SELECT * FROM Usuario";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Executmos o comando e guardamos as informações executadas no obj. fa classe "MysqlDataReader"
            MySqlDataReader Reader = Comando.ExecuteReader();
            //percorrer resgisto a registro o READER retornando
            while (Reader.Read()){

                Usuario usuarioEncontrado = new Usuario();
                
                usuarioEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                usuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                usuarioEncontrado.Login = Reader.GetString("Login");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                usuarioEncontrado.Senha = Reader.GetString("Senha");
                }
                 ListaDeUsuarios.Add(usuarioEncontrado);  
            }
            //Fechar conexão
            Conexao.Close();
            return ListaDeUsuarios;

        }

    }

}