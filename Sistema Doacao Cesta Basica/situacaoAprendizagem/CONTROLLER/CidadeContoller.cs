using situacaoAprendizagem.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.CONTROLLER
{
    class CidadeController
    {
        public DataTable BuscarCidade(int idEstado)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Cidade where IdEstado=@1",
                    out retorno, "@1", idEstado);

                return retorno;
            }
        }
        public DataTable BuscarCidadeporId(int id)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Cidade where IdCidade=@1",
                    out retorno, "@1", id);

                return retorno;
            }
        }
    }
}
