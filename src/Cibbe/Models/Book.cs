using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cibbe.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public DateTime DateBought { get; set; }

        public int NumberOfCopies { get; set; }

        public virtual List<Loan> Loans { get; set; }
    }
}
