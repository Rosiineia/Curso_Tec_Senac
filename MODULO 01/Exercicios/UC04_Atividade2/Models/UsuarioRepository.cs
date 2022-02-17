using System;
using System.Collections.Generic;

using MySqlConnector;

namespace Rosineia_UC04_Atividade2.Models
{
    public class UsuarioRepository
    {
        // metodos, operações
        // testar conexão com o banco de dados
        
        private const string DadosConexao = "Database=Turismo;Data Source=localhost;User Id=root;";

        public void TestarConexao(){
            //Aqui iremos conectar com o banco de dados

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();//abert o a conexão com o banco

            Console.WriteLine("Banco de Dados Funcionando");

            Conexao.Close();//Fechada conexão com o banco

        }
        //4 metodos para CRUD
        // Inserir, alterar, listar, e excluir ususarios no banco de dados

        public void incluir(Usuario novoUser){
            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();
            //preparar Query

            String Query = "INSERT INTO Usuario (Nome,Login,Senha,DataNascimento) VALUES( @Nome, @Login, @Senha, @DataNascimento)";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Nome",novoUser.Nome);
             Comando.Parameters.AddWithValue("@Login",novoUser.Login);
             Comando.Parameters.AddWithValue("@Senha",novoUser.Senha);
             Comando.Parameters.AddWithValue("@DataNascimento",novoUser.DataNascimento);

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

            String Query = "UPDATE Usuario SET Nome=@Nome,Login=@Login,Senha=@Senha,DataNascimento=@DataNascimento WHERE Id=@Id";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Nome",user.Nome);
             Comando.Parameters.AddWithValue("@Login",user.Login);
             Comando.Parameters.AddWithValue("@Senha",user.Senha);
             Comando.Parameters.AddWithValue("@DataNascimento",user.DataNascimento);
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
        public Usuario BuscarPorId(int Id){

            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //Criar usuario vazio
             Usuario UsuarioEncontrado = new Usuario();            
            //preparar Query
            String Query = "SELECT * FROM WHERE Id=@Id";
            //Preparar  comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            //Trata do SQL injection
            Comando.Parameters.AddWithValue("@Id", Id);
            //recuparar registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();
            //Percurso
        
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }
                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            
            //fecha conexão
            Conexao.Close();
            //retornar usuario encontrado
            return UsuarioEncontrado;
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

                Usuario UsuarioEncontrado = new Usuario();
                
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                UsuarioEncontrado.Nome = Reader.GetString("Nome");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Login"))){
                UsuarioEncontrado.Login = Reader.GetString("Login");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Senha"))){
                UsuarioEncontrado.Senha = Reader.GetString("Senha");
                }
                
                 /*UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");*/
                 ListaDeUsuarios.Add(UsuarioEncontrado);  
            }
            //Fechar conexão
            Conexao.Close();
            return ListaDeUsuarios;
        }
    }
}