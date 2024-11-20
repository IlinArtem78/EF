using EF_Library; 


class Program
{
    static void Main(string[] args)
    {
        /*
        using (var db = new EF_Library.AppContext())
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var user1 = new User { Name = "Artur", Role = "admin" };
            var user2 = new User { Name = "Sergey", Role = "user" }; 

            db.Users.Add(user1);
            db.Users.Add(user2);    
            db.SaveChanges();

        }
        */
            var bookRep = new BookRepository();
           // var book1 = new Books { Name = "Книга 1", Year = 1942 };
           // Books book2 = new Books { Name = "Книга 2", Year = 1945 };

        using (var db1 = new EF_Library.AppContext())
        {
            var book1 = new EF_Library.Book { Name = "Книга 1", Year = 1942 };
            db1.Books.Add(book1);
            db1.SaveChanges();

        }




       // bookRep.AddBook(book1);
       //     bookRep.AddBook(book2);
       //    Console.WriteLine("Введите название книги");
       //     string test = Console.ReadLine();
       //     bookRep.UpdateBookById(2, test);




       

    }


}