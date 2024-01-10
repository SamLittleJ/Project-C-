namespace Project_C__User_Form_with_List
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox4 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 55);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 113);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Email";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 142);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Password";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 2;
            textBox3.Click += textBox3_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.ControlLightLight;
            dateTimePicker1.Location = new Point(90, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(90, 200);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(90, 246);
            button1.Name = "button1";
            button1.Size = new Size(200, 35);
            button1.TabIndex = 5;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(90, 403);
            button2.Name = "button2";
            button2.Size = new Size(200, 35);
            button2.TabIndex = 6;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 385);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 7;
            label1.Text = "Already have an account?";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(90, 171);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Confirm Password";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 8;
            textBox4.Enter += textBox4_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 22);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Unknown";
            label2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox4;
        private Label label2;
    }
}