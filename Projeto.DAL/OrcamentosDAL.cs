using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                SqlConnection CON = new SqlConnection();
                CON.ConnectionString = Properties.Settings.Default.CST;

                //Criaçao do comando Select sql
                SqlCommand CM = new SqlCommand();
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM orcamentos";
                CM.Connection = CON;


                //Criação da leitura dos dados da tabela
                SqlDataReader ER;

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

                        orc.id = Convert.ToInt16(ER["id"]);
                        orc.nome = Convert.ToString(ER["nome"]);
                        orc.telefone = Convert.ToString(ER["telefone"]);
                        orc.email = Convert.ToString(ER["email"]);
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
    }
}
