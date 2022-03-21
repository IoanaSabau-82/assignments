using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPetOwner
{
    public abstract class User
    {
        public string Surname { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; } //optional
        public string Address { get; set; } //optional

        public User(string surname, string name, string phone = "", string address = "")
        {
            Surname = surname;
            Name = name;
            Phone = phone;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Surname } {Name }";
        }
    }

    static class UserExtensions 
    { 
    public static IEnumerable<Post> ShowPosts(this User user, List<Post> posts) 
        {
            return posts.Where(x => x.User == user);
        }
    }
}
