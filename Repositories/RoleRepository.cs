using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class RoleRepository
    {
        private readonly SqlConnection _connection = new SqlConnection("");

        public RoleRepository(SqlConnection connection)
        => _connection = connection;

        public IEnumerable<Role> GetAll()
        => _connection.GetAll<Role>();

        public Role Get(int id, String connectionString)
            => _connection.Get<Role>(id);
        public void Create(Role role, String connectionString)
        =>
            _connection.Insert<Role>(role);
    }
}