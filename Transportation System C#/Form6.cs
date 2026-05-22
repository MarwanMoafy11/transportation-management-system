using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportation_System_C_
{
    public partial class profile_Form : Form
    {
        public profile_Form()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=Uber;Integrated Security=True");

        private void profile_Form_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string fullName = full_name_textBox.Text;
            string number = number_textBox.Text;
            string email = email_textBox.Text;
            string password = password_textBox.Text;
            string confirmPassword = con_password_textBox.Text;
            string gender = male_radioButton.Checked ? "Male" : female_radioButton.Checked ? "Female" : "";
            string address = address_textBox.Text;
            bool isDriver = isDriver_checkBox.Checked;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in required fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                string query = "UPDATE USERS SET FULLNAME = @FullName, PHONENUMBER = @Phone, PASSWORD = @Password, ADDRESS = @Address WHERE EMAIL = @Email";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Phone", number);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Profile updated successfully!");
                    else
                        MessageBox.Show("No profile found with the provided email.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Delete_button_Click(object sender, EventArgs e)
        {
            string email = email_textBox.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete your profile?",
                                                 "Confirm Delete",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string deleteQuery = "DELETE FROM USERS WHERE EMAIL = @Email";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int rowsDeleted = cmd.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                            MessageBox.Show("Profile deleted successfully.");
                        else
                            MessageBox.Show("No profile found with the provided email.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
