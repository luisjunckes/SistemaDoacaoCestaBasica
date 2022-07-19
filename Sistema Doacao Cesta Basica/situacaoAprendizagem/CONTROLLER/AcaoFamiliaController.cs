using situacaoAprendizagem.DAO;
using situacaoAprendizagem.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.CONTROLLER
{
    public class AcaoFamiliaController
    {
        public bool GravarAcaoFamilia(AcaoFamiliaEntity acaoFamilia)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {

                return banco.Banco.ExecuteNonQuery(
                @"insert into acao_familia (id_Acao, id_Familia) Values (@1, @2)",

               "@1", acaoFamilia.id_acao,
               "@2", acaoFamilia.id_familia);


            }
        }
        public DataTable BuscarPorIdAcao(int idAcao)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from acao_familia where id_Familia = @1",
                    out retorno, "@1", idAcao);
                return retorno;
            }
        }

        public DataTable BuscarAcaoPorIdFamiliaEIdAcao(int idAcao, int idFamilia)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from acao_familia where id_Familia = @1 and id_acao = @2",
                    out retorno, "@1", idFamilia , "@2", idAcao);
                return retorno;
            }
        }

        public DataTable BuscaAcaoFamilia(int idAcao)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {


                banco.Banco.ExecuteQuery(
                   @"select  ap.id_Acao, Cd.Cidade, Ac.DtInicio, Ac.DtFim, f.id_familia, Nome_Familia

                        from acao_familia ap
                        inner join Familia f 
                        on f.id_familia = ap.id_Familia
                        inner join Acao Ac
                        on Ac.id_acao = ap.id_Acao
                        inner join Cidade Cd
                        on cd.IdCidade= Ac.id_cidade
                        
                      

                        where ap.id_Acao = @1", out retorno, "@1", idAcao);
                    
                return retorno;

            }
        }
        public bool DesvincularFamilia(int id_familia)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {
                return retorno = banco.Banco.ExecuteNonQuery(
                    @"delete from acao_familia
                    where id_Familia = @1", "@1", id_familia);
            }
        }

    }
}    
