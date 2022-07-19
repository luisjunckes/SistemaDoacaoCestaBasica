using situacaoAprendizagem.CONTROLLER;
using situacaoAprendizagem.DAO;
using situacaoAprendizagem.MODEL;
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
    public partial class CadastroFamilia : Form
    {
        public CadastroFamilia()
        {
            InitializeComponent();
            label20.Visible = false;
            btnCadastrar.Enabled = false;
            btnAlterarF.Enabled = false;
            btnExcluir.Enabled = false;
            ttbNomeTitular.Enabled = false;
            ccbCidade.Enabled = false;
            ccbEstado.Enabled = false;
            mtbVincularCpf.Enabled = false;
            btnVincular.Enabled = false;
            btnExcluirIntegrante.Enabled = false;
            btnConsultarFamilia.Enabled = false;
            
            

           

            


            ccbEstado.Items.Add(new itemComboBox("Selecione!", 0));

            EstadoController eController = new EstadoController();
            DataTable dtEstados = eController.BuscarEstado();

            for (int i = 0; i < dtEstados.Rows.Count; i++)
                ccbEstado.Items.Add(new itemComboBox(dtEstados.Rows[i]["Nome"].ToString(),
                    Convert.ToInt32(dtEstados.Rows[i]["id_estado"])));

            ccbEstado.SelectedIndex = ccbEstado.FindStringExact("Selecione!");
            ccbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

        }

       

        

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            {

                string sMensagemErro = string.Empty;

                
                if (ttbNomeTitular.Text == string.Empty)
                {
                    sMensagemErro += "Campo nome não pode ser vazio!" + Environment.NewLine;
                }

                if(ccbEstado.SelectedIndex == 0)
                {
                    sMensagemErro += "Selecione um Estado válido!" + Environment.NewLine;
                }

                if (ccbCidade.SelectedIndex == -1)
                {
                    sMensagemErro += "Selecione uma Cidade válida!" + Environment.NewLine;
                }

                if (sMensagemErro == string.Empty)
                {
                    FamiliaEntity f = new FamiliaEntity(

                                         0,Convert.ToInt32((ccbCidade.SelectedItem as itemComboBox).Id),ttbNomeTitular.Text);

                    FamiliaContoller fController = new FamiliaContoller();

                    int resultadoGravar = fController.Gravar(f);
                    
                    if (resultadoGravar != -1)
                    {
                        MessageBox.Show("Registrado com sucesso! \n Codigo gerado para a familia: "+ resultadoGravar , "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtbCpfTitular.Text = resultadoGravar.ToString();
                       
                        btnCadastrar.Enabled = false;
                        btnAlterarF.Enabled = false;
                        btnExcluir.Enabled = false;
                        ttbNomeTitular.Enabled = false;
                        ccbCidade.Enabled = false;
                        ccbEstado.Enabled = false;
                        btnBuscar.Enabled = true;
                        mtbCpfTitular.Enabled = true;
                        mtbCpfTitular.Clear();
                        ttbNomeTitular.Clear();

                        

                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar o cadastro no banco de dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(sMensagemErro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label20.Text);
            FamiliaContoller excluirFamilia= new FamiliaContoller();
            if (excluirFamilia.Excluir(id))
            {
                MessageBox.Show("Registro excluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao excluir registro, existem vinculos na Familia, favor desvincular para continuar!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ccbEstado_SelectedValueChanged(object sender, EventArgs e)
        {           
            ccbCidade.Items.Clear();
            ccbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            int idSelecionado = (ccbEstado.SelectedItem as itemComboBox).Id;

            CidadeController controllerCidade = new CidadeController();
            DataTable consultaCidades = controllerCidade.BuscarCidade(idSelecionado);

            for (int i = 0; i < consultaCidades.Rows.Count; i++)
                ccbCidade.Items.Add(
                    new itemComboBox(consultaCidades.Rows[i]["Cidade"].ToString(),
                    Convert.ToInt32(consultaCidades.Rows[i]["IdCidade"].ToString())));
        }
      


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtbCpfTitular.Text != string.Empty)
            {
                FamiliaContoller teste1 = new FamiliaContoller();
                DataTable resultado2 = teste1.BuscaTeste(Convert.ToInt32(mtbCpfTitular.Text));


                if (resultado2.Rows.Count > 0)
                {

                    label20.Text = resultado2.Rows[0]["id_familia"].ToString();
                    mtbCpfTitular.Text = resultado2.Rows[0]["id_familia"].ToString();
                    ttbNomeTitular.Text = resultado2.Rows[0]["Nome_Familia"].ToString();

                    resultado2 = teste1.BuscaTeste(Convert.ToInt32(mtbCpfTitular.Text));
                    dataGridView1.DataSource = resultado2;


                    MessageBox.Show("Cadastro localizado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ttbNomeTitular.Enabled = true;
                    
                    btnAlterarF.Enabled = true;
                    btnExcluir.Enabled = true;
                    mtbCpfTitular.Enabled = false;
                    btnBuscar.Enabled = false;
                    mtbVincularCpf.Enabled = true;
                    btnVincular.Enabled = true;
                    btnConsultarFamilia.Enabled = true;
                    btnExcluirIntegrante.Enabled = true;


                }
                else
                {

                    MessageBox.Show("Cadastro nao localizado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar.Enabled = false;
                    btnCadastrar.Enabled = true;
                    btnAlterarF.Enabled = false;
                    btnExcluir.Enabled = false;
                    ttbNomeTitular.Enabled = true;
                    ccbCidade.Enabled = true;
                    ccbEstado.Enabled = true;
                    mtbCpfTitular.Enabled = false;
                    mtbCpfTitular.Clear();

                }

            }
            else
            {
                MessageBox.Show("Campo Identificação Unica nao pode ser Vazio! ");
            }
           
        }

        private void btnAlterarF_Click(object sender, EventArgs e)
        {
            FamiliaEntity alteraFamilia= new FamiliaEntity(int.Parse(label20.Text), ttbNomeTitular.Text);
            FamiliaContoller aF = new FamiliaContoller();
            if (aF.Alterar(alteraFamilia))
            {
                MessageBox.Show("Cadastro alterado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Erro ao alterar!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PessoasController pessoa = new PessoasController();
            DataTable resultado2 = pessoa.BuscarPessoa(mtbVincularCpf.Text);

            if (mtbVincularCpf.Text != String.Empty)
            {
                if (resultado2.Rows.Count > 0)
                {
                    FamiliaPessoaControlle family = new FamiliaPessoaControlle();
                    DataTable resultado3 = family.BuscarPorIdPessoa(Convert.ToInt32(resultado2.Rows[0]["id_Pessoa"].ToString()));
                    if (resultado3.Rows.Count > 0)
                    {
                        MessageBox.Show("Ja existe vinculo dessa pessoa em uma outra familia!");
                        mtbVincularCpf.Clear();
                    }
                    else
                    {
                        FamiliaPessoaEntity fpE = new FamiliaPessoaEntity(0, Convert.ToInt32(resultado2.Rows[0]["id_Pessoa"].ToString()),
                            Convert.ToInt32(label20.Text));
                        if (family.GravarPessoaFamilia(fpE))
                        {
                            MessageBox.Show("CPF vinculado!");
                            mtbVincularCpf.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar!");
                            mtbVincularCpf.Clear();
                        }

                    }





                }
                else
                {
                    MessageBox.Show("CPF NAO LOCALIZADO NO BANCO DE DADOS, FAVOR CADASTRAR A PESSOA PRIMEIRO! ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtbVincularCpf.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Campo CPF nao pode ser vazio! ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ccbEstado.SelectedIndex = 0;
            ccbCidade.SelectedIndex = -1;

            btnCadastrar.Enabled = false;
            btnAlterarF.Enabled = false;
            btnExcluir.Enabled = false;
            ttbNomeTitular.Enabled = false;
            ccbCidade.Enabled = false;
            ccbEstado.Enabled = false;
            btnBuscar.Enabled = true;
            mtbCpfTitular.Enabled = true;
            mtbCpfTitular.Clear();
            ttbNomeTitular.Clear();
            btnVincular.Enabled = false;
            btnExcluirIntegrante.Enabled = false;
            btnConsultarFamilia.Enabled = false;
            mtbVincularCpf.Enabled = false;
            dataGridView1.Columns.Clear();
            dgvIntegrantes.Columns.Clear();

        }

        private void btnConsultarFamilia_Click(object sender, EventArgs e)
        {
            

            FamiliaPessoaControlle teste = new FamiliaPessoaControlle();
            DataTable resultado3 = teste.BuscaFamiliaPessoa(Convert.ToInt32(mtbCpfTitular.Text));
            resultado3 = teste.BuscaFamiliaPessoa(Convert.ToInt32(mtbCpfTitular.Text));

            dgvIntegrantes.DataSource = resultado3;

        }

        private void btnExcluirIntegrante_Click(object sender, EventArgs e)
        {

            if (dgvIntegrantes.Rows.Count > 1 )
            {
                int id = int.Parse(dgvIntegrantes.CurrentRow.Cells[4].Value.ToString());
                FamiliaPessoaControlle excluirIntegrante = new FamiliaPessoaControlle();
                if (excluirIntegrante.ExcluirIntegranteFamilia(id))
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao excluir registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum membro vinculado! ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }  

           

        }

        private void dgvIntegrantes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvIntegrantes.Rows.Count > 1)
            {
                string cpf = dgvIntegrantes.CurrentRow.Cells["CPF"].Value.ToString();
                string dtNasc = dgvIntegrantes.CurrentRow.Cells["Dt_NASC"].Value.ToString();
                string nome = dgvIntegrantes.CurrentRow.Cells["NOME_INTEGRANTE"].Value.ToString();
                string telefone = dgvIntegrantes.CurrentRow.Cells["TELEFONE"].Value.ToString();
                string id_pessoa = dgvIntegrantes.CurrentRow.Cells["id_Pessoa"].Value.ToString();
                PessoaEntity pessoa = new PessoaEntity(Convert.ToInt32(id_pessoa), nome, cpf, "", telefone, dtNasc);
                CadastroPessoas tela = new CadastroPessoas(pessoa);
                tela.Show();
            }
            
        }
    }
}

