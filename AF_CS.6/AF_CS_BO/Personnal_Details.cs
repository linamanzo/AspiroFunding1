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
        public int idcreditscore;
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
        public int Getid(int id)
        {
            idcreditscore =id ;
            return idcreditscore;
        }
        }
    }

