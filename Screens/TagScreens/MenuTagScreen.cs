namespace Blog.Screens.TagScreens
{
    public class MenuTagScreen
    {
        public void Load()
        {
            Console.Clear();
            System.Console.WriteLine("Gestão de Tags");
            System.Console.WriteLine("-------------");
            System.Console.WriteLine("o que deseja fazer? ");
            System.Console.WriteLine();
            System.Console.WriteLine("1- Listar Tags");
            System.Console.WriteLine("2 - Cadastrar Tags");
            System.Console.WriteLine();
            System.Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {   
                case 1:
                .Load();

                case 2:
                .Load();
                default:Load();break; 
            }
        }
    }
}
