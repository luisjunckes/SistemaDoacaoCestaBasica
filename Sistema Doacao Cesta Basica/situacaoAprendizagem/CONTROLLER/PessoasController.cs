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
    class PessoasController
    {

        public bool Gravar(PessoaEntity pessoa)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {

                return retorno = banco.Banco.ExecuteNonQuery(
                 @"insert into Pessoa (Nome, Cpf, Rg, Telefone, DtNasc) Values (@1, @2, @3, @4, @5)",
               
                "@1", pessoa.Nome,
                "@2", pessoa.Cpf,
                "@3", pessoa.Rg,
                "@4", pessoa.Telefone,
                "@5", pessoa.DtNasc
                 );
                

            }
        }
        public bool Excluir(int id)
        {
            BancoInstance banco;
            bool retorno = false;
            using (banco = new BancoInstance())
            {
                return retorno = banco.Banco.ExecuteNonQuery(
                    @"delete from Pessoa
                    where Id_Pessoa = @1", "@1", id);
            }
        }

        public bool Alterar(PessoaEntity pessoa)
        {
            BancoInstance banco;
            bool ok = false;
            using (banco = new BancoInstance())
            {
                return ok = banco.Banco.ExecuteNonQuery(@"update  Pessoa set Nome =@1, Cpf=@2, Rg= @3, Telefone =@4, DtNasc =@5 where id_Pessoa = @6", "@1", pessoa.Nome, "@2", pessoa.Cpf,
                    "@3",pessoa.Rg, "@4",pessoa.Telefone, "@5",pessoa.DtNasc,"@6", pessoa.Id);
            }
        }
        public DataTable BuscarPessoa(string Cpf)
        {
            DataTable dtResultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Pessoa where Cpf= @Cpf", out dtResultado, "@Cpf", Cpf);
                return dtResultado;
            }
        }
        public DataTable BuscaSimples()
        {
            DataTable dtResultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select * from Pessoa order by id_Pessoa ", out dtResultado);
                return dtResultado;
            }
        }
        public DataTable BuscaPessoaCPF(string cpf)
        {
            DataTable dtResultado = new DataTable();
            BancoInstance banco;
            using (banco = new BancoInstance())
            {
                banco.Banco.ExecuteQuery(@"select Pessoa.id_Pessoa as ID_PESSOA, Pessoa.Nome  as NOME, Pessoa.Cpf as CPF,
                                        familia_pessoas.id_Familia as ID_FAMILIA, Familia.Nome_Familia
                                        from Pessoa
                                        inner Join familia_pessoas
                                        on Pessoa.id_Pessoa = familia_pessoas.id_Pessoa
                                        inner join Familia
                                        on Familia.id_familia = familia_pessoas.id_Familia
                                         where Cpf = @Cpf;", out dtResultado, "@Cpf",cpf);
                return dtResultado;
            }
        }

    }
}
