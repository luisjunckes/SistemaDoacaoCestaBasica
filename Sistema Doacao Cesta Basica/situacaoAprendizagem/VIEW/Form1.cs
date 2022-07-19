using situacaoAprendizagem.VIEW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace situacaoAprendizagem
{
    public partial class Linchester : Form
    {
        public Linchester()
        {
            InitializeComponent();
        }

        private void pESSOASToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            CadastroPessoas cadastroPessoas = new CadastroPessoas();
            cadastroPessoas.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fAMÍLIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFamilia cadastroFamilia = new CadastroFamilia();
            cadastroFamilia.Show();
        }

        private void eSTADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAcao cadastroAcao = new CadastroAcao();
            cadastroAcao.Show();
        }

        private void aÇÕESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioAcoes relatorioAcoes = new RelatorioAcoes();
            relatorioAcoes.Show();
        }

        private void fAMILIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioFamilias relatorioFamilias = new RelatorioFamilias();
            relatorioFamilias.Show();
        }

        private void pESSOASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RelatorioPessoas relatoioPessoas = new RelatorioPessoas();
            relatoioPessoas.Show();

            
        }

        private void pESSOAPORCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
