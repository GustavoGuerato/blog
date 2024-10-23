using Blog.Models;
using Blog.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;


class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True; ";
    static void Main()
    {
        var connection = new SqlConnection(CONNECTION_STRING);
        connection.Open();
        ReadUsers(connection);
        connection.Close();
    }

    public static void ReadUsers(SqlConnection connection)
    {
        var repository = new UserRepository(connection);
        var users = repository.GetAll();

        foreach (var user in users)
            System.Console.WriteLine(user.Name);
    }
    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new RoleRepository(connection);
        var roles = repository.GetAll();

        foreach (var role in roles)
            System.Console.WriteLine(role.Name);
    }




}
