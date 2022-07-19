using situacaoAprendizagem.CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace situacaoAprendizagem.VIEW
{
    public partial class RelatorioFamilias : Form
    {
        public RelatorioFamilias()
        {
            InitializeComponent();
            FamiliaContoller controller = new FamiliaContoller();
            DataTable retorno = controller.BuscaF();
            dataGridView1.DataSource = retorno;
        }

        private void RelatorioFamilias_Load(object sender, EventArgs e)
        {

        }
    }
}
