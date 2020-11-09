using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.DTO;

namespace Projeto.DAL
{
    public class ContatosDAL
    {
        public IList<contatos_DTO> cargaContatos()
        {
            try
            {
                //Criando a string de conexão
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;

                //Criaçao do comando Select sql
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM contatos WHERE situacao = '1'";
                CM.Connection = CON;

                //Criação da leitura dos dados da tabela
                SqlDataReader ER;

                //Lista que irá armazenar os dados que serão lidos
                IList<contatos_DTO> listContatoDTO = new List<contatos_DTO>();

                //Abrindo conexão
                CON.Open();


                //Realizando a leitura e adicionando na lista
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        contatos_DTO cont = new contatos_DTO();

                       // cont.id = Convert.ToInt32(ER["id"]);
                        cont.nome = Convert.ToString(ER["nome"]);
                        cont.telefone = Convert.ToString(ER["telefone"]);
                        cont.email = Convert.ToString(ER["email"]);
                        cont.mensagem = Convert.ToString(ER["mensagem"]);
                        cont.situacao = Convert.ToString(ER["situacao"]);
                        listContatoDTO.Add(cont);
                    }

                }

                return listContatoDTO;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public int atualizaSituacao(string email)
        {
            try
            {
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE contatos set situacao = '2' WHERE email= @email";

                CM.Parameters.Add("@email", SqlDbType.VarChar);
                CM.Parameters["@email"].Value = email;
                CM.Connection = CON;

                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
