using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {
    
        int Now = 0;
        int[] B = new int[21];
        internal void SetPins(int p)
        {
            B[Now] = p;
            ++Now;
            
           
        }

        internal int GetFinalScore()
        {
            int score = 0,A=0;
            for (int i=0;i<21;++i)
            {

                score += B[i];
              /*  if (i %2==1)
                { 
                if()
                
                }*/
            }

         
            return score;
        }
    }
}
