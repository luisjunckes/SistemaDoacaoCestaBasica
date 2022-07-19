using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.MODEL
{
    public class AcaoFamiliaEntity
    {
        public AcaoFamiliaEntity(int id, int id_acao, int id_familia)
        {
            this.id = id;
            this.id_acao = id_acao;
            this.id_familia = id_familia;
        }

        public int id { get; private set; }
        public int id_acao { get; private set; }
        public int id_familia { get; private set; }


    }

      

}
