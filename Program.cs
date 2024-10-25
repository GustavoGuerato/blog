using System.Net.NetworkInformation;
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
        var repository = new Repository<User>(connection);
        var items = repository.GetAll();

        foreach (var item in items)
            System.Console.WriteLine(item.Name);
    }
    public static void ReadRoles(SqlConnection connection)
    {
        var repository = new Repository<Role>(connection);
        var items = repository.GetAll();

        foreach (var item in items)
            System.Console.WriteLine(item.Name);
    }

    public static void ReadTags(SqlConnection connection)
    {
        var repository = new Repository<Tag>(connection);
        var items = repository.GetAll();

        foreach (var item in items)
            System.Console.WriteLine(item.Name);
    }

    public static void UpdateUser(SqlConnection connection, int userId)
    {
        using (connection)
        {
            var repository = new Repository<User>(connection);

            var user = repository.Get(userId, CONNECTION_STRING);

            if (user != null)
            {
                user.Bio = "Equipe l Balta.io";
                user.Email = "hello@balta.io";
                user.Image = "http://";
                user.Name = "Equipe de suporte balta.io";
                user.PasswordHash = "HASH";
                user.Slug = "equipe-balta";

                repository.Update(user);

                System.Console.WriteLine("usuario atualizado com sucesso");
            }
            else
            {
                System.Console.WriteLine("usuario não foi localizado");
            }
        }
    }




}
