using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;
using AF_CS_DAL;

namespace AF_CS_BLL
{
   public class Course_DetailManager
    {public Course_Details acoursD { get; set; }
        private Course_DetailManager coursDmanager;
        public int id;
       
        private ICrud<Course_Details> coursdDAO;
       
       public Course_DetailManager( int idCourse)
       {   coursdDAO = new DB_Course_DetailsDAO();
          
       }
       public Course_Details GetCoursStat(int id)
       {
           acoursD = coursdDAO.GetById(id);
           return acoursD;

       }
    }
}
