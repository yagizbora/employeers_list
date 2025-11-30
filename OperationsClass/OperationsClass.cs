using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotenv.net;
using Microsoft.Data.SqlClient;
using Dapper;
namespace İş_yeri_Kullanıcı_Girişleri.OperationsClass
{
    public class OperationsClass 
    {
        public string? Connectionstring;
        public OperationsClass()
        {
            try
            {
                DotEnv.Load();
                Connectionstring = Environment.GetEnvironmentVariable("﻿DB_CONNECTION");
                if(string.IsNullOrEmpty(Connectionstring))
                {
                    throw new Exception("Veritabanı bağlantı dizesi bulunamadı.");
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine("Hata: " + ex.Message);
                Console.WriteLine("Hata: " + ex.Message);
            }
         }


        public async Task<string?> CreateEmployeer(string? Name, string? Departmant)
        {
            try
            {
                if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Departmant))
                {
                    return "İsim veya Departman alanları boş olamaz.";
                }

                using (var connection = new SqlConnection(Connectionstring))
                {
                    connection.Open();
                    string sql = "INSERT INTO dbo.Employeer_List (Name,Department,is_deleted) VALUES (@Name,@Departmant,0)";
                    var response = await connection.ExecuteAsync(sql, new { Name = Name, Departmant = Departmant });
                    if(response > 0)
                    {
                        return "Kayıt başarı ile eklendi";
                    }
                    else 
                    {
                        return "Kayıt eklenemedi.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Hata: " + ex.Message;
            }

        }
        public async Task<DataTable?> GetEmployeer()
        {
            try
            {
                using(var connection = new SqlConnection(Connectionstring))
                {
                    string sql = "SELECT ID as Sicil_Numarasi,Name as İsim,Department as Departman FROM dbo.Employeer_List WHERE is_deleted = 0";
                    var command = new SqlCommand(sql, connection);
                    var adapter = new SqlDataAdapter(command);
                    if(adapter == null)
                    {
                        return null;
                    }
                    else
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;

                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Hata: " + ex.Message);    
                return null;
            }    

        }
        public async Task<DataTable?> GetEmployeer(int id) 
        {
            try
            {
                using (var connection = new SqlConnection(Connectionstring))
                {
                    string sql = "SELECT ID as Sicil_Numarasi,Name as İsim,Department as Departman FROM dbo.Employeer_List WHERE is_deleted = 0 AND ID = @id";
                    var response = await connection.QueryFirstOrDefaultAsync(sql, new { id = id });
                    DataTable dataTable = new DataTable();
                    if(response == null)
                    {
                        return null;
                    }
                    response.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
            }
        }
        public bool DeleteEmployeer(int id)
        {
            try
            {
                using (var connection = new SqlConnection(Connectionstring))
                {
                    connection.Open();
                    string sql = "UPDATE dbo.Employeer_List SET is_deleted = 1 WHERE ID = @id";
                    var response = connection.Execute(sql, new { id = id });
                    return response > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }
    }
}
