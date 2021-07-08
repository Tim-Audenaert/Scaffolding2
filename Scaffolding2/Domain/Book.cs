using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scaffolding2.Domain
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }

    }
}
