
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
    public partial class CadastroPessoas : Form
    {
        public CadastroPessoas()
        {

            InitializeComponent();

            resultado.Visible = false;
            resultado1.Visible = false;
            label8.Visible = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnValidacaoCpf.Enabled = false;
            ttbNome.Enabled = false;
            ttbRg.Enabled = false;
            mtbTelefone.Enabled = false;
            btnValidarNascimento.Enabled = false;
            mtbDataNasc.Enabled = false;

        }

        public CadastroPessoas(PessoaEntity pessoa)
        {

            InitializeComponent();

            resultado.Visible = false;
            resultado1.Visible = false;
            label8.Visible = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnValidacaoCpf.Enabled = false;
            ttbNome.Enabled = false;
            ttbRg.Enabled = false;
            mtbTelefone.Enabled = false;
            btnValidarNascimento.Enabled = false;
            mtbDataNasc.Enabled = false;

            mtbCpf.Text = pessoa.Cpf;
            ttbNome.Text = pessoa.Nome;
            mtbTelefone.Text = pessoa.Telefone;
            label8.Text = pessoa.Id.ToString();
            mtbDataNasc.Text = pessoa.DtNasc;



        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            string sMensagemErro = string.Empty;

            if(ttbNome.Text == string.Empty)
            {
                sMensagemErro += "Campo nome não pode ser vazio!" + Environment.NewLine;
            }

            if (mtbCpf.Text.Length > 11 || mtbCpf.Text.Length < 11 || mtbCpf.Text == string.Empty)
            {
                sMensagemErro += "Digite um CPF válido!" + Environment.NewLine;
            }

            if(ttbRg.Text.Length == 0)
            {
                sMensagemErro += "RG inválido!" + Environment.NewLine;
            }

            if (mtbTelefone.Text.Length > 14 || mtbTelefone.Text.Length < 14 || mtbTelefone.Text == string.Empty)
            {
                sMensagemErro += "Telefone inválido!" + Environment.NewLine;
            }

            if(mtbDataNasc.Text.Length > 10 || mtbDataNasc.Text.Length < 10 || mtbDataNasc.Text == string.Empty)
            {
                sMensagemErro += "Data de nascimento inválida.";
            }

            if(sMensagemErro == string.Empty)
            {
                PessoaEntity p = new PessoaEntity(

                                     0, ttbNome.Text, mtbCpf.Text, ttbRg.Text, mtbTelefone.Text, mtbDataNasc.Text);

                PessoasController pController = new PessoasController();

                if (pController.Gravar(p))
                {
                    MessageBox.Show("Registrado com sucesso! ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCadastrar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnValidacaoCpf.Enabled = false;
                    ttbNome.Enabled = false;
                    ttbRg.Enabled = false;
                    mtbTelefone.Enabled = false;
                    btnValidarNascimento.Enabled = false;
                    mtbDataNasc.Enabled = false;
                    resultado.Text = string.Empty;
                    resultado1.Text = string.Empty;
                    ttbNome.Clear();
                    ttbRg.Clear();
                    mtbTelefone.Clear();
                    mtbDataNasc.Clear();
                    mtbCpf.Clear();
                    btnBuscar.Enabled = true;
                    mtbCpf.Enabled = true;
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

        private void btnValidacaoCpf_Click(object sender, EventArgs e)
        {
            if (mtbCpf.Text.Length < 11)
            {
                MessageBox.Show("CPF incompleto, favor verificar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resultado.Text = String.Empty;
                mtbCpf.Focus();
            }
            else
            {
                string NumeroCpf = mtbCpf.Text;
                if (ValidacaoCPF.verificar(NumeroCpf))
                {
                    resultado.Visible = true;
                    resultado.Text = "CPF Valido!";
                    resultado.BackColor = Color.Green;
                    mtbCpf.Enabled = false;
                    btnValidarNascimento.Enabled = true;
                    mtbDataNasc.Enabled = true;
                    btnValidacaoCpf.Enabled = false;
                }
                else
                {
                    resultado.Visible = true;
                    resultado.Text = " CPF Invalido!";
                    mtbCpf.Focus();
                    resultado.BackColor = Color.Red;
                    mtbCpf.Clear();
                    btnValidacaoCpf.Enabled = false;
                    btnBuscar.Enabled = true;
                    mtbCpf.Enabled = true;
                }
            }
        }
   

        private void btnValidarNascimento_Click(object sender, EventArgs e)
        {

            DateTime dataEntrada = new DateTime();
            int text = Convert.ToInt32(mtbDataNasc.Text.Length);
            if (text == 10)
            {
                try
                {
                    dataEntrada = Convert.ToDateTime(mtbDataNasc.Text);
                    DateTime dataHoje = DateTime.Now.Date;
                    int diferenca = dataHoje.Year - dataEntrada.Year;

                    if (diferenca >= 18)
                    {
                        resultado1.Text = "Data Válida, pessoa maior que 18 Anos! ";
                        resultado1.Visible = true;
                        resultado1.BackColor = Color.Green;
                        btnCadastrar.Enabled = true;
                        btnValidacaoCpf.Enabled = false;
                        ttbNome.Enabled = true;
                        ttbRg.Enabled = true;
                        mtbTelefone.Enabled = true;
                        mtbDataNasc.Enabled = false;
                        btnValidarNascimento.Enabled = false;
                    }
                    else
                    {
                        resultado1.Text = "Data Inválida, pessoa menor que 18 Anos! ";
                        resultado1.BackColor = Color.Red;
                        resultado1.Visible = true;
                    };


                    //dataEntrada = dataHoje.AddDays(40);

                }

                catch (Exception x)
                {

                    MessageBox.Show("Data Invalida! Verifique e tente novamente. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Campo DATA incompleto, favor verificar", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (mtbCpf.Text.Length == 11)
            {
                if (!ValidarCampoCpf(mtbCpf.Text))
                {
                    PessoasController pessoa = new PessoasController();
                    DataTable resultado2 = pessoa.BuscarPessoa(mtbCpf.Text);

                    if (resultado2.Rows.Count > 0)
                    {
                        label8.Text = resultado2.Rows[0]["id_Pessoa"].ToString();
                        mtbCpf.Text = resultado2.Rows[0]["Cpf"].ToString();
                        ttbNome.Text = resultado2.Rows[0]["Nome"].ToString();
                        mtbDataNasc.Text = resultado2.Rows[0]["DtNasc"].ToString();
                        mtbTelefone.Text = resultado2.Rows[0]["Telefone"].ToString();
                        ttbRg.Text = resultado2.Rows[0]["Rg"].ToString();

                        MessageBox.Show("Cadastro localizado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnExcluir.Enabled = true;
                        mtbCpf.Enabled = false;
                        btnBuscar.Enabled = false;

                        ttbNome.Enabled = true;

                        ttbRg.Enabled = true;
                        btnAlterar.Enabled = true;
                        mtbTelefone.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("Cadastro nao localizado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnValidacaoCpf.Enabled = true;
                        btnBuscar.Enabled = false;
                        mtbCpf.Enabled = false;

                    }
                }
                else
                {
                    MessageBox.Show("Cpf Inválido!");
                }
                
            }
            else
            {
                MessageBox.Show("Campo CPF incompleto! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private bool ValidarCampoCpf(string cpf)
        {
            if (cpf == "00000000000" ||
                cpf == "11111111111" ||
                cpf == "22222222222" ||
                cpf == "33333333333" ||
                cpf == "44444444444" ||
                cpf == "55555555555" ||
                cpf == "66666666666" ||
                cpf == "77777777777" ||
                cpf == "88888888888" ||
                cpf == "99999999999" ||
                string.IsNullOrWhiteSpace(cpf))
                return true;
            return false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string sMensagemErro = string.Empty;

            if (ttbNome.Text == string.Empty)
            {
                sMensagemErro += "Campo nome não pode ser vazio!" + Environment.NewLine;
            }

            if (mtbCpf.Text.Length > 11 || mtbCpf.Text.Length < 11 || mtbCpf.Text == string.Empty)
            {
                sMensagemErro += "Digite um CPF válido!" + Environment.NewLine;
            }

            if (ttbRg.Text.Length == 0)
            {
                sMensagemErro += "RG inválido!" + Environment.NewLine;
            }

            if (mtbTelefone.Text.Length > 14 || mtbTelefone.Text.Length < 14 || mtbTelefone.Text == string.Empty)
            {
                sMensagemErro += "Telefone inválido!" + Environment.NewLine;
            }

            if (mtbDataNasc.Text.Length > 10 || mtbDataNasc.Text.Length < 10 || mtbDataNasc.Text == string.Empty)
            {
                sMensagemErro += "Data de nascimento inválida.";
            }

            if (sMensagemErro == string.Empty)
            {
                PessoaEntity poppey = new PessoaEntity(int.Parse(label8.Text), ttbNome.Text, mtbCpf.Text, ttbRg.Text, mtbTelefone.Text, mtbDataNasc.Text);
                PessoasController p = new PessoasController();
                if (p.Alterar(poppey))
                {
                    MessageBox.Show("Cadastro alterado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCadastrar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnValidacaoCpf.Enabled = false;
                    ttbNome.Enabled = false;
                    ttbRg.Enabled = false;
                    mtbTelefone.Enabled = false;
                    btnValidarNascimento.Enabled = false;
                    mtbDataNasc.Enabled = false;

                    mtbCpf.Enabled = true;
                    ttbNome.Clear();
                    ttbRg.Clear();
                    mtbTelefone.Clear();
                    mtbCpf.Clear();
                    mtbDataNasc.Clear();
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
    

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            {
                int id = Convert.ToInt32(label8.Text);
                PessoasController exclud = new PessoasController();
                if (exclud.Excluir(id))
                {
                    MessageBox.Show("Registro excluído com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCadastrar.Enabled = false;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnValidacaoCpf.Enabled = false;
                    ttbNome.Enabled = false;
                    ttbRg.Enabled = false;
                    mtbTelefone.Enabled = false;
                    btnValidarNascimento.Enabled = false;
                    mtbDataNasc.Enabled = false;
                    resultado.Text = string.Empty;
                    resultado1.Text = string.Empty;
                    ttbNome.Clear();
                    ttbRg.Clear();
                    mtbTelefone.Clear();
                    mtbDataNasc.Clear();
                    mtbCpf.Clear();
                    btnBuscar.Enabled = true;
                    mtbCpf.Enabled = true;
                }

                else
                    MessageBox.Show("Erro ao excluir, CPF vinculado a uma Familia, favor desvincular para seguir com a exclusão!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            ttbNome.Clear();
            ttbRg.Clear();
            mtbTelefone.Clear();
            mtbDataNasc.Clear();
            mtbCpf.Clear();
            btnBuscar.Enabled = true;
            mtbCpf.Enabled = true;
            btnValidacaoCpf.Enabled = false;
            resultado.Text = string.Empty;
            resultado1.Text = string.Empty;
            btnValidarNascimento.Enabled = false;
            ttbNome.Enabled = false;
            mtbDataNasc.Enabled = false;
            mtbTelefone.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void CadastroPessoas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
