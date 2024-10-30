using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Cadastro de Tags");
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("Name: ");
            var name = Console.ReadLine() ?? "Nome Padrão";
            System.Console.WriteLine("Slug: ");
            var slug = Console.ReadLine() ?? "slug-padrao";

            Create(new Tag(name, slug));
            Console.ReadKey();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("não foi possivel salvar a tag");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
