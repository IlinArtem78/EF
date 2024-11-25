using EF_Library;
using EF_Library.Models;
using EF_Library.View;
using Microsoft.Identity.Client;


class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Работа приложения практического задания PJ-02 <<<<ILIN.Artem>>>>");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Выберите необходимую команду для работы с базой"); 
        Console.WriteLine();
        Console.WriteLine("1 - Ввести данные в базу; 2 - Работа моделью данных;  3 - Сортировка книг; 4 - Сортировка пользователей ");
        byte num = byte.Parse(Console.ReadLine());
        try {
            var test = new UserAddBooks();
            switch (num)
        {
            case 1:
                        
                break;
                case 2:

                break;
                case 3:
                    var sb = new SortedBooks(new BookRepository()); 
                break;
                case 4:

                break;
                default: Console.WriteLine();
                Console.WriteLine("Значение не верно, повторите ввод"); 
                break;
        }
        }
        catch (Exception ex) {
            Console.WriteLine(ex.ToString());   

        }


    }


}