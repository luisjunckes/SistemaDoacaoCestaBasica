using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.MODEL
{
    class AcaoEntity
    {

        public int Id_Acao { get; private set; }

        public int Id_Cidade { get; private set; }

        public string NomeAcao { get; private set; }

        public  DateTime DtInicio { get;  private set; }

        public DateTime DtFim { get; private set; }
        public AcaoEntity()
        {

        }


        public AcaoEntity(int id_Acao, int id_Cidade, string nomeAcao, DateTime dtInicio, DateTime dtFim)
        {
            Id_Acao = id_Acao;
            Id_Cidade = id_Cidade;
            NomeAcao = nomeAcao;
            DtInicio = dtInicio;
            DtFim = dtFim;
        }


       
    }
    public class AcaoEntity2
    {



        public int Id_Acao { get; private set; }

        
        public string NomeAcao { get; private set; }

        public DateTime DtInicio { get; private set; }
        public DateTime DtFim { get; private set; }


        public AcaoEntity2(int id_Acao,  string nomeAcao, DateTime dtFim, DateTime dtInicio)
        {
            Id_Acao = id_Acao;
            NomeAcao = nomeAcao;
            DtInicio = dtInicio;
            DtFim = dtFim;
        }
    }
    
}
