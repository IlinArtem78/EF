using EF_Library; 


class Program
{
    static void Main(string[] args)
    {
        using (var db = new EF_Library.AppContext())
        {
            var user1 = new User { Name = "Artur", Role = "admin" };
            var user2 = new User { Name = "Sergey", Role = "user" }; 
            db.Users.Add(user1);
            db.Users.Add(user2);    
            db.SaveChanges();
        }

    }


}