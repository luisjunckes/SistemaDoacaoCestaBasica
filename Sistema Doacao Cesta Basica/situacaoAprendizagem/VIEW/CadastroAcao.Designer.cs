
namespace situacaoAprendizagem.VIEW
{
    partial class CadastroAcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroAcao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ccbEstado = new System.Windows.Forms.ComboBox();
            this.ccbCidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttbNomeAcao = new System.Windows.Forms.TextBox();
            this.dtpDtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDtFim = new System.Windows.Forms.DateTimePicker();
            this.btnCadatrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.datagridview2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.mtbIdAcao = new System.Windows.Forms.MaskedTextBox();
            this.btnVincularFamilia = new System.Windows.Forms.Button();
            this.mtbVincularFamilia = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultarFamilia = new System.Windows.Forms.Button();
            this.btnExcluirFamilia = new System.Windows.Forms.Button();
            this.rdbCodFam = new System.Windows.Forms.RadioButton();
            this.rdbCpfIntegrante = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Ação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Fim";
            // 
            // ccbEstado
            // 
            this.ccbEstado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ccbEstado.FormattingEnabled = true;
            this.ccbEstado.Location = new System.Drawing.Point(155, 143);
            this.ccbEstado.Name = "ccbEstado";
            this.ccbEstado.Size = new System.Drawing.Size(192, 25);
            this.ccbEstado.TabIndex = 3;
            this.ccbEstado.SelectedValueChanged += new System.EventHandler(this.ccbEstado_SelectedValueChanged);
            // 
            // ccbCidade
            // 
            this.ccbCidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ccbCidade.FormattingEnabled = true;
            this.ccbCidade.Location = new System.Drawing.Point(155, 174);
            this.ccbCidade.Name = "ccbCidade";
            this.ccbCidade.Size = new System.Drawing.Size(192, 25);
            this.ccbCidade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cidade";
            // 
            // ttbNomeAcao
            // 
            this.ttbNomeAcao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ttbNomeAcao.Location = new System.Drawing.Point(155, 50);
            this.ttbNomeAcao.Name = "ttbNomeAcao";
            this.ttbNomeAcao.Size = new System.Drawing.Size(208, 25);
            this.ttbNomeAcao.TabIndex = 7;
            // 
            // dtpDtInicio
            // 
            this.dtpDtInicio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDtInicio.Location = new System.Drawing.Point(155, 81);
            this.dtpDtInicio.Name = "dtpDtInicio";
            this.dtpDtInicio.Size = new System.Drawing.Size(282, 25);
            this.dtpDtInicio.TabIndex = 8;
            // 
            // dtpDtFim
            // 
            this.dtpDtFim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDtFim.Location = new System.Drawing.Point(155, 112);
            this.dtpDtFim.Name = "dtpDtFim";
            this.dtpDtFim.Size = new System.Drawing.Size(282, 25);
            this.dtpDtFim.TabIndex = 9;
            // 
            // btnCadatrar
            // 
            this.btnCadatrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadatrar.Location = new System.Drawing.Point(40, 339);
            this.btnCadatrar.Name = "btnCadatrar";
            this.btnCadatrar.Size = new System.Drawing.Size(90, 35);
            this.btnCadatrar.TabIndex = 10;
            this.btnCadatrar.Text = "Cadastrar";
            this.btnCadatrar.UseVisualStyleBackColor = true;
            this.btnCadatrar.Click += new System.EventHandler(this.btnCadatrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.Location = new System.Drawing.Point(146, 298);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(85, 35);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(146, 339);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 35);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(250, 298);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 35);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // datagridview2
            // 
            this.datagridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview2.Location = new System.Drawing.Point(455, 12);
            this.datagridview2.Name = "datagridview2";
            this.datagridview2.RowTemplate.Height = 25;
            this.datagridview2.Size = new System.Drawing.Size(780, 180);
            this.datagridview2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID Ação";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.Location = new System.Drawing.Point(40, 298);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 35);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(393, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 15);
            this.label21.TabIndex = 18;
            this.label21.Text = "label21";
            // 
            // mtbIdAcao
            // 
            this.mtbIdAcao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbIdAcao.Location = new System.Drawing.Point(155, 19);
            this.mtbIdAcao.Mask = "00000";
            this.mtbIdAcao.Name = "mtbIdAcao";
            this.mtbIdAcao.Size = new System.Drawing.Size(208, 25);
            this.mtbIdAcao.TabIndex = 19;
            this.mtbIdAcao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVincularFamilia
            // 
            this.btnVincularFamilia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVincularFamilia.Location = new System.Drawing.Point(726, 198);
            this.btnVincularFamilia.Name = "btnVincularFamilia";
            this.btnVincularFamilia.Size = new System.Drawing.Size(154, 23);
            this.btnVincularFamilia.TabIndex = 20;
            this.btnVincularFamilia.Text = "Liberar Beneficio";
            this.btnVincularFamilia.UseVisualStyleBackColor = true;
            this.btnVincularFamilia.Click += new System.EventHandler(this.btnVincularFamilia_Click);
            // 
            // mtbVincularFamilia
            // 
            this.mtbVincularFamilia.Location = new System.Drawing.Point(573, 197);
            this.mtbVincularFamilia.Mask = "00000";
            this.mtbVincularFamilia.Name = "mtbVincularFamilia";
            this.mtbVincularFamilia.Size = new System.Drawing.Size(147, 23);
            this.mtbVincularFamilia.TabIndex = 21;
            this.mtbVincularFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(780, 183);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConsultarFamilia
            // 
            this.btnConsultarFamilia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarFamilia.Location = new System.Drawing.Point(455, 298);
            this.btnConsultarFamilia.Name = "btnConsultarFamilia";
            this.btnConsultarFamilia.Size = new System.Drawing.Size(172, 23);
            this.btnConsultarFamilia.TabIndex = 23;
            this.btnConsultarFamilia.Text = "Consultar Familias ";
            this.btnConsultarFamilia.UseVisualStyleBackColor = true;
            this.btnConsultarFamilia.Click += new System.EventHandler(this.btnConsultarFamilia_Click);
            // 
            // btnExcluirFamilia
            // 
            this.btnExcluirFamilia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirFamilia.Location = new System.Drawing.Point(633, 298);
            this.btnExcluirFamilia.Name = "btnExcluirFamilia";
            this.btnExcluirFamilia.Size = new System.Drawing.Size(172, 23);
            this.btnExcluirFamilia.TabIndex = 24;
            this.btnExcluirFamilia.Text = "Desvincular Familia";
            this.btnExcluirFamilia.UseVisualStyleBackColor = true;
            this.btnExcluirFamilia.Click += new System.EventHandler(this.btnExcluirFamilia_Click);
            // 
            // rdbCodFam
            // 
            this.rdbCodFam.AutoSize = true;
            this.rdbCodFam.Location = new System.Drawing.Point(455, 198);
            this.rdbCodFam.Name = "rdbCodFam";
            this.rdbCodFam.Size = new System.Drawing.Size(105, 19);
            this.rdbCodFam.TabIndex = 26;
            this.rdbCodFam.TabStop = true;
            this.rdbCodFam.Text = "Código Familia";
            this.rdbCodFam.UseVisualStyleBackColor = true;
            this.rdbCodFam.CheckedChanged += new System.EventHandler(this.rdbCodFam_CheckedChanged);
            // 
            // rdbCpfIntegrante
            // 
            this.rdbCpfIntegrante.AutoSize = true;
            this.rdbCpfIntegrante.Location = new System.Drawing.Point(455, 219);
            this.rdbCpfIntegrante.Name = "rdbCpfIntegrante";
            this.rdbCpfIntegrante.Size = new System.Drawing.Size(103, 19);
            this.rdbCpfIntegrante.TabIndex = 27;
            this.rdbCpfIntegrante.TabStop = true;
            this.rdbCpfIntegrante.Text = "CPF Integrante";
            this.rdbCpfIntegrante.UseVisualStyleBackColor = true;
            this.rdbCpfIntegrante.CheckedChanged += new System.EventHandler(this.rdbCpfIntegrante_CheckedChanged);
            // 
            // CadastroAcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 522);
            this.Controls.Add(this.rdbCpfIntegrante);
            this.Controls.Add(this.rdbCodFam);
            this.Controls.Add(this.btnExcluirFamilia);
            this.Controls.Add(this.btnConsultarFamilia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mtbVincularFamilia);
            this.Controls.Add(this.btnVincularFamilia);
            this.Controls.Add(this.mtbIdAcao);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datagridview2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCadatrar);
            this.Controls.Add(this.dtpDtFim);
            this.Controls.Add(this.dtpDtInicio);
            this.Controls.Add(this.ttbNomeAcao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ccbCidade);
            this.Controls.Add(this.ccbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroAcao";
            this.Text = "CadastroAcao";
            this.Load += new System.EventHandler(this.CadastroAcao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ccbEstado;
        private System.Windows.Forms.ComboBox ccbCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttbNomeAcao;
        private System.Windows.Forms.DateTimePicker dtpDtInicio;
        private System.Windows.Forms.DateTimePicker dtpDtFim;
        private System.Windows.Forms.Button btnCadatrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView datagridview2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox mtbIdAcao;
        private System.Windows.Forms.Button btnVincularFamilia;
        private System.Windows.Forms.MaskedTextBox mtbVincularFamilia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsultarFamilia;
        private System.Windows.Forms.Button btnExcluirFamilia;
        private System.Windows.Forms.RadioButton rdbCodFam;
        private System.Windows.Forms.RadioButton rdbCpfIntegrante;
    }
}