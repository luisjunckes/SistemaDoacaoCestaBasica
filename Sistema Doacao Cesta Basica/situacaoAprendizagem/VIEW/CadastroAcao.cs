using situacaoAprendizagem.CONTROLLER;
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
    public partial class CadastroAcao : Form
    {
        public CadastroAcao()
        {
            InitializeComponent();

            ttbNomeAcao.Enabled = false;
            dtpDtFim.Enabled = false;
            dtpDtInicio.Enabled = false;
            ccbCidade.Enabled = false;
            ccbEstado.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadatrar.Enabled = false;
            label21.Visible = false;
            btnVincularFamilia.Enabled = false;
            mtbVincularFamilia.Enabled = false;
            rdbCodFam.Checked = true;
            btnConsultarFamilia.Enabled = false;
            btnExcluirFamilia.Enabled = false;

            ccbEstado.Items.Add(new itemComboBox("Selecione!", 0));

            EstadoController eController = new EstadoController();
            DataTable dtEstados = eController.BuscarEstado();

            for (int i = 0; i < dtEstados.Rows.Count; i++)
                ccbEstado.Items.Add(new itemComboBox(dtEstados.Rows[i]["Nome"].ToString(),
                    Convert.ToInt32(dtEstados.Rows[i]["id_estado"])));

            ccbEstado.SelectedIndex = ccbEstado.FindStringExact("Selecione!");
            ccbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CadastroAcao_Load(object sender, EventArgs e)
        {

        }

        private void ccbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            ccbCidade.Items.Clear();

            //Bloqueando edição do usuário
            ccbCidade.DropDownStyle = ComboBoxStyle.DropDownList;
            int idSelecionado = (ccbEstado.SelectedItem as itemComboBox).Id;

            CidadeController controllerCidade = new CidadeController();
            DataTable consultaCidades = controllerCidade.BuscarCidade(idSelecionado);

            for (int i = 0; i < consultaCidades.Rows.Count; i++)
                ccbCidade.Items.Add(
                    new itemComboBox(consultaCidades.Rows[i]["Cidade"].ToString(),
                    Convert.ToInt32(consultaCidades.Rows[i]["IdCidade"].ToString())));
        }

       

        private void btnCadatrar_Click(object sender, EventArgs e)
        {
            
            DateTime datainicio = new DateTime();
            DateTime datafim = new DateTime();

            datainicio = Convert.ToDateTime(dtpDtInicio.Text);
            datafim = Convert.ToDateTime(dtpDtFim.Text);

            DateTime datahoje = DateTime.Now.Date;
            DateTime datahoje2 = DateTime.Now.Date;
            TimeSpan diferencaTeste = datainicio.Date - datahoje.AddDays(15).Date;
            TimeSpan diferencaTeste2 = datainicio.Date - datafim.Date;

            string sMensagemErro = string.Empty;

            if (diferencaTeste2.TotalDays > 0 )
            {
                sMensagemErro += "Data final nao pode ser menor que data inicial da Ação! " +Environment.NewLine;
            }
            if (ttbNomeAcao.Text == string.Empty)
            {
                sMensagemErro += "Digite uma descrição para a ação atual!!" + Environment.NewLine;
            }

            
            

            if(diferencaTeste.TotalDays >= 10)
            {
                sMensagemErro += "Não é possível cadastrar uma ação com o inicio maior que 10 dias" + Environment.NewLine;
            }

            if (datainicio < DateTime.Now.AddDays(-1))
            {
                sMensagemErro += "Não é possível cadastrar uma ação com data inicial menor que a data atual" + Environment.NewLine;
            }

            if (datafim < DateTime.Now.AddDays(-1))
            {
                sMensagemErro += "Não é possível cadastrar uma ação com data final menor que a data atual" + Environment.NewLine;
            }

            if (ccbEstado.SelectedIndex == 0)
            {
                sMensagemErro += "Selecione um Estado válido!" + Environment.NewLine;
            }
           
            //if (diferencaTeste.TotalDays < 0)
            //{
            //    sMensagemErro += "Data de fim nao pode ser inferioir ao inicio!" + Environment.NewLine;
            //}

            if (ccbCidade.SelectedIndex == -1)
            {
                sMensagemErro += "Selecione uma Cidade válida!" + Environment.NewLine;
            }

            if (sMensagemErro == string.Empty)
            {
                AcaoEntity A = new AcaoEntity(

                                     0, Convert.ToInt32((ccbCidade.SelectedItem as itemComboBox).Id), ttbNomeAcao.Text,dtpDtInicio.Value,dtpDtFim.Value);

                AcaoController aController = new AcaoController();

                int resultadoGravar = aController.Gravar(A);

                if (resultadoGravar != -1)
                {
                    MessageBox.Show("Registrado com sucesso! \n Codigo gerado para a Acao: " + resultadoGravar, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtbIdAcao.Text = resultadoGravar.ToString();
                    
                    ttbNomeAcao.Enabled = false;
                    mtbIdAcao.Clear();
                    mtbIdAcao.Enabled = true;
                    dtpDtFim.Enabled = false;
                    dtpDtInicio.Enabled = false;
                    ccbCidade.Enabled = false;
                    ccbEstado.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnCadatrar.Enabled = false;
                    btnBuscar.Enabled = true;
                    
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (mtbIdAcao.Text != string.Empty)
            {
                AcaoController aController = new AcaoController();
                DataTable resultado2 = aController.BuscaTeste(Convert.ToInt32(mtbIdAcao.Text));


                if (resultado2.Rows.Count > 0)
                {
                    resultado2 = aController.BuscaTeste(Convert.ToInt32(mtbIdAcao.Text));
                    datagridview2.DataSource = resultado2;

                    ttbNomeAcao.Text = datagridview2.CurrentRow.Cells[1].Value.ToString();


                    label21.Text = resultado2.Rows[0]["id_acao"].ToString();
                    mtbIdAcao.Text = resultado2.Rows[0]["id_acao"].ToString();
                    


                    MessageBox.Show("Acao localizada", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtpDtFim.Enabled = false;
                    dtpDtInicio.Enabled = false;
                    mtbIdAcao.Enabled = false;
                    ttbNomeAcao.Enabled = true;
                    dtpDtFim.Enabled = true;
                    dtpDtInicio.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnVincularFamilia.Enabled = true;
                    mtbVincularFamilia.Enabled = true;
                    btnConsultarFamilia.Enabled = true;
                    btnExcluirFamilia.Enabled = true; 

                }
                else
                {
                    MessageBox.Show("Acao nao localizada! !", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtbIdAcao.Enabled = false;
                    mtbIdAcao.Clear();
                    ttbNomeAcao.Enabled = true;
                    dtpDtInicio.Enabled = true;
                    dtpDtFim.Enabled = true;
                    ccbCidade.Enabled = true;
                    ccbEstado.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCadatrar.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Campo ID nao pode ser vazio! ");
            }
           
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AcaoEntity alterar= new AcaoEntity(int.Parse(label21.Text),0,ttbNomeAcao.Text,dtpDtInicio.Value,dtpDtFim.Value);
            AcaoController aF = new AcaoController();



            string sMensagemErro = string.Empty;



            DateTime datainicio = new DateTime();
            DateTime datafim = new DateTime();

            datafim = Convert.ToDateTime(dtpDtFim.Text);
            datainicio = Convert.ToDateTime(dtpDtInicio.Text);

            DateTime datahoje = DateTime.Now.Date;
            TimeSpan diferencaTeste = datainicio.Date - datahoje.AddDays(15).Date;
            TimeSpan diferencaTeste2 = datainicio.Date - datafim.Date;

           
            if (diferencaTeste2.TotalDays > 0)
            {
                sMensagemErro += "Data final nao pode ser menor que data inicial da Ação! " + Environment.NewLine;
            }

            if (ttbNomeAcao.Text == string.Empty)
            {
                sMensagemErro += "Digite uma descrição para a ação atual!!" + Environment.NewLine;
            }



            if (diferencaTeste.TotalDays >= 10)
            {
                sMensagemErro += "Não é possível cadastrar uma ação com o inicio maior que 10 dias" + Environment.NewLine;
            }

            if (datainicio < DateTime.Now.AddDays(-1))
            {
                sMensagemErro += "Não é possível cadastrar uma ação com data inicial menor que a data atual" + Environment.NewLine;
            }

            if (datafim < DateTime.Now.AddDays(-1))
            {
                sMensagemErro += "Não é possível cadastrar uma ação com data final menor que a data atual" + Environment.NewLine;

            }
            if (sMensagemErro == string.Empty)
            {
                if (aF.Alterar(alterar))
                        
                {
                            MessageBox.Show("Cadastro alterado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnBuscar_Click(sender, e);

                            ttbNomeAcao.Clear();
                            ccbEstado.SelectedIndex = 0;
                            ccbCidade.SelectedIndex = -1;

                }else
                {
                            MessageBox.Show("Erro ao alterar!");
                }
                

               
            }
            else
            {
                MessageBox.Show(sMensagemErro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label21.Text);
            AcaoController excluirAcao= new AcaoController();
            if (excluirAcao.Excluir(id))
            {
                MessageBox.Show("Registro excluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Familias cadastradas na Ação, favor excluir familias vinculadas antes de exluir a Ação!! ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ttbNomeAcao.Clear();
            mtbIdAcao.Clear();
            dtpDtInicio.Value = DateTime.Now;
            dtpDtFim.Value = DateTime.Now;
            ccbEstado.SelectedIndex = 0;
            ccbCidade.SelectedIndex = -1;

            ttbNomeAcao.Enabled = false;
            dtpDtFim.Enabled = false;
            dtpDtInicio.Enabled = false;
            ccbCidade.Enabled = false;
            ccbEstado.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadatrar.Enabled = false;
            btnBuscar.Enabled = true;
            mtbIdAcao.Enabled = true;
            btnVincularFamilia.Enabled = false;
            mtbVincularFamilia.Enabled = false;
            dataGridView1.Columns.Clear();
            datagridview2.Columns.Clear();
            btnConsultarFamilia.Enabled = false;
            btnExcluirFamilia.Enabled = false;
            
            
        }

        private void btnVincularFamilia_Click(object sender, EventArgs e)
        {
            if(rdbCodFam.Checked && mtbVincularFamilia.Text == string.Empty)
            {
                MessageBox.Show("Informe o ID da familia para vincular!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdbCpfIntegrante.Checked && mtbVincularFamilia.Text == string.Empty)
            {
                MessageBox.Show("Informe o CPF do integrante!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdbCodFam.Checked)
            {
                FamiliaContoller pessoa = new FamiliaContoller();
                DataTable resultado2 = pessoa.BuscarPorId(Convert.ToInt32(mtbVincularFamilia.Text));
                if (resultado2.Rows.Count > 0)
                {
                    AcaoFamiliaController acaoFamilia = new AcaoFamiliaController();
                    DataTable resultado3 = acaoFamilia.BuscarPorIdAcao(Convert.ToInt32(resultado2.Rows[0]["id_Familia"].ToString()));


                    if (resultado3.Rows.Count > 0)
                    {
                        MessageBox.Show("Ja existe vínculo da Familia em uma ação!  \n\nLIBERAÇÃO NEGADA !","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mtbVincularFamilia.Clear();
                    }
                    else
                    {
                        AcaoFamiliaEntity fpE = new AcaoFamiliaEntity(0, Convert.ToInt32(mtbIdAcao.Text),
                            Convert.ToInt32(mtbVincularFamilia.Text));

                        if (acaoFamilia.GravarAcaoFamilia(fpE))
                        {
                            MessageBox.Show("Família vinculada, \n LIBERAÇÃO CONCEDIDA! ");
                            mtbVincularFamilia.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao cadastrar no Banco de Dados!");
                            mtbVincularFamilia.Clear();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Família não localizda no Banco de Dados, favor verificar o cadstro de Família!  ! ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtbVincularFamilia.Enabled = true;
                }
            }

            if(rdbCpfIntegrante.Checked)
            {
                PessoasController pessoaController = new PessoasController();
                

                DataTable resultadoBuscaPessoa = pessoaController.BuscarPessoa(mtbVincularFamilia.Text);
                if(resultadoBuscaPessoa.Rows.Count>0)
                {
                    
                    FamiliaPessoaControlle fpController = new FamiliaPessoaControlle();
                    int id_pessoa = Convert.ToInt32(resultadoBuscaPessoa.Rows[0]["id_Pessoa"].ToString());
                    DataTable dtResultado = fpController.BuscarPorIdPessoa(id_pessoa);
                    if(dtResultado.Rows.Count>0)
                    {
                        
                        AcaoFamiliaController acaoFamilia = new AcaoFamiliaController();
                        int id_familia = Convert.ToInt32(dtResultado.Rows[0]["id_Familia"].ToString());
                        DataTable resultado3 = acaoFamilia.BuscarAcaoPorIdFamiliaEIdAcao(Convert.ToInt32(mtbIdAcao.Text),id_familia);

                        
                        if (resultado3.Rows.Count > 0)
                        {
                            MessageBox.Show("CPF informado já consta em sistema o recebimento do benefício !!  \n\nLIBERAÇÃO NEGADA ! "," Atenção! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mtbVincularFamilia.Clear();
                        }
                        else
                        {
                            AcaoFamiliaEntity fpE = new AcaoFamiliaEntity(0, Convert.ToInt32(mtbIdAcao.Text),
                                id_familia);

                            if (acaoFamilia.GravarAcaoFamilia(fpE))
                            {
                                MessageBox.Show("Familia vinculada!");
                                mtbVincularFamilia.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao cadastrar!");
                                mtbVincularFamilia.Clear();
                            }

                        }
                    }
                }
                else
                    MessageBox.Show("Pessoa não localizada! Verifique a digitação ou o cadatro de PESSOAS!");
            }

            
        }

        private void btnConsultarFamilia_Click(object sender, EventArgs e)
        {
            AcaoFamiliaController teste = new AcaoFamiliaController();
            DataTable resultado3 = teste.BuscaAcaoFamilia (Convert.ToInt32(mtbIdAcao.Text));
            resultado3 = teste.BuscaAcaoFamilia(Convert.ToInt32(mtbIdAcao.Text));

            dataGridView1.DataSource = resultado3;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbCodFam_CheckedChanged(object sender, EventArgs e)
        {
            mtbVincularFamilia.Mask = "00000";
        }

        private void rdbCpfIntegrante_CheckedChanged(object sender, EventArgs e)
        {
            mtbVincularFamilia.Mask = "00000000000";
        }

        private void btnExcluirFamilia_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 2)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                AcaoFamiliaController Desvincular = new AcaoFamiliaController();
                if (Desvincular.DesvincularFamilia(id))
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
                MessageBox.Show("Nenhuma familia vinculada a esta Ação! ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
