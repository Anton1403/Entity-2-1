using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity_2_1
{
        public class UserContext : DbContext
        {
        public UserContext() :
            base("UserDB")
            
            { }
            public DbSet<User> Users { get; set; }
        }
    class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                var users = db.Users;
                foreach (User u in users)
                {
                    Console.WriteLine("{0}-{1} - {2}", u.Id, u.Name, u.Age);
                }
            }
        }
        
    } 
}
