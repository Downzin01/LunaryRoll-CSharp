namespace LunaryRoll
{
    partial class ConsultaCli
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCli));
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.buttonConsulta = new System.Windows.Forms.Button();
			this.buttonExcluir = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvClientes
			// 
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Location = new System.Drawing.Point(84, 23);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.Size = new System.Drawing.Size(641, 336);
			this.dgvClientes.TabIndex = 0;
			// 
			// buttonConsulta
			// 
			this.buttonConsulta.Location = new System.Drawing.Point(503, 375);
			this.buttonConsulta.Name = "buttonConsulta";
			this.buttonConsulta.Size = new System.Drawing.Size(98, 48);
			this.buttonConsulta.TabIndex = 1;
			this.buttonConsulta.Text = "Consultar Clientes";
			this.buttonConsulta.UseVisualStyleBackColor = true;
			this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
			// 
			// buttonExcluir
			// 
			this.buttonExcluir.Location = new System.Drawing.Point(627, 375);
			this.buttonExcluir.Name = "buttonExcluir";
			this.buttonExcluir.Size = new System.Drawing.Size(98, 48);
			this.buttonExcluir.TabIndex = 2;
			this.buttonExcluir.Text = "Excluir Clientes";
			this.buttonExcluir.UseVisualStyleBackColor = true;
			this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(21, 23);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(47, 49);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 5;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// ConsultaCli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.buttonExcluir);
			this.Controls.Add(this.buttonConsulta);
			this.Controls.Add(this.dgvClientes);
			this.Name = "ConsultaCli";
			this.Text = "ConsultaCli";
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}