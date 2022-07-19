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
    class FamiliaContoller
    {
        public int Gravar(FamiliaEntity familia)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {

                 retorno = banco.Banco.ExecuteNonQuery(
                 @"insert into Familia (idCidade, Nome_Familia) Values (@1, @2)",

                "@1", familia.Id_Cidade,
                "@2", familia.Nome_Titular);
                
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
                    @"delete from Familia
                    where id_familia = @1", "@1", id);
            }
        }
        public bool Alterar(FamiliaEntity familia)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                return ok = banco.Banco.ExecuteNonQuery(@"update  Familia set  Nome_Familia=@1 where id_familia = @2", "@1", familia.Nome_Titular, "@2", familia.Id_Familia);
            }
        }
       


        public DataTable BuscaTeste( int idFamilia)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
               
                banco.Banco.ExecuteQuery(
                    @"select Familia.id_familia as ID_FAMILIA, Nome_Familia as NOME_FAMILIA, Cidade.Cidade, Estado.Nome as NOME_ESTADO
                        from Familia
                        inner Join Cidade 
                        on Familia.idCidade = Cidade.IdCidade
                        inner join Estado
                        on Estado.id_estado = Cidade.IdEstado
                        where Familia.id_familia = @1", out retorno, "@1", idFamilia);
                return retorno;

            }
        }
        public DataTable BuscaF()
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {

                banco.Banco.ExecuteQuery(
                    @"select Familia.id_familia as ID_FAMILIA, Nome_Familia as NOME_FAMILIA, Cidade.Cidade, Estado.Nome as NOME_ESTADO
                        from Familia
                        inner Join Cidade 
                        on Familia.idCidade = Cidade.IdCidade
                        inner join Estado
                        on Estado.id_estado = Cidade.IdEstado
                        order by id_familia", out retorno);
                return retorno;

            }
        }
        public DataTable BuscarPorId(int idFamilia)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from Familia where id_familia = @1",
                    out retorno, "@1", idFamilia);
                return retorno;
            }
        }
    }
}
