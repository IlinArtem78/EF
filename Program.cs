using EF_Library;
using EF_Library.Models;
using EF_Library.View;


class Program
{

    public static List<User>? users { get; set; }
    public static List<Book>? books { get; set; }
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Работа приложения практического задания PJ-02 <<<<ILIN Artem>>>>");
        Console.WriteLine();
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Выберите необходимую команду для работы с базой");
            Console.WriteLine();
            Console.WriteLine("1 - Добавление данных в модель; 2 - Работа c моделью данных;  3 - Сортировка");
            byte num = byte.Parse(Console.ReadLine());
            try
            {
               
                switch (num)
                {
                    case 1:
                        var inputData = new InputData();
                        users = inputData.InputDataUsers(); 
                        books = inputData.InputDataBooks();
                        break;
                    case 2:
                        var workRepo = new WorkWithRepo(books,users);
                        break;
                    case 3:
                        var sb = new SortedBooks(new BookRepository(), new UserRepository());
                        break;
                 
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Значение не верно, повторите ввод");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
        }

    }


}