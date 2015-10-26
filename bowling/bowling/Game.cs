using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bowling
{
    class Game
    {

        int Now = 0;
        int[] B = new int[30];
        internal void SetPins(int p)
        {
            B[Now] = p;
            if (Now < 18&&p==10)
                Now += 2;
            else Now += 1;


        }

        internal int GetFinalScore()
        {
            int score = 0;
            for (int i = 0; i < 18; ++i)
            {

                score += B[i];
                if (i % 2 == 1&&B[i] + B[i - 1] == 10)
                {
                        score += B[i + 1];
                }
                if(B[i]==10&&i%2==0)
                {
                        score += B[i + 3];
                }
            }
            score += B[18] + B[19] + B[20];

            return score;
        }
    }
}
