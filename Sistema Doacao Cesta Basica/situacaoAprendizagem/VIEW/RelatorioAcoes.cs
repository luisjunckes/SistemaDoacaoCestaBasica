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
    public partial class RelatorioAcoes : Form
    {
        public RelatorioAcoes()
        {
            InitializeComponent();
            AcaoController controller = new AcaoController();
            DataTable retorno = controller.BuscaSimples();
            dgvRelatorioAcoes.DataSource = retorno;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {

        }

        private void RelatorioAcoes_Load(object sender, EventArgs e)
        {
            
        }
    }
}
