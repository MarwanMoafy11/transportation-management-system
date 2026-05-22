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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Transportation_System_C_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=Uber;Integrated Security=True");

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            Class1.from_where = from_where_textBox.Text.Trim();
            Class1.to_where = from_where_textBox.Text.Trim();
            Class1.vehicle = "";

            if (car_radioButton.Checked)
               Class1.vehicle = "Car";
            else if (scooter_radioButton.Checked)
                Class1.vehicle = "Scooter";
            else if (bus_radioButton.Checked)
                Class1.vehicle = "Bus";

            Ride_result_form resultForm = new Ride_result_form();
            con.Close();
            resultForm.Show();
            this.Hide();
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            profile_Form proform = new profile_Form();
            con.Close();
            proform.Show();
            this.Hide();
        }
    }
}
