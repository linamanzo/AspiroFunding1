using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF_CS_DAL
{
   public interface ICrud<T>
   {
       object Insert(T obj); 
       void Insert(IEnumerable<T> les);
       //void Delete(object id);
       //void Update(T obj);
       IEnumerable<T> GetAll();
       T GetById(object id);
       T GetScores(object id);
    }
}
