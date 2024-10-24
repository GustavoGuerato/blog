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


        public void Create(Role user)
        {
            user.Id = 0;
            _connection.Insert<Role>(user);
        }


        public void Update(Role user)
        {
            if (user.Id != 0)
                _connection.Update<Role>(user);
        }
        public void Delete(Role user)
        {
            if (user.Id != 0)
                _connection.Delete<Role>(user);
        }

        public void Delete(int id)
        {
            if (id != 0)
                return;

            var user = _connection.Get<Role>(id);
            _connection.Delete<Role>(user);
        }
    }
}