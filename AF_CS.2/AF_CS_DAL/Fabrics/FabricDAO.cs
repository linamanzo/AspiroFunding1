using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;

namespace AF_CS_DAL.Fabrics
{
   public abstract class FabricDAO
   {
       FabricDAO FbDAO;
       public abstract ICrud<Borrower> GetArticleDAO();
        public abstract ICrud<Borrower> GetBorrowerDAO();
        public abstract ICrud<User> GetUserDAO();
        public abstract ICrud<Credit_Score> GetCSDAO();

       // méthode de création de fabrique
       //public static FabricDAO GetFabricDAO()
       //{
         

           
        
       //}
    }
}
