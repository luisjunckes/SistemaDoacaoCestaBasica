using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.MODEL
{
    public class FamiliaPessoaEntity
    {
        public FamiliaPessoaEntity(int id, int id_Pessoa, int id_Familia)
        {
            Id = id;
            Id_Pessoa = id_Pessoa;
            Id_Familia = id_Familia;
        }

        public int Id { get; private set; }
        public int Id_Pessoa { get; private set; }
        public int Id_Familia { get; private set; }

    }
}
