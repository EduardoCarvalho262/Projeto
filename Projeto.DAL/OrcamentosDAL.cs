using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using Projeto.DTO;

namespace Projeto.DAL
{
    public class OrcamentosDAL
    {
        public IList<orcamentos_DTO> CargaOrcamentos()
        {
            try
            {
                //Criação da string de Conexão
                MySqlConnection CON = new MySqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST_MYSQL;

                //Criaçao do comando Select sql
                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM orcamentos WHERE situacao = '1'";
                CM.Connection = CON;


                //Criação da leitura dos dados da tabela
                MySqlDataReader ER;

                //Lista que irá armazenar os dados que serão lidos
                IList<orcamentos_DTO> listOrcamentoDTO = new List<orcamentos_DTO>();

                //Abrindo conexão
                CON.Open();


                //Realizando a leitura e adicionando na lista
                ER = CM.ExecuteReader();
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        orcamentos_DTO orc = new orcamentos_DTO();

                       // orc.id = Convert.ToInt16(ER["id"]);
                        orc.nome = Convert.ToString(ER["nome"]);
                        orc.telefone = Convert.ToString(ER["telefone"]);
                        orc.email = Convert.ToString(ER["email"]);
                        orc.situacao = Convert.ToString(ER["situacao"]);
                        listOrcamentoDTO.Add(orc);
                    }

                }
                return listOrcamentoDTO;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int atualizaSituacao(string email)
        {
            try
            {
                MySqlConnection CON = new MySqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST_MYSQL;
                MySqlCommand CM = new MySqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE orcamentos set situacao = '2' WHERE email= @email";

                CM.Parameters.Add("@email", MySqlDbType.VarChar);
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
