using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.MODEL
{
    class CidadeEntity
    {
        public int IdCidade { get; private set; }
        public int IdEstado { get; private set; }
        public string Cidade { get; private set; }

        public CidadeEntity(int idCidade, string cidade, int idEstado )
        {
            IdCidade = idCidade;
            IdEstado = idEstado;
            Cidade = cidade;
        }
    }
}
