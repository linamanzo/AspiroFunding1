using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AF_CS_BO;


namespace AF_CS_BO
{
    public class ScoreCard
    {
        public int residentialscore;
        public int maritalscore;
        public int agescore;
        public int personalscore;

        public ScoreCard()
        {
        }

        [Flags]
        public enum resStatus
        {

            owner_with_mortgage = 10,
            owner_with_no_mortgage = 40,
            renting = 10,
            living_with_parents = 20


        }

        [Flags]
        public enum marStat
        {   married = 30,
            single	= 10,
            
            seperated =10,
            divorced =	0,

        }

        public int SetScore(string res, string mar, out int score )
        {

            try
            {
                if (res == Convert.ToString(resStatus.owner_with_mortgage))
                {
                    residentialscore= (int)resStatus.owner_with_mortgage;
                     
                }
                if (res == Convert.ToString(resStatus.renting))
                {
                    
                   residentialscore     = (int)resStatus.renting;
                    
                }
                if (res == Convert.ToString(resStatus.living_with_parents))
                {
                    
                   residentialscore     = (int)resStatus.living_with_parents;
                     
                }
                if (res == Convert.ToString(resStatus.owner_with_no_mortgage))
                {
                   
                      residentialscore   = (int)resStatus.owner_with_no_mortgage;
                    
                }
                if (mar == Convert.ToString(marStat.single))
                {
                      maritalscore= (int)marStat.single;
                    
                }
                if (mar == Convert.ToString(marStat.married))
                {
                   maritalscore  = (int)marStat.married;
                    
                }
                if (mar == Convert.ToString(marStat.seperated))
                {
                    maritalscore= (int)marStat.seperated;
                     
                }
                if (mar == Convert.ToString(marStat.divorced))
                {
                   maritalscore  = (int)marStat.divorced;
                     
                }

               personalscore= score = residentialscore + maritalscore;
            }
            finally
            {
            } return personalscore;
        }
        
    }

    
}