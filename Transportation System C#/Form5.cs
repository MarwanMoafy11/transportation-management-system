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
    public partial class Ride_result_form : Form
    {
        public Ride_result_form()
        {
            InitializeComponent();
        }
        private SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=Uber;Integrated Security=True");

        private void Ride_result_form_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = @"
            SELECT 
                U.FullName AS DriverName, 
                V.VehicleType + ' - ' + V.VehicleModel AS DriverVehicle
            FROM Drivers D
            JOIN Users U ON D.UserID = U.UserID
            JOIN DriverVehicles DV ON D.DriverID = DV.DriverID
            JOIN Vehicles V ON DV.VehicleID = V.VehicleID
            WHERE U.Address = @from AND V.VehicleType = @vehicle";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@from", Class1.from_where);
                cmd.Parameters.AddWithValue("@vehicle", Class1.vehicle);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No rides found for your search.");
                }

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void choose_button_Click(object sender, EventArgs e)
        {
            string inputName = name_textBox.Text.Trim();
            string inputVehicle = vehicle_textbox.Text.Trim();

            bool matchFound = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string driverName = row.Cells["DriverName"].Value.ToString().Trim();
                string driverVehicle = row.Cells["DriverVehicle"].Value.ToString().Trim();

                if (driverName.Equals(inputName, StringComparison.OrdinalIgnoreCase) &&
                    driverVehicle.Equals(inputVehicle, StringComparison.OrdinalIgnoreCase))
                {
                    Class1.selectedDriver = driverName;
                    Class1.selectedVehicle = driverVehicle;

                    MessageBox.Show($"You chose {driverName} with vehicle {driverVehicle}", "Driver Selected");
                    matchFound = true;

                    Form7 form7 = new Form7();
                    con.Close();
                    form7.Show();
                    this.Hide();

                    break;
                }
            }

            if (!matchFound)
            {
                MessageBox.Show("No matching driver found. Please type the exact name and vehicle from the list.");
            }
        }



    }
}
