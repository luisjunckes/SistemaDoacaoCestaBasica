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
    public partial class RelatorioPessoas : Form
    {
        public RelatorioPessoas()
        {
            InitializeComponent();
            PessoasController controller = new PessoasController();
            DataTable retorno = controller.BuscaSimples();
            dataGridView1.DataSource = retorno;

        }

        private void RelatorioPessoas_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtbBuscaCPF.Text != string.Empty)
            {
                PessoasController controller = new PessoasController();

                DataTable retorno = controller.BuscaPessoaCPF(mtbBuscaCPF.Text);


                if (retorno.Rows.Count > 0)
                {
                    dataGridView1.DataSource = retorno;

                }
                else
                {
                    MessageBox.Show("CPF nao localizado no banco de dados, ou nao vinculado em nenhuma familia! ");
                }

            }
            else
            {
                MessageBox.Show("Campo CPF nao pode ser vazio! ");
            }
            

            


            //mtbBuscaCPF.Text = retorno.Rows[0]["Cpf"].ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            PessoasController controller = new PessoasController();
            DataTable retorno = controller.BuscaSimples();
            dataGridView1.DataSource = retorno;

            mtbBuscaCPF.Clear();
        }
    }
}
