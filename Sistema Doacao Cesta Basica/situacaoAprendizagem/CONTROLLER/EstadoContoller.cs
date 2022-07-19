using situacaoAprendizagem.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.CONTROLLER
{
    class EstadoController
    {

        public DataTable BuscarEstado()
        {

            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Estado", out retorno);
                return retorno;
            }
           
        }
    }
}
