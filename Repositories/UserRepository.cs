namespace Blog.Repositories
{
    public class UserRepository
    {
        public void ReadUsers()
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
    }
}