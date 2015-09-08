using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cibbe.Models
{
    public class Loan
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

        public DateTime TimeOfLoan { get; set; }

        public DateTime TimeOfDelivery { get; set; }
    }
}
