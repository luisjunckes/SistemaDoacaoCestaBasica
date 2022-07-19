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
    public class FamiliaPessoaControlle
    {
        public DataTable BuscarPorIdPessoa(int idPessoa)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(
                    @"select * from familia_pessoas where id_Pessoa = @1",
                    out retorno, "@1", idPessoa);
                return retorno;
            }
        }
        public bool GravarPessoaFamilia(FamiliaPessoaEntity familiaPessoa)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {

                return banco.Banco.ExecuteNonQuery(
                @"insert into familia_pessoas (id_Pessoa, id_Familia  )Values (@1, @2)",

               "@1", familiaPessoa.Id_Pessoa,
               "@2", familiaPessoa.Id_Familia);

            }
        }
        public DataTable BuscaFamiliaPessoa(int idFamilia)
        {
            BancoInstance banco;
            DataTable retorno = new DataTable();
            using (banco = new BancoInstance())
            {

               
                banco.Banco.ExecuteQuery(
                   @"select familia_pessoas.id_Familia as ID_FAMILIA ,Familia.Nome_Familia as NOME_FAMILIA, Cidade.Cidade as CIDADE, Estado.Nome as ESTADO,
                        familia_pessoas.id_Pessoa, Pessoa.Nome as NOME_INTEGRANTE,
                        Pessoa.Cpf as CPF, Pessoa.DtNasc as Dt_NASC, Pessoa.Telefone as TELEFONE

                        from familia_pessoas
                        inner join Familia
                            on familia_pessoas.id_Familia = Familia.id_familia
                            inner join Pessoa
                            on familia_pessoas.id_Pessoa = Pessoa.id_Pessoa
                            inner join Cidade
                            on Familia.idCidade = Cidade.IdCidade
                            inner Join Estado
                            on Cidade.IdEstado = Estado.id_estado
                            where familia_pessoas.id_Familia = @1", out retorno, "@1", idFamilia);
                return retorno;

            }
        }
        public bool ExcluirIntegranteFamilia(int id_Pessoa)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {
                return retorno = banco.Banco.ExecuteNonQuery(
                    @"delete from familia_pessoas
                    where id_Pessoa = @1", "@1", id_Pessoa);
            }
        }
    }
}
