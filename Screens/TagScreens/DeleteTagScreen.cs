using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens
{
    public class DeleteTagScreen
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

            Delete(new Tag(id, slug));
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(Tag tag)
        {   
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(tag);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("não foi possivel atualizar a tag");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
