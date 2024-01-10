using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.OleDb;
using System.Drawing.Imaging;

namespace Project_C__User_Form_with_List
{
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ciura\OneDrive - UNIVERSITATEA ROMANO-AMERICANA\Documents\dbforC.accdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            textBox3.PasswordChar = '*';

            if (checkBox1.Checked)
                textBox3.PasswordChar = '\0';
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            textBox4.PasswordChar = '*';

            if (checkBox1.Checked)
                textBox4.PasswordChar = '\0';
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = '\0';
                textBox4.PasswordChar = '\0';
            }
            else
            {
                textBox3.PasswordChar = '*';
                textBox4.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "Username")
                textBox1.BackColor = Color.PaleVioletRed;
            else
                textBox1.BackColor = Color.White;

            if (textBox2.Text == "" || textBox2.Text == "Email")
                textBox2.BackColor = Color.PaleVioletRed;
            else if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(textBox2.Text))
                    textBox2.BackColor = Color.PaleVioletRed;
                else
                    textBox2.BackColor = Color.White;
            }

            if (textBox3.Text == "" || textBox3.Text == "Password")
                textBox3.BackColor = Color.PaleVioletRed;
            else if (textBox3.Text.Length > 8 && textBox3.Text.Any(char.IsUpper) && textBox3.Text.Any(char.IsLower))
                textBox3.BackColor = Color.White;
            else
                textBox3.BackColor = Color.PaleVioletRed;

            if (textBox4.Text != textBox3.Text)
                textBox4.BackColor = Color.PaleVioletRed;
            else
                textBox4.BackColor = Color.White;

            if (textBox1.BackColor == Color.White && textBox2.BackColor == Color.White && textBox3.BackColor == Color.White && textBox4.BackColor == Color.White)
            {
                try
                {
                    con.Open();

                    // Check if the Username already exists
                    OleDbCommand checkUsernameCmd = new OleDbCommand("SELECT COUNT(*) FROM listofUsers WHERE [Username] = @Username", con);
                    checkUsernameCmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());

                    // Check if the Email already exists
                    OleDbCommand checkEmailCmd = new OleDbCommand("SELECT COUNT(*) FROM listofUsers WHERE [Email] = @Email", con);
                    checkEmailCmd.Parameters.AddWithValue("@Email", textBox2.Text);
                    int emailCount = Convert.ToInt32(checkEmailCmd.ExecuteScalar());

                    // Check the counts and show appropriate messages
                    if (usernameCount > 0 && emailCount > 0)
                    {
                        MessageBox.Show("Username and Email are already used.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (usernameCount > 0)
                    {
                        MessageBox.Show("Username is already used.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (emailCount > 0)
                    {
                        MessageBox.Show("Email has already been used.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        // No duplicates found, proceed with insertion
                        OleDbCommand insertCmd = new OleDbCommand("INSERT INTO listofUsers([Username],[Email],[Password],[Age])VALUES(@Username,@Email,@Password,@Age)", con);
                        insertCmd.Parameters.AddWithValue("@Username", textBox1.Text);
                        insertCmd.Parameters.AddWithValue("@Email", textBox2.Text);
                        insertCmd.Parameters.AddWithValue("@Password", textBox3.Text);
                        insertCmd.Parameters.AddWithValue("@Age", label2.Text);
                        insertCmd.ExecuteNonQuery();

                        this.Hide();
                        Form2 logIn = new Form2();
                        logIn.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != DateTime.Now)
            {
                int years = DateTime.Now.Year - dateTimePicker1.Value.Year;
                if (dateTimePicker1.Value.AddYears(years) > DateTime.Now) years--;
                label2.Text = years.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 logIn = new Form2();
            logIn.Show();
        }
    }
}