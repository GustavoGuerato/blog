using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class ListTagsScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Lista de Tags");
            System.Console.WriteLine("-------------");
            List();
            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Connection);
            var tags = repository.GetAll();
            foreach (var item in tags)
                System.Console.WriteLine($"{item.Id} - {item.Name}({item.Slug})");
        }
    }
}
