using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class ShowUserData
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

public class ShowUser
{
    private string _connectionString;

    public ShowUser(string connectionString)
    {
        _connectionString = connectionString;
    }

    public bool CheckUserData(int Sicil_Numarası, out string isimSoyisim, out string bolum)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT Name, Department FROM Employeer_List WHERE ID = @ID";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@ID", Sicil_Numarası);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        isimSoyisim = reader["Name"].ToString();
                        bolum = reader["Department"].ToString();
                        return true;
                    }
                    else
                    {
                        isimSoyisim = null;
                        bolum = null;
                        return false;
                    }
                }
            }
        }
    }




    public DataTable ShowAllUserData()
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();
            string selectQuery = "SELECT * FROM Employeer_List";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }

    internal bool CheckUserData(int sicilNo)
    {
        throw new NotImplementedException();
    }
}
