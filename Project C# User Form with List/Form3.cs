using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_C__User_Form_with_List
{
    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ciura\OneDrive - UNIVERSITATEA ROMANO-AMERICANA\Documents\dbforC.accdb");

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 logIn = new Form2();
            logIn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.ReadOnly = false;
            textBox2.Enabled = true;
            textBox2.ReadOnly = false;
            textBox3.Enabled = true;
            textBox3.ReadOnly = false;
            textBox4.Enabled = true;
            textBox4.ReadOnly = false;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ciura\\OneDrive - UNIVERSITATEA ROMANO-AMERICANA\\Documents\\dbforC.accdb"))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand($"SELECT * FROM listofUsers", conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (Form2.username == reader["Username"].ToString() && Form2.password == reader["Password"].ToString())
                                {
                                    textBox1.Text = reader["Username"].ToString();
                                    textBox2.Text = reader["Email"].ToString();
                                    textBox3.Text = reader["Password"].ToString();
                                    textBox4.Text = reader["Age"].ToString();
                                    textBox5.Text = reader["idUser"].ToString();
                                    id = Convert.ToInt32(textBox5.Text);
                                }
                            }
                        }
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int id = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("UPDATE listofUsers SET [Username]= ?, [Email]= ?, [Password]= ?, [Age]= ? WHERE [idUser]= ?", con);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                cmd.Parameters.AddWithValue("@Password", textBox3.Text);
                cmd.Parameters.AddWithValue("@Age", textBox4.Text);
                cmd.Parameters.AddWithValue("@idUser", textBox5.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            textBox1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox2.Enabled = false;
            textBox2.ReadOnly = true;
            textBox3.Enabled = false;
            textBox3.ReadOnly = true;
            textBox4.Enabled = false;
            textBox4.ReadOnly = true;
            textBox5.Enabled = false;
            textBox5.ReadOnly = true;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox1.ReadOnly = true;
            textBox2.Enabled = false;
            textBox2.ReadOnly = true;
            textBox3.Enabled = false;
            textBox3.ReadOnly = true;
            textBox4.Enabled = false;
            textBox4.ReadOnly = true;
            textBox5.Enabled = false;
            textBox5.ReadOnly = true;
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 list = new Form4();
            this.Hide();
            list.Show();
        }
    }
}
