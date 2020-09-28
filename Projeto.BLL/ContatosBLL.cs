using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto.DTO;
using Projeto.DAL;

namespace Projeto.BLL
{
    public class ContatosBLL
    {
        public IList<contatos_DTO> cargaContatos()
        {
            try
            {
                return new ContatosDAL().cargaContatos();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
