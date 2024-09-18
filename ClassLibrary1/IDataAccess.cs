using System;

namespace ClassLibrary1;

public interface IDataAccess
{
    public Task<List<T>> LoadData<T, U>(string sql, U paramaters, string connectionString);

    public Task SaveData<T, U>(string sql, U paramaters, string connectionString);

}
