namespace Project_C__User_Form_with_List
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(125, 48);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(125, 77);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(125, 106);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(125, 135);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(149, 23);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(84, 350);
            button1.Name = "button1";
            button1.Size = new Size(99, 37);
            button1.TabIndex = 4;
            button1.Text = "Open List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(212, 350);
            button2.Name = "button2";
            button2.Size = new Size(99, 37);
            button2.TabIndex = 5;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 51);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 80);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 138);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "Age";
            // 
            // button3
            // 
            button3.Location = new Point(147, 393);
            button3.Name = "button3";
            button3.Size = new Size(99, 37);
            button3.TabIndex = 10;
            button3.Text = "Edit Info";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(42, 393);
            button4.Name = "button4";
            button4.Size = new Size(99, 37);
            button4.TabIndex = 11;
            button4.Text = "Save Changes";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(252, 393);
            button5.Name = "button5";
            button5.Size = new Size(99, 37);
            button5.TabIndex = 12;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(307, 48);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(44, 23);
            textBox5.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(317, 30);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 14;
            label5.Text = "ID";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox5;
        private Label label5;
    }
}