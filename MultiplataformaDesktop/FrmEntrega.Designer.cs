﻿namespace MultiplataformaDesktop
{
    partial class FrmEntrega
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEpi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFuncionario = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxLocalizar = new System.Windows.Forms.Button();
            this.mkEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            this.pbxExcluir = new System.Windows.Forms.PictureBox();
            this.pbxEditar = new System.Windows.Forms.PictureBox();
            this.pbxInserir = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.dgvEntrega = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInserir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "EPI";
            // 
            // cbxEpi
            // 
            this.cbxEpi.FormattingEnabled = true;
            this.cbxEpi.Location = new System.Drawing.Point(39, 138);
            this.cbxEpi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxEpi.Name = "cbxEpi";
            this.cbxEpi.Size = new System.Drawing.Size(381, 21);
            this.cbxEpi.TabIndex = 17;
            this.cbxEpi.SelectedIndexChanged += new System.EventHandler(this.cbxEpi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "FUNCIONÁRIO";
            // 
            // cbxFuncionario
            // 
            this.cbxFuncionario.FormattingEnabled = true;
            this.cbxFuncionario.Location = new System.Drawing.Point(40, 87);
            this.cbxFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.cbxFuncionario.Name = "cbxFuncionario";
            this.cbxFuncionario.Size = new System.Drawing.Size(381, 21);
            this.cbxFuncionario.TabIndex = 15;
            this.cbxFuncionario.SelectedIndexChanged += new System.EventHandler(this.cbxFuncionario_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(40, 32);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // pbxLocalizar
            // 
            this.pbxLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.pbxLocalizar.BackgroundImage = global::MultiplataformaDesktop.Properties.Resources.localizar;
            this.pbxLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pbxLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pbxLocalizar.Location = new System.Drawing.Point(169, 11);
            this.pbxLocalizar.Margin = new System.Windows.Forms.Padding(2);
            this.pbxLocalizar.Name = "pbxLocalizar";
            this.pbxLocalizar.Size = new System.Drawing.Size(58, 55);
            this.pbxLocalizar.TabIndex = 12;
            this.pbxLocalizar.UseVisualStyleBackColor = false;
            this.pbxLocalizar.Click += new System.EventHandler(this.pbxLocalizar_Click);
            // 
            // mkEntrega
            // 
            this.mkEntrega.Location = new System.Drawing.Point(39, 259);
            this.mkEntrega.Mask = "00/00/0000";
            this.mkEntrega.Name = "mkEntrega";
            this.mkEntrega.Size = new System.Drawing.Size(154, 20);
            this.mkEntrega.TabIndex = 82;
            this.mkEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "ENTREGA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 18);
            this.label6.TabIndex = 83;
            this.label6.Text = "VALIDADE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(873, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 93;
            this.label7.Text = "SAIR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(856, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 92;
            this.label8.Text = "EXCLUIR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(861, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 18);
            this.label9.TabIndex = 91;
            this.label9.Text = "EDITAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(856, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 90;
            this.label10.Text = "INSERIR";
            // 
            // pbxSair
            // 
            this.pbxSair.BackColor = System.Drawing.Color.Transparent;
            this.pbxSair.Image = global::MultiplataformaDesktop.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(850, 409);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(85, 71);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 89;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // pbxExcluir
            // 
            this.pbxExcluir.BackColor = System.Drawing.Color.Transparent;
            this.pbxExcluir.Image = global::MultiplataformaDesktop.Properties.Resources.excluir;
            this.pbxExcluir.Location = new System.Drawing.Point(850, 290);
            this.pbxExcluir.Name = "pbxExcluir";
            this.pbxExcluir.Size = new System.Drawing.Size(85, 71);
            this.pbxExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxExcluir.TabIndex = 88;
            this.pbxExcluir.TabStop = false;
            this.pbxExcluir.Click += new System.EventHandler(this.pbxExcluir_Click);
            // 
            // pbxEditar
            // 
            this.pbxEditar.BackColor = System.Drawing.Color.Transparent;
            this.pbxEditar.Image = global::MultiplataformaDesktop.Properties.Resources.editar;
            this.pbxEditar.Location = new System.Drawing.Point(850, 173);
            this.pbxEditar.Name = "pbxEditar";
            this.pbxEditar.Size = new System.Drawing.Size(85, 71);
            this.pbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEditar.TabIndex = 87;
            this.pbxEditar.TabStop = false;
            this.pbxEditar.Click += new System.EventHandler(this.pbxEditar_Click);
            // 
            // pbxInserir
            // 
            this.pbxInserir.BackColor = System.Drawing.Color.Transparent;
            this.pbxInserir.Image = global::MultiplataformaDesktop.Properties.Resources.adicionar;
            this.pbxInserir.Location = new System.Drawing.Point(850, 49);
            this.pbxInserir.Name = "pbxInserir";
            this.pbxInserir.Size = new System.Drawing.Size(85, 71);
            this.pbxInserir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxInserir.TabIndex = 86;
            this.pbxInserir.TabStop = false;
            this.pbxInserir.Click += new System.EventHandler(this.pbxInserir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(38, 172);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 18);
            this.label11.TabIndex = 94;
            this.label11.Text = "MATRICULA";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.BackColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.ForeColor = System.Drawing.Color.Transparent;
            this.lblMatricula.Location = new System.Drawing.Point(39, 199);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(0, 18);
            this.lblMatricula.TabIndex = 95;
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.ForeColor = System.Drawing.Color.Transparent;
            this.lblValidade.Location = new System.Drawing.Point(35, 327);
            this.lblValidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(0, 18);
            this.lblValidade.TabIndex = 96;
            // 
            // dgvEntrega
            // 
            this.dgvEntrega.AllowUserToAddRows = false;
            this.dgvEntrega.AllowUserToDeleteRows = false;
            this.dgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrega.Location = new System.Drawing.Point(37, 389);
            this.dgvEntrega.Name = "dgvEntrega";
            this.dgvEntrega.ReadOnly = true;
            this.dgvEntrega.Size = new System.Drawing.Size(752, 170);
            this.dgvEntrega.TabIndex = 97;
            this.dgvEntrega.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntrega_CellClick);
            // 
            // FrmEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiplataformaDesktop.Properties.Resources.abstract_golden_lines_luxury_dark_black_background_design_402533_1196;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 571);
            this.Controls.Add(this.dgvEntrega);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.pbxExcluir);
            this.Controls.Add(this.pbxEditar);
            this.Controls.Add(this.pbxInserir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mkEntrega);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxEpi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFuncionario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxLocalizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTIPLATAFORMA - DESKTOP";
            this.Load += new System.EventHandler(this.FrmEntrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInserir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEpi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFuncionario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pbxLocalizar;
        private System.Windows.Forms.MaskedTextBox mkEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbxSair;
        private System.Windows.Forms.PictureBox pbxExcluir;
        private System.Windows.Forms.PictureBox pbxEditar;
        private System.Windows.Forms.PictureBox pbxInserir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.DataGridView dgvEntrega;
    }
}