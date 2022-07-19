using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.MODEL
{
    public class FamiliaEntity
    {
       
        
        public int Id_Familia { get; private set; }
        
        public int Id_Cidade { get; private set; }

        public string Nome_Titular { get; private set; }

        public FamiliaEntity()
        {

        }

        public FamiliaEntity(int id_Familia, int idCidade, string nome_titular)
        {
            Id_Familia = id_Familia;
            Id_Cidade = idCidade;
            Nome_Titular = nome_titular;
        }
        public FamiliaEntity(int id_Familia,  string nome_titular)
        {
            Id_Familia = id_Familia;
            
            Nome_Titular = nome_titular;
        }



    }
  

    
}
