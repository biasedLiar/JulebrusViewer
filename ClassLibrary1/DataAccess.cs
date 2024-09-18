using System;
using System.Data;
using System.Diagnostics;
using Dapper;
using MySql.Data.MySqlClient;

namespace ClassLibrary1;

public class DataAccess : IDataAccess
{
    public async Task<List<T>> LoadData<T, U>(string sql, U paramaters, string connectionString)
    {
        using (IDbConnection connection = new MySqlConnection(connectionString))
        {
          

                var rows = await connection.QueryAsync<T>(sql, paramaters);
                return rows.ToList();
           

        }
    }

    public Task SaveData<T, U>(string sql, U paramaters, string connectionString)
    {
        using (IDbConnection connection = new MySqlConnection(connectionString))
        {
            return connection.ExecuteAsync(sql, paramaters);
        }
    }

    public async Task<int> five<T>()
    {
        using (IDbConnection connection = new MySqlConnection("Server=mysql.stud.ntnu.no;Uid=eliaseb_user2;Pwd=H5K7da4r;Database=eliaseb_julbrus;default command timeout=20;"))
        {
            /*
            try
            { 
                var rows = await connection.QueryAsync<T>(sql, paramaters);

                return rows.ToList();
            } catch (Exception e)
            {
                Trace.TraceError(e.Message);
            }finally
            {

            }

            return new List<T>();
            */
            string sql = "select * from person";

            var rows = await connection.QueryAsync<T>(sql, new {});
            return rows.Count()+3;
            
 
        }
        return 8;
    }
}
