
namespace VucutKitleIndeksHesaplama
{
    partial class CinsiyetSecimEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinsiyetSecimEkrani));
            this.pcbxWoman = new System.Windows.Forms.PictureBox();
            this.pcbxMan = new System.Windows.Forms.PictureBox();
            this.labelasd1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxWoman
            // 
            this.pcbxWoman.Image = ((System.Drawing.Image)(resources.GetObject("pcbxWoman.Image")));
            this.pcbxWoman.Location = new System.Drawing.Point(86, 75);
            this.pcbxWoman.Name = "pcbxWoman";
            this.pcbxWoman.Size = new System.Drawing.Size(105, 263);
            this.pcbxWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxWoman.TabIndex = 0;
            this.pcbxWoman.TabStop = false;
            this.pcbxWoman.Click += new System.EventHandler(this.pcbxWoman_Click);
            // 
            // pcbxMan
            // 
            this.pcbxMan.Image = ((System.Drawing.Image)(resources.GetObject("pcbxMan.Image")));
            this.pcbxMan.Location = new System.Drawing.Point(215, 75);
            this.pcbxMan.Name = "pcbxMan";
            this.pcbxMan.Size = new System.Drawing.Size(105, 263);
            this.pcbxMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxMan.TabIndex = 1;
            this.pcbxMan.TabStop = false;
            this.pcbxMan.Click += new System.EventHandler(this.pcbxMan_Click);
            // 
            // labelasd1
            // 
            this.labelasd1.AutoSize = true;
            this.labelasd1.Location = new System.Drawing.Point(66, 346);
            this.labelasd1.Name = "labelasd1";
            this.labelasd1.Size = new System.Drawing.Size(274, 13);
            this.labelasd1.TabIndex = 2;
            this.labelasd1.Text = "( Cinsiyetinizi seçmek için resimlerden birine dokununuz. )";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(365, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(86, 52);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(52, 17);
            this.radioButtonWoman.TabIndex = 5;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Kadın";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(215, 52);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(53, 17);
            this.radioButtonMan.TabIndex = 6;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Erkek";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(83, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "VÜCUT KİTLE İNDEKSİ HESAPLAMA\r\n";
            // 
            // CinsiyetSecimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 369);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelasd1);
            this.Controls.Add(this.pcbxMan);
            this.Controls.Add(this.pcbxWoman);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CinsiyetSecimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CinsiyetSecimEkrani";
            this.Load += new System.EventHandler(this.CinsiyetSecimEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxWoman;
        private System.Windows.Forms.PictureBox pcbxMan;
        private System.Windows.Forms.Label labelasd1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.Label label5;
    }
}