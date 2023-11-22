namespace Lib_database
{
    partial class Add_Book_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Author_TB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Publisher_TB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Genre_TB = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Year_TB = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Quantity_TB = new System.Windows.Forms.TextBox();
            this.Finish_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Name_TB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(7, 22);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(444, 22);
            this.Name_TB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Author_TB);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Author";
            // 
            // Author_TB
            // 
            this.Author_TB.Location = new System.Drawing.Point(7, 22);
            this.Author_TB.Name = "Author_TB";
            this.Author_TB.Size = new System.Drawing.Size(444, 22);
            this.Author_TB.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Publisher_TB);
            this.groupBox3.Location = new System.Drawing.Point(13, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 59);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Publisher";
            // 
            // Publisher_TB
            // 
            this.Publisher_TB.Location = new System.Drawing.Point(7, 22);
            this.Publisher_TB.Name = "Publisher_TB";
            this.Publisher_TB.Size = new System.Drawing.Size(444, 22);
            this.Publisher_TB.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Genre_TB);
            this.groupBox4.Location = new System.Drawing.Point(13, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 59);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Genre";
            // 
            // Genre_TB
            // 
            this.Genre_TB.Location = new System.Drawing.Point(7, 22);
            this.Genre_TB.Name = "Genre_TB";
            this.Genre_TB.Size = new System.Drawing.Size(444, 22);
            this.Genre_TB.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Year_TB);
            this.groupBox5.Location = new System.Drawing.Point(13, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(225, 59);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Year";
            // 
            // Year_TB
            // 
            this.Year_TB.Location = new System.Drawing.Point(7, 22);
            this.Year_TB.Name = "Year_TB";
            this.Year_TB.Size = new System.Drawing.Size(212, 22);
            this.Year_TB.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Quantity_TB);
            this.groupBox6.Location = new System.Drawing.Point(244, 273);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(225, 59);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Quantity";
            // 
            // Quantity_TB
            // 
            this.Quantity_TB.Location = new System.Drawing.Point(6, 22);
            this.Quantity_TB.Name = "Quantity_TB";
            this.Quantity_TB.Size = new System.Drawing.Size(213, 22);
            this.Quantity_TB.TabIndex = 0;
            // 
            // Finish_button
            // 
            this.Finish_button.ForeColor = System.Drawing.Color.Black;
            this.Finish_button.Location = new System.Drawing.Point(12, 339);
            this.Finish_button.Name = "Finish_button";
            this.Finish_button.Size = new System.Drawing.Size(225, 49);
            this.Finish_button.TabIndex = 4;
            this.Finish_button.Text = "ADD";
            this.Finish_button.UseVisualStyleBackColor = true;
            this.Finish_button.Click += new System.EventHandler(this.Finish_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.ForeColor = System.Drawing.Color.Black;
            this.Cancel_button.Location = new System.Drawing.Point(245, 339);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(225, 49);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "CANCEL";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Add_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 400);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Finish_button);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Name = "Add_Book_Form";
            this.Text = "ADD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Author_TB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Publisher_TB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Genre_TB;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Year_TB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox Quantity_TB;
        private System.Windows.Forms.Button Finish_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}