using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace situacaoAprendizagem.MODEL
{
    class itemComboBox
    {
        public string Texto { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Texto;
        }
        public itemComboBox(string texto, int id)
        {
            Texto = texto;
            Id = id;
        }
    }
}
