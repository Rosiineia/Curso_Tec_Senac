using System;
using System.Collections.Generic;

using MySqlConnector;

namespace UC04_Atividade2.Models
{
    public class PacotesTuristicosRepository
    {

        // metodos, operações
        // testar conexão com o banco de dados
        
        private const string DadosConexao = "Database=Turismo;Data Source=localhost;User Id=root;";
        //CRUD + BUSCAR PO iD
        public List<PacotesTuristicos> Listar()
        {
            //abrir conexão
              MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();

            List<PacotesTuristicos> ListaDePacotesTuristicos = new List<PacotesTuristicos>();
            //Infor. uma Query do obj.conexão
            String Query = "SELECT * FROM PacotesTuristicos";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Executmos o comando e guardamos as informações executadas no obj. fa classe "MysqlDataReader"
            MySqlDataReader Reader = Comando.ExecuteReader();
            //percorrer resgisto a registro o READER retornando
            while (Reader.Read()){

                PacotesTuristicos PacoteEncontrado = new PacotesTuristicos();
                
                PacoteEncontrado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                PacoteEncontrado.Nome = Reader.GetString("Nome");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Origem"))){
                PacoteEncontrado.Origem = Reader.GetString("Origem");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Destino"))){
                PacoteEncontrado.Destino = Reader.GetString("Destino");
                }
                if(!Reader.IsDBNull(Reader.GetOrdinal("Atrativos"))){
                PacoteEncontrado.Atrativos = Reader.GetString("Atrativos");
                }
                
                 PacoteEncontrado.Saida = Reader.GetDateTime("Saida");
                 ListaDePacotesTuristicos.Add(PacoteEncontrado);

                PacoteEncontrado.Retorno = Reader.GetDateTime("Retorno");

                 ListaPacotes.Add(PacoteEncontrado);    
            }
             //fecha conexão
            Conexao.Close();
            //retornar usuario encontrado
            return ListaPacotes;
        }

         public void  incluir(PacotesTuristicos novoPacote){
            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();
            //preparar Query

            String Query = "INSERT INTO PacotesTuristicos (Nome,Origem,Destino,Atrativos,Saida, Retorno, Usuario) VALUES( @Nome, @Origem, @Destino, @Atrativos,@Saida,@Retorno,@Usuario)";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Nome",novoPacote.Nome);
             Comando.Parameters.AddWithValue("@Origem",novoPacote.Login);
             Comando.Parameters.AddWithValue("@Destino",novoPacote.Destino);
             Comando.Parameters.AddWithValue("@Atrativos",novoPacote.Atrativos);
             Comando.Parameters.AddWithValue("@Saida",novoPacote.Saida);
             Comando.Parameters.AddWithValue("@Retorno",novoPacote.Retorno);
             Comando.Parameters.AddWithValue("@Usuario",novoPacote.Usuario);

             //Executr no banco
             Comando.ExecuteNonQuery(); 

            //fecha conexão
            Conexao.Close();
        }
        public void alterar(PacotesTuristicos user){
            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();
            //preparar Query

            String Query = "UPDATE PacotesTuristicos SET Nome=@Nome,Origem=@Origem,Destino=@Destino,Atrativos=@Atrativos, Saida=@Saida, Retorno=@Retorno WHERE Id=@Id";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Nome",user.Nome);
             Comando.Parameters.AddWithValue("@Origem",user.Origem);
             Comando.Parameters.AddWithValue("@Destino",user.Destino);
             Comando.Parameters.AddWithValue("@Atrativos",user.Atrativos);
             Comando.Parameters.AddWithValue("@Saida",user.Saida);
             Comando.Parameters.AddWithValue("@Retorno",user.Retorno);
             Comando.Parameters.AddWithValue("@Id",user.Id);

             //Executr no banco
             Comando.ExecuteNonQuery();

            //fecha conexão
            Conexao.Close();
        }
        public void  excluir(PacotesTuristicos user){

            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();

            //Infor. uma Query do obj.conexão
            String Query = "DELETE FROM PacotesTuristicos WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Aqui executamos o comando
            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.ExecuteNonQuery();

            //fecha conexão
            Conexao.Close();
        }
        public PacotesTuristicos BuscarPorID(int Id){

            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //Criar usuario vazio
             Usuario pacoteEncontrado = new PacotesTuristicos();            
            //preparar Query
            String Query = "SELECT * FROM  PacotesTuristicos WHERE Id=@Id";
            //Preparar  comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            //Trata do SQL injection
            Comando.Parameters.AddWithValue("@Id", Id);
            //recuparar registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();
            //Percurso
            if(Reader.Read()){

                pacoteEncontrado.Id = Reader.GetInt32("Id");
               if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                pacoteEncontrado.Nome = Reader.GetString("Nome");
                }
                if(!Reader.IsDBNull(Reader.GetOrdinal("Origem"))){
                pacoteEncontrado.Origem = Reader.GetString("Origem");
                }
                if(!Reader.IsDBNull(Reader.GetOrdinal("Destino"))){
                pacoteEncontrado.Destino = Reader.GetString("Destino");
                }
                if(!Reader.IsDBNull(Reader.GetOrdinal("Atrativos"))){
                pacoteEncontrado.Atrativos = Reader.GetString("Atrativos");
                }
            }
                pacoteEncontrado.Saida = Reader.GetDateTime("Saida");
                 ListaDePacotesTuristicos.Add(pacoteEncontrado);

                pacoteEncontrado.Retorno = Reader.GetDateTime("Retorno");
                 ListaDePacotesTuristicos.Add(pacoteEncontrado);
                     
            //fecha conexão
            Conexao.Close();
            //retornar usuario encontrado
            return pacoteEncontrado;
        }
    }
}
