using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
    
        public class Job_HistoryManager
        {
            public Job_History aJobh { get; set; }
            public ICrud<Job_History> jobPDAO;

            public Job_HistoryManager(int iDjh)
            {
                jobPDAO = new DB_Job_History_DAO();

            }


            public Job_History GetJobHStat(int id)
            {
                aJobh = jobPDAO.GetById(id);
                return aJobh;

            }
        }
    }

