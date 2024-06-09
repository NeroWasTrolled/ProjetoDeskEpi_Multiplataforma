namespace MultiplataformaDesktop
{
    partial class FrmRegistro
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbxLocalizar = new System.Windows.Forms.PictureBox();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pbxSair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocalizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(31, 56);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(74, 20);
            this.txtMatricula.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 68;
            this.label8.Text = "MATRICULA";
            // 
            // pbxLocalizar
            // 
            this.pbxLocalizar.BackColor = System.Drawing.Color.Transparent;
            this.pbxLocalizar.Image = global::MultiplataformaDesktop.Properties.Resources.localizar;
            this.pbxLocalizar.Location = new System.Drawing.Point(146, 23);
            this.pbxLocalizar.Name = "pbxLocalizar";
            this.pbxLocalizar.Size = new System.Drawing.Size(85, 71);
            this.pbxLocalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLocalizar.TabIndex = 70;
            this.pbxLocalizar.TabStop = false;
            this.pbxLocalizar.Click += new System.EventHandler(this.pbxLocalizar_Click);
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AllowUserToDeleteRows = false;
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregas.Location = new System.Drawing.Point(31, 123);
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.ReadOnly = true;
            this.dgvEntregas.Size = new System.Drawing.Size(741, 206);
            this.dgvEntregas.TabIndex = 71;
            this.dgvEntregas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntregas_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(710, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "SAIR";
            // 
            // pbxSair
            // 
            this.pbxSair.BackColor = System.Drawing.Color.Transparent;
            this.pbxSair.Image = global::MultiplataformaDesktop.Properties.Resources.sair;
            this.pbxSair.Location = new System.Drawing.Point(687, 349);
            this.pbxSair.Name = "pbxSair";
            this.pbxSair.Size = new System.Drawing.Size(85, 71);
            this.pbxSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSair.TabIndex = 72;
            this.pbxSair.TabStop = false;
            this.pbxSair.Click += new System.EventHandler(this.pbxSair_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::MultiplataformaDesktop.Properties.Resources.OIP;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbxSair);
            this.Controls.Add(this.dgvEntregas);
            this.Controls.Add(this.pbxLocalizar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MULTIPLATAFORMA - DESKTOP";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLocalizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbxLocalizar;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbxSair;
    }
}