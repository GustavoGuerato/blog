using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepository
    {

        private readonly SqlConnection _connection = new SqlConnection("");

        public UserRepository(SqlConnection connection)
        => _connection = connection;

        public IEnumerable<User> GetAll()
        => _connection.GetAll<User>();

        public User Get(int id, String connectionString)
            => _connection.Get<User>(id);
        public void Create(User user, String connectionString)
        =>
            _connection.Insert<User>(user);

    }
}