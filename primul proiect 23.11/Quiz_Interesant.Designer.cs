
namespace primul_proiect_23._11
{
    partial class Quiz_Interesant
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l1 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::primul_proiect_23._11.Properties.Resources.q1;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(735, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // l1
            // 
            this.l1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l1.Location = new System.Drawing.Point(12, 320);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(741, 60);
            this.l1.TabIndex = 1;
            this.l1.Text = "Intrebare";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(18, 383);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(288, 50);
            this.b1.TabIndex = 2;
            this.b1.Tag = "1";
            this.b1.Text = "button1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.Check);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(18, 449);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(288, 50);
            this.b2.TabIndex = 3;
            this.b2.Tag = "2";
            this.b2.Text = "button2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.Check);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(465, 449);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(288, 50);
            this.b3.TabIndex = 5;
            this.b3.Tag = "3";
            this.b3.Text = "button3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.Check);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(465, 383);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(288, 50);
            this.b4.TabIndex = 4;
            this.b4.Tag = "4";
            this.b4.Text = "button4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.Check);
            // 
            // Quiz_Interesant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 523);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Quiz_Interesant";
            this.Text = "Quiz_Interesant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
    }
}