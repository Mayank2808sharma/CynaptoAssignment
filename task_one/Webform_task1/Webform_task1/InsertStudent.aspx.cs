using System;
using System.Data.SqlClient;

namespace YourNamespace
{
    public partial class InsertStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Add any code you need to run when the page loads
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes and radio button list
            string name = txtName.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;
            string gender = rblGender.SelectedValue;

            // TODO: Add validation to make sure all fields are filled out correctly

            // Create a connection to the database
            string connectionString = "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            // Open the database connection
            connection.Open();

            // Insert the new student into the database
            string query = "INSERT INTO Students (Name, Address, Email, Mobile, Gender) VALUES (@Name, @Address, @Email, @Mobile, @Gender)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Mobile", mobile);
            command.Parameters.AddWithValue("@Gender", gender);
            command.ExecuteNonQuery();

            // Close the database connection
            connection.Close();

            // Redirect the user to a confirmation page
            Response.Redirect("Confirmation.aspx");
        }
    }
}
