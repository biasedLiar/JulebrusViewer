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
}
