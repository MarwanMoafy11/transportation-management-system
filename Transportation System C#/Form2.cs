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
        public partial class sign_up : Form
        {
            public sign_up()
            {
                InitializeComponent();
            }
            private SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=Uber;Integrated Security=True");

            private void Form2_Load(object sender, EventArgs e)
            {
                con.Open();
            }

        
            private void signup_button_Click(object sender, EventArgs e)
            {
                string fullName = full_name_textBox.Text;
                string phone = number_textBox.Text;
                string email = email_textBox.Text;
                string password = password_textBox.Text;
                string confirmPassword = con_password_textBox.Text;
                string gender = male_radioButton.Checked ? "Male" : female_radioButton.Checked ? "Female" : "";
                string address = address_textBox.Text;
                bool isDriver = isDriver_checkBox.Checked;
                string vehicleType = car_radioButton.Checked ? "Car" : scooter_radioButton.Checked ? "Scooter" : bus_radioButton.Checked ? "Bus" : "";
                string vehicleModel = vehicle_model_textBox.Text;
                string usertype = isDriver ? "Driver" : "Customer";
                DateTime regDate = DateTime.Now;

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                try
                {
                

                    // Insert into Users
                    SqlCommand userCmd = new SqlCommand(@"INSERT INTO Users (FullName, Email, PhoneNumber, Password, Usertype, RegistrationDate, Address)
                                                  VALUES (@FullName, @Email, @Phone, @Password, @Usertype, @RegDate, @Address);
                                                  SELECT SCOPE_IDENTITY();", con);
                    userCmd.Parameters.AddWithValue("@FullName", fullName);
                    userCmd.Parameters.AddWithValue("@Email", email);
                    userCmd.Parameters.AddWithValue("@Phone", phone);
                    userCmd.Parameters.AddWithValue("@Password", password);
                    userCmd.Parameters.AddWithValue("@Usertype", usertype);
                    userCmd.Parameters.AddWithValue("@RegDate", regDate);
                    userCmd.Parameters.AddWithValue("@Address", address);

                    int userId = Convert.ToInt32(userCmd.ExecuteScalar());

                    if (isDriver)
                    {
                        // Insert into Drivers
                        SqlCommand driverCmd = new SqlCommand(@"INSERT INTO Drivers (UserID, LicenseNumber, NationalID, DriverStatus)
                                                        VALUES (@UserID, @LicenseNumber, @NationalID, @Status);
                                                        SELECT SCOPE_IDENTITY();", con);
                        driverCmd.Parameters.AddWithValue("@UserID", userId);
                        driverCmd.Parameters.AddWithValue("@LicenseNumber", "LICENSE123"); // You can replace with actual input
                        driverCmd.Parameters.AddWithValue("@NationalID", "NATID123");       // Replace with input
                        driverCmd.Parameters.AddWithValue("@Status", "Pending");

                        int driverId = Convert.ToInt32(driverCmd.ExecuteScalar());

                        // Insert into Vehicles
                        SqlCommand vehicleCmd = new SqlCommand(@"INSERT INTO Vehicles (VehicleType, VehicleModel, PlateNumber, VehicleColor, Year)
                                                         VALUES (@Type, @Model, @Plate, @Color, @Year);
                                                         SELECT SCOPE_IDENTITY();", con);
                        vehicleCmd.Parameters.AddWithValue("@Type", vehicleType);
                        vehicleCmd.Parameters.AddWithValue("@Model", vehicleModel);
                        vehicleCmd.Parameters.AddWithValue("@Plate", "ABC123"); // You can replace with actual input
                        vehicleCmd.Parameters.AddWithValue("@Color", "Black");  // Replace as needed
                        vehicleCmd.Parameters.AddWithValue("@Year", 2024);      // Replace as needed

                        int vehicleId = Convert.ToInt32(vehicleCmd.ExecuteScalar());

                        // Insert into DriverVehicles
                        SqlCommand linkCmd = new SqlCommand(@"INSERT INTO DriverVehicles (DriverID, VehicleID, AssignmentDate)
                                                      VALUES (@DriverID, @VehicleID, @AssignDate)", con);
                        linkCmd.Parameters.AddWithValue("@DriverID", driverId);
                        linkCmd.Parameters.AddWithValue("@VehicleID", vehicleId);
                        linkCmd.Parameters.AddWithValue("@AssignDate", DateTime.Now);
                        linkCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Sign up successful!");
                    Form3 form3 = new Form3();
                    con.Close();
                    form3.Show();
                    this.Hide();
                }
                 
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
