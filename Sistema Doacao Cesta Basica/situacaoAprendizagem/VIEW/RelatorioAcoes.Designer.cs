﻿
namespace situacaoAprendizagem.VIEW
{
    partial class RelatorioAcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioAcoes));
            this.dgvRelatorioAcoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioAcoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelatorioAcoes
            // 
            this.dgvRelatorioAcoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioAcoes.Location = new System.Drawing.Point(12, 12);
            this.dgvRelatorioAcoes.Name = "dgvRelatorioAcoes";
            this.dgvRelatorioAcoes.RowTemplate.Height = 25;
            this.dgvRelatorioAcoes.Size = new System.Drawing.Size(776, 426);
            this.dgvRelatorioAcoes.TabIndex = 0;
            // 
            // RelatorioAcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRelatorioAcoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioAcoes";
            this.Text = "RelatorioAcoes";
            this.Load += new System.EventHandler(this.RelatorioAcoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioAcoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorioAcoes;
    }
}