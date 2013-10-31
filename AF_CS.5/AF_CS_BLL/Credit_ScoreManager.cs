using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
    public class Credit_ScoreManager
    {
        public Credit_Score aCS { get; set; }

        private Personnal_DetailsManager persDmanager;
        private Course_DetailManager coursemanager;
        private Job_HistoryManager jobHManager;
        private Job_ProspectManager jobPmanager;
        private UniversityManager unimanager;
        private Financial_DetailsManager finDmanager;

        private ICrud<Credit_Score> creditDAO;

        public Credit_ScoreManager()
        {
            creditDAO = new DB_Credit_ScoreDAO();
        }

        public Credit_ScoreManager(Credit_Score cs)
        {
            aCS = cs;
        }
 
      
    }
}
