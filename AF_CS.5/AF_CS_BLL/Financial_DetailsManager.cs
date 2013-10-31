using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
   public class Financial_DetailsManager
    {public Financial_Details aFinD { get; set; }
       public ICrud<Financial_Details> financDDAO;

       public Financial_DetailsManager( int iDjp)
       {   financDDAO = new DB_Financial_Details_DAO();
          
       }


       public Financial_Details GetFinancialStat(int id)
       {
           aFinD = financDDAO.GetById(id);
           return aFinD;

       }
    }
}
