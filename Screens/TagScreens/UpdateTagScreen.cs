using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Atualizando  Tags");
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("Id: ");
            var id = Console.ReadLine() ?? "Nome Padrão";
            System.Console.WriteLine("Slug: ");
            var slug = Console.ReadLine() ?? "slug-padrao";

            Update(new Tag(id, slug));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("não foi possivel atualizar a tag");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
