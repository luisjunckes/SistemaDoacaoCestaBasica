
namespace situacaoAprendizagem.VIEW
{
    partial class CadastroFamilia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroFamilia));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterarF = new System.Windows.Forms.Button();
            this.ccbCidade = new System.Windows.Forms.ComboBox();
            this.ccbEstado = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ttbNomeTitular = new System.Windows.Forms.TextBox();
            this.lbNomeTitular = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbCpfTitular = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnConsultarFamilia = new System.Windows.Forms.Button();
            this.mtbVincularCpf = new System.Windows.Forms.MaskedTextBox();
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.btnExcluirIntegrante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnAlterarF);
            this.groupBox1.Controls.Add(this.ccbCidade);
            this.groupBox1.Controls.Add(this.ccbEstado);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.ttbNomeTitular);
            this.groupBox1.Controls.Add(this.lbNomeTitular);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mtbCpfTitular);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(974, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAMPO DE CADASTRO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(366, 182);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 32);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAlterarF
            // 
            this.btnAlterarF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarF.Location = new System.Drawing.Point(366, 106);
            this.btnAlterarF.Name = "btnAlterarF";
            this.btnAlterarF.Size = new System.Drawing.Size(113, 32);
            this.btnAlterarF.TabIndex = 37;
            this.btnAlterarF.Text = "Alterar";
            this.btnAlterarF.UseVisualStyleBackColor = true;
            this.btnAlterarF.Click += new System.EventHandler(this.btnAlterarF_Click);
            // 
            // ccbCidade
            // 
            this.ccbCidade.FormattingEnabled = true;
            this.ccbCidade.Location = new System.Drawing.Point(143, 141);
            this.ccbCidade.Name = "ccbCidade";
            this.ccbCidade.Size = new System.Drawing.Size(192, 23);
            this.ccbCidade.TabIndex = 36;
            // 
            // ccbEstado
            // 
            this.ccbEstado.FormattingEnabled = true;
            this.ccbEstado.Location = new System.Drawing.Point(143, 105);
            this.ccbEstado.Name = "ccbEstado";
            this.ccbEstado.Size = new System.Drawing.Size(192, 23);
            this.ccbEstado.TabIndex = 35;
            this.ccbEstado.SelectedValueChanged += new System.EventHandler(this.ccbEstado_SelectedValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(410, 231);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 15);
            this.label20.TabIndex = 34;
            this.label20.Text = "label20";
            // 
            // ttbNomeTitular
            // 
            this.ttbNomeTitular.Location = new System.Drawing.Point(143, 61);
            this.ttbNomeTitular.Name = "ttbNomeTitular";
            this.ttbNomeTitular.Size = new System.Drawing.Size(192, 23);
            this.ttbNomeTitular.TabIndex = 33;
            // 
            // lbNomeTitular
            // 
            this.lbNomeTitular.AutoSize = true;
            this.lbNomeTitular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNomeTitular.Location = new System.Drawing.Point(6, 69);
            this.lbNomeTitular.Name = "lbNomeTitular";
            this.lbNomeTitular.Size = new System.Drawing.Size(82, 15);
            this.lbNomeTitular.TabIndex = 32;
            this.lbNomeTitular.Text = "Nome Familia";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(366, 144);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 32);
            this.btnExcluir.TabIndex = 31;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(365, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 32);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(366, 61);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 32);
            this.btnCadastrar.TabIndex = 29;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "IDENTIFICAÇÃO UNICA";
            // 
            // mtbCpfTitular
            // 
            this.mtbCpfTitular.Location = new System.Drawing.Point(143, 26);
            this.mtbCpfTitular.Mask = "000000";
            this.mtbCpfTitular.Name = "mtbCpfTitular";
            this.mtbCpfTitular.Size = new System.Drawing.Size(192, 23);
            this.mtbCpfTitular.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(974, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnVincular
            // 
            this.btnVincular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVincular.Location = new System.Drawing.Point(2, 455);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(172, 27);
            this.btnVincular.TabIndex = 2;
            this.btnVincular.Text = "Vincular CPF";
            this.btnVincular.UseVisualStyleBackColor = true;
            this.btnVincular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsultarFamilia
            // 
            this.btnConsultarFamilia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarFamilia.Location = new System.Drawing.Point(2, 501);
            this.btnConsultarFamilia.Name = "btnConsultarFamilia";
            this.btnConsultarFamilia.Size = new System.Drawing.Size(172, 23);
            this.btnConsultarFamilia.TabIndex = 3;
            this.btnConsultarFamilia.Text = "Consultar Integrantes";
            this.btnConsultarFamilia.UseVisualStyleBackColor = true;
            this.btnConsultarFamilia.Click += new System.EventHandler(this.btnConsultarFamilia_Click);
            // 
            // mtbVincularCpf
            // 
            this.mtbVincularCpf.Location = new System.Drawing.Point(180, 455);
            this.mtbVincularCpf.Mask = "00000000000";
            this.mtbVincularCpf.Name = "mtbVincularCpf";
            this.mtbVincularCpf.Size = new System.Drawing.Size(192, 23);
            this.mtbVincularCpf.TabIndex = 39;
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Location = new System.Drawing.Point(2, 530);
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.RowTemplate.Height = 25;
            this.dgvIntegrantes.Size = new System.Drawing.Size(974, 150);
            this.dgvIntegrantes.TabIndex = 40;
            this.dgvIntegrantes.DoubleClick += new System.EventHandler(this.dgvIntegrantes_DoubleClick);
            // 
            // btnExcluirIntegrante
            // 
            this.btnExcluirIntegrante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirIntegrante.Location = new System.Drawing.Point(180, 501);
            this.btnExcluirIntegrante.Name = "btnExcluirIntegrante";
            this.btnExcluirIntegrante.Size = new System.Drawing.Size(172, 23);
            this.btnExcluirIntegrante.TabIndex = 41;
            this.btnExcluirIntegrante.Text = "Excluir Integrante";
            this.btnExcluirIntegrante.UseVisualStyleBackColor = true;
            this.btnExcluirIntegrante.Click += new System.EventHandler(this.btnExcluirIntegrante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(395, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Lista de Famílias Cadastradas";
            // 
            // CadastroFamilia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirIntegrante);
            this.Controls.Add(this.dgvIntegrantes);
            this.Controls.Add(this.mtbVincularCpf);
            this.Controls.Add(this.btnConsultarFamilia);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroFamilia";
            this.Text = "CadastroFamilia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtbCpfTitular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox ttbNomeTitular;
        private System.Windows.Forms.Label lbNomeTitular;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox ccbCidade;
        private System.Windows.Forms.ComboBox ccbEstado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAlterarF;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnConsultarFamilia;
        private System.Windows.Forms.MaskedTextBox mtbVincularCpf;
        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Button btnExcluirIntegrante;
        private System.Windows.Forms.Label label1;
    }
}