using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[User]")]
    public class User
    {
        public User() => Roles = new List<Role>();

        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string PasswordHash { get; set; }

        public required string Bio { get; set; }

        public required string Image { get; set; }

        public required string Slug { get; set; }

        [Write(false)]
        public required List<Role> Roles { get; set; }
    }
}
