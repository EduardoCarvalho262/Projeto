using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.DTO;
using Projeto.DAL;

namespace Projeto.BLL
{
    public class OrcamentosBLL
    {
        public IList<orcamentos_DTO> CargaOrcamentos()
        {
            try
            {
                return new OrcamentosDAL().CargaOrcamentos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AtualizaSituacao(string email)
        {
            try
            {
                return new OrcamentosDAL().atualizaSituacao(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
