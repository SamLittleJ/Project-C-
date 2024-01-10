using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_C__User_Form_with_List
{
    public partial class Form2 : Form
    {
        
        public static string checkIf2 = "";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ciura\OneDrive - UNIVERSITATEA ROMANO-AMERICANA\Documents\dbforC.accdb");
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
                textBox2.PasswordChar = '*';

            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.PasswordChar = '\0';
            else
                textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 signUp = new Form1();
            signUp.Show();
        }

        public static string username = "";
        public static string password = "";

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT [Username],[Password],[idUser] from listofUsers", con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    label2.Visible = false;
                    if (reader["Username"].ToString() == textBox1.Text && reader["Password"].ToString() == textBox2.Text)
                    {
                        username = textBox1.Text;
                        password = textBox2.Text;
                        this.Hide();
                        Form3 userStat = new Form3();
                        userStat.Show();
                    }
                    else
                        label2.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }
    }
}
