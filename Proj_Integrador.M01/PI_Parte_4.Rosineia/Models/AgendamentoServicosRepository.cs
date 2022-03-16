using System;
using System.Collections.Generic;

using MySqlConnector;

namespace PI_Parte_4.Rosineia.Models
{
    public class AgendamentoServicosRepository
    {
         private const string DadosConexao = "Database=LojaPG;Data Source=localhost;User Id=root;";
        private const string Name = "Servico";

        public List<AgendamentoServicos> Listar()
        {
            //abrir conexão
              MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();

            List<AgendamentoServicos> ListaAgendamentoServicos = new List<AgendamentoServicos>();
            //Infor. uma Query do obj.conexão
            String Query = "SELECT * FROM AgendamentoServicos";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Executmos o comando e guardamos as informações executadas no obj. fa classe "MysqlDataReader"
            MySqlDataReader Reader = Comando.ExecuteReader();
            //percorrer resgisto a registro o READER retornando
            while (Reader.Read()){

                AgendamentoServicos AgendamentoRealizado = new AgendamentoServicos();
                
                AgendamentoRealizado.Id = Reader.GetInt32("Id");

                if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                AgendamentoRealizado.Nome = Reader.GetString("Nome");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("DataSolicitacao"))){
                AgendamentoRealizado.DataSolicitacao  = Reader.GetDateTime("DataSolicitacao");
                }

                if(!Reader.IsDBNull(Reader.GetOrdinal("Servico"))){
                AgendamentoRealizado.Servico  = Reader.GetString(Name);
                }
                 ListaAgendamentoServicos.Add(AgendamentoRealizado);    
            }
             //fecha conexão
            Conexao.Close();
            //retornar usuario encontrado
            return ListaAgendamentoServicos;
        }
        public void  incluir(AgendamentoServicos novaAgenda){
            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();
            //preparar Query

            String Query = "INSERT INTO AgendamentoServicos (Id, Nome,DataSolicitacao,Servico) VALUES(@Id, @Nome, @DataSolicitacao, @Servico)";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Id",novaAgenda.Id);
             Comando.Parameters.AddWithValue("@Nome",novaAgenda.Nome);
             Comando.Parameters.AddWithValue("@DataSolicitacao",novaAgenda.DataSolicitacao);
             Comando.Parameters.AddWithValue("@Servico",novaAgenda.Servico);
             //Comando.Parameters.AddWithValue("@Usuario",novaAgenda.Usuario);
             //Executr no banco
             Comando.ExecuteNonQuery(); 
            //fecha conexão
            Conexao.Close();
        }
        public void alterar(AgendamentoServicos user){
            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();
            //preparar Query

            String Query = "UPDATE AgendamentoServicos SET Nome=@Nome,DataSolicitacao=@DataSolicitacao, Servico=@Servico WHERE Id=@Id";
            //Preparr o comando

             MySqlCommand Comando = new MySqlCommand(Query, Conexao);

             //Tratar SQL injection
             Comando.Parameters.AddWithValue("@Nome",user.Nome);
             Comando.Parameters.AddWithValue("@DataSolicitacao",user.DataSolicitacao);
             Comando.Parameters.AddWithValue("@Servico",user.Servico);
             Comando.Parameters.AddWithValue("@Id",user.Id);
             

             //Executr no banco
             Comando.ExecuteNonQuery();

            //fecha conexão
            Conexao.Close();
        }
        public void  excluir(AgendamentoServicos user){

            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);    
            Conexao.Open();

            //Infor. uma Query do obj.conexão
            String Query = "DELETE FROM AgendamentoServicos WHERE Id=@Id";
            MySqlCommand Comando = new MySqlCommand(Query, Conexao);

            //Aqui executamos o comando
            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.ExecuteNonQuery();
            //fecha conexão
            Conexao.Close();
        }
    public AgendamentoServicos BuscarPorID(int Id){

            //Abrir conexão
             MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();
            //Criar usuario vazio
             AgendamentoServicos AgendamentoRealizado = new AgendamentoServicos();            
            //preparar Query
            String Query = "SELECT * FROM  AgendamentoServicos WHERE Id=@Id";
            //Preparar  comando e executa
            MySqlCommand Comando = new MySqlCommand(Query,Conexao);
            //Trata do SQL injection
            Comando.Parameters.AddWithValue("@Id", Id);
            //recuparar registros do comando
            MySqlDataReader Reader = Comando.ExecuteReader();
            //Percurso
            if(Reader.Read()){

                AgendamentoRealizado.Id = Reader.GetInt32("Id");

               if(!Reader.IsDBNull(Reader.GetOrdinal("Nome"))){
                    //Tratativa p/ não permitir inserir na lista dados NULL
                AgendamentoRealizado.Nome = Reader.GetString("Nome");
                }
                /*if(!Reader.IsDBNull(Reader.GetOrdinal("Servico"))){
                AgendamentoRealizado.Servico  = Reader.GetString("Servico");
                }
                AgendamentoRealizado.DataSolicitacao  = Reader.GetDateTime("DataSolicitacao ");*/
                

                }
            //fecha conexão
            Conexao.Close();
            //retornar usuario encontrado
            return AgendamentoRealizado;
        }
    }
}
