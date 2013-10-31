using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
  public  class Job_ProspectManager
  {
      public Job_Prospect aJobp { get; set; }
       public ICrud<Job_Prospect> jobPDAO;

       public Job_ProspectManager( int iDjp)
       {   jobPDAO = new DB_Job_Prospect_DAO();
          
       }


       public Job_Prospect GetJobPStat(int id)
       {
           aJobp = jobPDAO.GetById(id);
           return aJobp;

       }
    }
}
