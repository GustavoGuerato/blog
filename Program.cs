using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;


class Program
{
    private const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True; ";
    static void Main()
    {
        //ReadUsers();
        UpdateUsers();
    }

    public static void ReadUsers()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var users = connection.GetAll<User>();

            foreach (var user in users)
            {
                System.Console.WriteLine(user.Name);

            }
        }
    }

    public static void CreateUsers()
    {

        var user = new User()
        {
            Bio = "Equipe Balta.io",
            Email = "hello@balta.io",
            Image = "",
            Name = "Equipe balta.io",
            PasswordHash = "HASH",
            Slug = "equipe-balta"
        };

        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Insert<User>(user);
            System.Console.WriteLine("Cadastro Realizado com Sucesso");
        }

    }


    public static void UpdateUsers()
    {
        var user = new User()
        {
            Id = 2,
            Bio = "Equipe | Balta.io",
            Email = "hello@balta.io",
            Image = "",
            Name = "Equipe de suporte balta.io",
            PasswordHash = "HASH",
            Slug = "equipe-balta"
        };

        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            connection.Update<User>(user);
            System.Console.WriteLine("Atualização Realizado com Sucesso");
        }
    }

    public static void DeleteUsers()
    {
        using (var connection = new SqlConnection(CONNECTION_STRING))
        {
            var user = connection.Get<User>(2);
            connection.Delete<User>(user);
            System.Console.WriteLine("Atualização Realizado com Sucesso");
        }
    }
}
