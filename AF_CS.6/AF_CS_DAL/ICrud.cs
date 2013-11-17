using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF_CS_DAL
{
   public interface ICrud<T>
   {
       object Insert(int i, T obj); 
       
       //void Delete(object id);
       //void Update(T obj);
       
       T GetById(object id);
       T GetScores(object id);

       T GetAll();
    }
}
