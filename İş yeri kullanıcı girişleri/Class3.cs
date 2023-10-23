using System;
using System.Data.SqlClient;

public class DeleteUserData
{
    private string connectionString;

    public DeleteUserData(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void DeleteUser(int barkodNo)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string deleteQuery = "DELETE FROM Employeer_List WHERE ID = @ID";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@ID", barkodNo);

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} satır silindi.");
            }
        }
    }
}
