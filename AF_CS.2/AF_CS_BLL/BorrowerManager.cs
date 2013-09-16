using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
   public class BorrowerManager
    {
        public Borrower aBorrower { get; set; }
        private Credit_ScoreManager csManager;
       // DAL Access
        private ICrud<Borrower> borrowerDAO;
       
       
       public BorrowerManager()
        {
            borrowerDAO = new DB_BorrowerDAO();
       }
       public BorrowerManager(Borrower brw)
       {
           aBorrower = brw;
       }

       
    }
}
