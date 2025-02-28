namespace LunaryRoll
{
    partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCadCli = new System.Windows.Forms.Button();
			this.buttonPesquisarCli = new System.Windows.Forms.Button();
			this.buttonFechar = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(270, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Menu Principal";
			// 
			// buttonCadCli
			// 
			this.buttonCadCli.Location = new System.Drawing.Point(244, 180);
			this.buttonCadCli.Name = "buttonCadCli";
			this.buttonCadCli.Size = new System.Drawing.Size(113, 57);
			this.buttonCadCli.TabIndex = 1;
			this.buttonCadCli.Text = "Cadastrar Cliente";
			this.buttonCadCli.UseVisualStyleBackColor = true;
			this.buttonCadCli.Click += new System.EventHandler(this.buttonCadCli_Click);
			// 
			// buttonPesquisarCli
			// 
			this.buttonPesquisarCli.Location = new System.Drawing.Point(428, 180);
			this.buttonPesquisarCli.Name = "buttonPesquisarCli";
			this.buttonPesquisarCli.Size = new System.Drawing.Size(113, 57);
			this.buttonPesquisarCli.TabIndex = 2;
			this.buttonPesquisarCli.Text = "Consultar Cliente";
			this.buttonPesquisarCli.UseVisualStyleBackColor = true;
			this.buttonPesquisarCli.Click += new System.EventHandler(this.buttonPesquisarCli_Click);
			// 
			// buttonFechar
			// 
			this.buttonFechar.Location = new System.Drawing.Point(334, 260);
			this.buttonFechar.Name = "buttonFechar";
			this.buttonFechar.Size = new System.Drawing.Size(113, 56);
			this.buttonFechar.TabIndex = 5;
			this.buttonFechar.Text = "Fechar";
			this.buttonFechar.UseVisualStyleBackColor = true;
			this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::LunaryRoll.Properties.Resources.Shikanoko_cute;
			this.pictureBox2.Location = new System.Drawing.Point(191, 88);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(82, 66);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LunaryRoll.Properties.Resources.Shikanoko_cute;
			this.pictureBox1.Location = new System.Drawing.Point(504, 88);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(82, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonFechar);
			this.Controls.Add(this.buttonPesquisarCli);
			this.Controls.Add(this.buttonCadCli);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Menu";
			this.Text = "Menu";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadCli;
        private System.Windows.Forms.Button buttonPesquisarCli;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}