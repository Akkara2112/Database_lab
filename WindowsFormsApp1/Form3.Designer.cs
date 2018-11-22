namespace WindowsFormsApp1
{
    partial class Form3
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
            this.cbNameTb = new System.Windows.Forms.ComboBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb6 = new System.Windows.Forms.ComboBox();
            this.cb5 = new System.Windows.Forms.ComboBox();
            this.cb4 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbNameTb
            // 
            this.cbNameTb.FormattingEnabled = true;
            this.cbNameTb.Location = new System.Drawing.Point(29, 12);
            this.cbNameTb.Name = "cbNameTb";
            this.cbNameTb.Size = new System.Drawing.Size(121, 21);
            this.cbNameTb.TabIndex = 0;
            this.cbNameTb.SelectedIndexChanged += new System.EventHandler(this.cbNameTb_SelectedIndexChanged);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(29, 116);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 20);
            this.tb1.TabIndex = 1;
            this.tb1.Visible = false;
            this.tb1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb1_KeyPress);
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(29, 56);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(73, 21);
            this.cb1.TabIndex = 2;
            this.cb1.Visible = false;
            // 
            // cb6
            // 
            this.cb6.FormattingEnabled = true;
            this.cb6.Location = new System.Drawing.Point(424, 56);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(73, 21);
            this.cb6.TabIndex = 3;
            this.cb6.Visible = false;
            // 
            // cb5
            // 
            this.cb5.FormattingEnabled = true;
            this.cb5.Location = new System.Drawing.Point(345, 56);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(73, 21);
            this.cb5.TabIndex = 4;
            this.cb5.Visible = false;
            // 
            // cb4
            // 
            this.cb4.FormattingEnabled = true;
            this.cb4.Location = new System.Drawing.Point(266, 56);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(73, 21);
            this.cb4.TabIndex = 5;
            this.cb4.Visible = false;
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(187, 56);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(73, 21);
            this.cb3.TabIndex = 6;
            this.cb3.Visible = false;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(108, 56);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(73, 21);
            this.cb2.TabIndex = 7;
            this.cb2.Visible = false;
            // 
            // datetime
            // 
            this.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime.Location = new System.Drawing.Point(29, 155);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 8;
            this.datetime.Visible = false;
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(347, 116);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(100, 20);
            this.tb4.TabIndex = 9;
            this.tb4.Visible = false;
            this.tb4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(241, 116);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(100, 20);
            this.tb3.TabIndex = 10;
            this.tb3.Visible = false;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(135, 116);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 20);
            this.tb2.TabIndex = 11;
            this.tb2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выберите данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введите данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Выберите дату";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(245, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "label7";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 212);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb5);
            this.Controls.Add(this.cb6);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.cbNameTb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNameTb;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb6;
        private System.Windows.Forms.ComboBox cb5;
        private System.Windows.Forms.ComboBox cb4;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}