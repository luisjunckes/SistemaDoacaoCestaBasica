using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.MODEL
{
    class EstadoEntity
    {
        public int IdEstado { get; private set; }
        public string Estado { get; private set; }
        public string Sigla { get; private set; }

        public EstadoEntity(int idEstado, string sigla, string estado)
        {
            IdEstado = idEstado;
            Estado = estado;
            Sigla = sigla;
        }
    }
}

