using Blog.Models;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection = new SqlConnection("");

        public UserRepository(SqlConnection connection) : base(connection)
        => _connection = connection;


        public List<User> GetWithRoles
        {
            var query = @"
            SELECT 
                [User].*, 
                [Role].* 
            FROM 
                [User]
                LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";
            var users = new List<User>();
            

            return users;
        }
    }
}