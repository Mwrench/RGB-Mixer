namespace RGB_Mixer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Slidervermelho = new System.Windows.Forms.TrackBar();
            this.Sliderverde = new System.Windows.Forms.TrackBar();
            this.Sliderazul = new System.Windows.Forms.TrackBar();
            this.Ajuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slidervermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sliderverde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sliderazul)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(21, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(21, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 77);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(21, 217);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 77);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(560, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(217, 319);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // Slidervermelho
            // 
            this.Slidervermelho.BackColor = System.Drawing.Color.Red;
            this.Slidervermelho.Location = new System.Drawing.Point(233, 38);
            this.Slidervermelho.Maximum = 255;
            this.Slidervermelho.Name = "Slidervermelho";
            this.Slidervermelho.Size = new System.Drawing.Size(265, 45);
            this.Slidervermelho.TabIndex = 4;
            this.Slidervermelho.Scroll += new System.EventHandler(this.Slidervermelho_Scroll);
            // 
            // Sliderverde
            // 
            this.Sliderverde.BackColor = System.Drawing.Color.Lime;
            this.Sliderverde.Location = new System.Drawing.Point(233, 137);
            this.Sliderverde.Maximum = 255;
            this.Sliderverde.Name = "Sliderverde";
            this.Sliderverde.Size = new System.Drawing.Size(265, 45);
            this.Sliderverde.TabIndex = 5;
            this.Sliderverde.Scroll += new System.EventHandler(this.Sliderverde_Scroll);
            // 
            // Sliderazul
            // 
            this.Sliderazul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Sliderazul.Location = new System.Drawing.Point(233, 232);
            this.Sliderazul.Maximum = 255;
            this.Sliderazul.Name = "Sliderazul";
            this.Sliderazul.Size = new System.Drawing.Size(265, 45);
            this.Sliderazul.TabIndex = 6;
            this.Sliderazul.Scroll += new System.EventHandler(this.Sliderazul_Scroll);
            // 
            // Ajuda
            // 
            this.Ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ajuda.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajuda.Location = new System.Drawing.Point(21, 316);
            this.Ajuda.Name = "Ajuda";
            this.Ajuda.Size = new System.Drawing.Size(126, 28);
            this.Ajuda.TabIndex = 7;
            this.Ajuda.Text = "Ajuda";
            this.Ajuda.UseVisualStyleBackColor = true;
            this.Ajuda.Click += new System.EventHandler(this.Ajuda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.Ajuda);
            this.Controls.Add(this.Sliderazul);
            this.Controls.Add(this.Sliderverde);
            this.Controls.Add(this.Slidervermelho);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RGB Mixer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slidervermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sliderverde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sliderazul)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TrackBar Slidervermelho;
        private System.Windows.Forms.TrackBar Sliderverde;
        private System.Windows.Forms.TrackBar Sliderazul;
        private System.Windows.Forms.Button Ajuda;
    }
}

