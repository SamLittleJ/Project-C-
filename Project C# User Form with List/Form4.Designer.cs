namespace Project_C__User_Form_with_List
{
    partial class Form4
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(70, 209);
            button1.Name = "button1";
            button1.Size = new Size(93, 37);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(209, 210);
            button2.Name = "button2";
            button2.Size = new Size(93, 37);
            button2.TabIndex = 2;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(352, 210);
            button3.Name = "button3";
            button3.Size = new Size(93, 37);
            button3.TabIndex = 3;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(119, 282);
            button4.Name = "button4";
            button4.Size = new Size(93, 37);
            button4.TabIndex = 4;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(298, 282);
            button5.Name = "button5";
            button5.Size = new Size(93, 37);
            button5.TabIndex = 5;
            button5.Text = "Load";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(209, 344);
            button6.Name = "button6";
            button6.Size = new Size(93, 37);
            button6.TabIndex = 6;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(70, 35);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(375, 148);
            checkedListBox1.TabIndex = 7;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private CheckedListBox checkedListBox1;
    }
}