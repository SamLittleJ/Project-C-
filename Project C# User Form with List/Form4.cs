using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_C__User_Form_with_List
{
    public partial class Form4 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ciura\OneDrive - UNIVERSITATEA ROMANO-AMERICANA\Documents\dbforC.accdb");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newItemName = Microsoft.VisualBasic.Interaction.InputBox("Enter your task!", "Title", "", 200, 200);
            if (newItemName != null)
            {
                checkedListBox1.Items.Add(newItemName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
            try
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand($"DELETE FROM listofItems WHERE [idUser] = @idUser", conn))
                {
                    cmd.Parameters.AddWithValue("@idUser", Form3.id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string editItem = Microsoft.VisualBasic.Interaction.InputBox("Enter your task!", "Title", "", 200, 200);
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
                checkedListBox1.Items.Add(editItem);
            }
            else
                MessageBox.Show("Select and Item to Edit first!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 logIn = new Form2();
            this.Close();
            logIn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                foreach (object listItem in checkedListBox1.Items)
                {
                    // Check if the item already exists in the database
                    OleDbCommand checkCmd = new OleDbCommand("SELECT COUNT(*) FROM listofItems WHERE [listItem] = @listItem AND [idUser] = @idUser", conn);
                    checkCmd.Parameters.AddWithValue("@listItem", listItem.ToString());
                    checkCmd.Parameters.AddWithValue("@idUser", Form3.id);

                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    // If the item doesn't exist, insert it
                    if (count == 0)
                    {
                        OleDbCommand insertCmd = new OleDbCommand("INSERT INTO listofItems ([listItem], [idUser]) VALUES (@listItem, @idUser)", conn);
                        insertCmd.Parameters.AddWithValue("@listItem", listItem.ToString());
                        insertCmd.Parameters.AddWithValue("@idUser", Form3.id);
                        insertCmd.ExecuteNonQuery();
                        insertCmd.Parameters.Clear();
                    }

                    checkCmd.Parameters.Clear();
                }

                // Delete checked items from the database
                foreach (object checkedItem in checkedListBox1.CheckedItems)
                {
                    string listItem = checkedItem.ToString();

                    // Delete the item from the database
                    OleDbCommand deleteCmd = new OleDbCommand("DELETE FROM listofItems WHERE [listItem] = @listItem AND [idUser] = @idUser", conn);
                    deleteCmd.Parameters.AddWithValue("@listItem", listItem);
                    deleteCmd.Parameters.AddWithValue("@idUser", Form3.id);
                    deleteCmd.ExecuteNonQuery();
                    deleteCmd.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();

            // Clear the checked items
            checkedListBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                using (OleDbCommand cmd = new OleDbCommand($"SELECT * FROM listofItems WHERE [idUser] = @idUser", conn))
                {
                    cmd.Parameters.AddWithValue("@idUser", Form3.id);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            checkedListBox1.Items.Add(reader["listItem"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                conn.Close();
        }
    }
}
