using System.Collections;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection = new SqlConnection("");

        public Repository(SqlConnection connection)
        => _connection = connection;

        public IEnumerable<T> GetAll()
       => _connection.GetAll<T>();
    }
}