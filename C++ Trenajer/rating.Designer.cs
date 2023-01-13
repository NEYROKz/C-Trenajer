namespace C___Trenajer
{
    partial class rating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rating));
            this.namestudent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.firstgrade_label = new System.Windows.Forms.Label();
            this.secondgrade_label = new System.Windows.Forms.Label();
            this.thirdgrade_label = new System.Windows.Forms.Label();
            this.fourthgrade_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namestudent
            // 
            this.namestudent.AutoSize = true;
            this.namestudent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namestudent.Location = new System.Drawing.Point(12, 18);
            this.namestudent.Name = "namestudent";
            this.namestudent.Size = new System.Drawing.Size(50, 23);
            this.namestudent.TabIndex = 0;
            this.namestudent.Text = "Имя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задание 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Задание 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Задание 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Задание 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(266, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // firstgrade_label
            // 
            this.firstgrade_label.AutoSize = true;
            this.firstgrade_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.firstgrade_label.Location = new System.Drawing.Point(113, 52);
            this.firstgrade_label.Name = "firstgrade_label";
            this.firstgrade_label.Size = new System.Drawing.Size(0, 23);
            this.firstgrade_label.TabIndex = 8;
            // 
            // secondgrade_label
            // 
            this.secondgrade_label.AutoSize = true;
            this.secondgrade_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.secondgrade_label.Location = new System.Drawing.Point(113, 89);
            this.secondgrade_label.Name = "secondgrade_label";
            this.secondgrade_label.Size = new System.Drawing.Size(38, 23);
            this.secondgrade_label.TabIndex = 9;
            this.secondgrade_label.Text = "0/1";
            // 
            // thirdgrade_label
            // 
            this.thirdgrade_label.AutoSize = true;
            this.thirdgrade_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.thirdgrade_label.Location = new System.Drawing.Point(113, 125);
            this.thirdgrade_label.Name = "thirdgrade_label";
            this.thirdgrade_label.Size = new System.Drawing.Size(38, 23);
            this.thirdgrade_label.TabIndex = 10;
            this.thirdgrade_label.Text = "0/1";
            // 
            // fourthgrade_label
            // 
            this.fourthgrade_label.AutoSize = true;
            this.fourthgrade_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.fourthgrade_label.Location = new System.Drawing.Point(113, 160);
            this.fourthgrade_label.Name = "fourthgrade_label";
            this.fourthgrade_label.Size = new System.Drawing.Size(38, 23);
            this.fourthgrade_label.TabIndex = 11;
            this.fourthgrade_label.Text = "0/1";
            // 
            // rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 205);
            this.Controls.Add(this.fourthgrade_label);
            this.Controls.Add(this.thirdgrade_label);
            this.Controls.Add(this.secondgrade_label);
            this.Controls.Add(this.firstgrade_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namestudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C++";
            this.Load += new System.EventHandler(this.rating_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rating_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namestudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label firstgrade_label;
        private System.Windows.Forms.Label secondgrade_label;
        private System.Windows.Forms.Label thirdgrade_label;
        private System.Windows.Forms.Label fourthgrade_label;
    }
}