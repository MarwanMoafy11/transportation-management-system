using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.CodeDom.Compiler;

namespace Transportation_System_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=Uber;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
        }     
       

        private void login_Click(object sender, EventArgs e)
        {
            string email = username_textBox.Text; // Email entered
            string password = password_textBox.Text;

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM USERS WHERE EMAIL = @Email AND PASSWORD = @Password", con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                int result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form3 form3 = new Form3();
                    con.Close();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void signup_Click(object sender, EventArgs e)
        {
            sign_up form2 = new sign_up();
            con.Close();
            form2.Show();
            this.Hide();
        }

        private void con_google_Click(object sender, EventArgs e)
        {
            continue_with_form form2 = new continue_with_form();
            con.Close();
            form2.Show();
            this.Hide();
        }

        private void con_apple_Click(object sender, EventArgs e)
        {
            continue_with_form form2 = new continue_with_form();
            con.Close();
            form2.Show();
            this.Hide();
        }

        private void con_email_Click(object sender, EventArgs e)
        {
            continue_with_form form2 = new continue_with_form();
            con.Close();
            form2.Show();
            this.Hide();
        }
    }
}
