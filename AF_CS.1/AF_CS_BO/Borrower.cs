using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF_CS_BO
{
   public class Borrower
    {
        public int idBorrower { get; set; }
        public DateTime postgraduateEndDate { get; set; }
        public bool postgraduateConfirmed { get; set; }
        public string undergraduateGrade { get; set; }
        public string borrowerProfile { get; set; }
    }
}
