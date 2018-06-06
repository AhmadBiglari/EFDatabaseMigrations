using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Verlag
    {

        public Verlag()
        {
           Books = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

    }
}
