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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=Uber;Integrated Security=True");

        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open(); 
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string promoCode = promo_textBox.Text.Trim();

            if (promoCode == "")
            {
                MessageBox.Show("Please enter a promo code to delete.");
                return;
            }

            string query = "DELETE FROM PromoCodes WHERE Code = @Code";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Code", promoCode);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
                MessageBox.Show("Promo code deleted successfully.");
            else
                MessageBox.Show("Promo code not found.");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string promoCode = promo_textBox.Text.Trim();

            if (promoCode == "")
            {
                MessageBox.Show("Please enter a promo code to add.");
                return;
            }

            string query = "INSERT INTO PromoCodes (Code) VALUES (@Code)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Code", promoCode);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Promo code added successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error adding promo code: " + ex.Message);
            }
        }

        private void checkout_button_Click(object sender, EventArgs e)
        {

        }
    }
}
