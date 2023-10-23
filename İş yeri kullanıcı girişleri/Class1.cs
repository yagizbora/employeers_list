using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Data.SqlClient;

public class AddUserData
{
    private string connectionString;

    public AddUserData()
    {
        // Bağlantı dizesini burada belirtin
        connectionString = "Server=HOME\\EMPLOYEER_LIST;Database=Employeer_List;Integrated Security=True";
    }

    public AddUserData(string connectionString)
    {
        this.connectionString = connectionString;
    }
    

    public void AddUser(int Sicil_Numarası, string isimSoyisim, string bolum)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Bağlantıyı açmadan önce oluşturun
                connection.Open();
                string insertQuery = "INSERT INTO dbo.Employeer_List (ID,Name,Department) VALUES (@ID, @Name, @Department)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", Sicil_Numarası);
                    command.Parameters.AddWithValue("@Name", isimSoyisim);
                    command.Parameters.AddWithValue("@Department", bolum);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} satır eklendi.");
                }
            }
            catch (SqlException ex)
            {
                // SQL hatası
                Console.WriteLine("SQL Hatası Oluştu: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Genel hata
                Console.WriteLine("Hata Oluştu: " + ex.Message);
            }

        }
    }

    internal void Adduser(string sicil_Numarası, string isimSoyisim, string bolum)
    {
        throw new NotImplementedException();
    }
}
