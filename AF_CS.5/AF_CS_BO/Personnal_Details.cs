using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace AF_CS_BO
{
    public class Personnal_Details
    {
        public int iDpersD;
        public int age;
        public string maritalStatus;
        public string residentialStatus;
        public int personnalScore;
        private string var1, var2;
        public int residentialscore;
        
        //public IEnumerable<Personnal_Details> abstract  Personnal_Details  GetEnumerator(int i)
        

        int position = -1;

        //public object Current;

        //public void Reset();

        public int MoveNext()
        {
            position++;
            return position;
        }



        public Personnal_Details()
        { }



        public Personnal_Details(int id)
        {
            
        }
    [Flags]
      public  enum resStatus
        { 
            
           owner_with_mortgage = 10,
            owner_with_no_mortgage = 40,
            renting = 10,
            living_with_parents = 20


        };

        public int SetScore(string res)
      {
          
         try{if (res == Convert.ToString(resStatus.owner_with_mortgage))
             { int r = (int)resStatus.owner_with_mortgage;
                 residentialscore = r;
             }
             if (res == Convert.ToString(resStatus.renting))
             {
                 int r
                     = (int)resStatus.renting;
                 residentialscore = r;
             }
             
         }
             finally{
          }return  residentialscore;}
       //return  residentialscore;
          
           // {
           //     if (residentialStatus == String.Format("owner_with_no_mortgage"))
           //     {
           //         personnalScore = Convert.ToInt32(resStatus.owner_with_no_mortgage);

           //     }
           // }
        }
    }

