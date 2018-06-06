using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public DateTime Erscheinungsdatum { get; set; }

        public int SeitenAnzahl { get; set; }
        public string Sprache { get; set; }

        public int VerlagId { get; set; }
        public Verlag Verlag { get; set; }


    }
}
