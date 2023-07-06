using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.entities
{
    public class User:Base
    {
        public User() { 
        Posts=new List<Post>();
        }
        public List<Post> Posts {get; set;}
        public string  Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
