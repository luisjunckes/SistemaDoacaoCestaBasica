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
    class AcaoController
    {
        public int Gravar(AcaoEntity Acao)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {

                retorno = banco.Banco.ExecuteNonQuery(
                @"insert into Acao (id_cidade, Nome, DtInicio, DtFim) Values (@1, @2, @3, @4)",

               "@1", Acao.Id_Cidade,
               "@2", Acao.NomeAcao,
               "@3", Acao.DtInicio,
               "@4", Acao.DtFim);

                int id = -1;
                if (retorno)
                {
                    id = banco.Banco.GetIdentity();
                }
                return id;

            }
        }

        public bool Excluir(int id)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {
                return retorno = banco.Banco.ExecuteNonQuery(
                    @"delete from Acao
                    where id_acao = @1", "@1", id);
            }
        }

        public DataTable BuscaTeste(int idAcao)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
               
                banco.Banco.ExecuteQuery(
                    @"select Acao.id_acao as ID_ACAO, Acao.Nome as NOME_ACAO , Acao.DtInicio ,Acao.DtFim,  Cidade.Cidade, Estado.Nome as NOME_ESTADO
                        from Acao
                        inner Join Cidade 
                        on Acao.id_cidade = Cidade.IdCidade
                        inner join Estado
                        on Estado.id_estado = Cidade.IdEstado
                        where Acao.id_acao= @1", out retorno, "@1", idAcao);
                return retorno;

            }
        }

        public DataTable BuscaSimples()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {

                banco.Banco.ExecuteQuery(
                    @"select Acao.id_acao as ID_ACAO, Acao.Nome as NOME_ACAO , Acao.DtInicio ,Acao.DtFim,  Cidade.Cidade, Estado.Nome as NOME_ESTADO
                        from Acao
                        inner Join Cidade 
                        on Acao.id_cidade = Cidade.IdCidade
                        inner join Estado
                        on Estado.id_estado = Cidade.IdEstado
                        order by id_acao", out retorno);
                return retorno;

            }
        }
        public bool Alterar(AcaoEntity acao)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                return ok = banco.Banco.ExecuteNonQuery(@"update  Acao set  Nome =@1, DtFim =@2, DtInicio =@3 where id_acao = @4", "@1", acao.NomeAcao,"@2",
                    acao.DtFim,"@3", acao.DtInicio,"@4", acao.Id_Acao);
            }
        }
    }

}
