using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void  PlayerScore(Dart dart, Player player)
        {
            int playerScore = 0;

            if (dart.dartHitsBoard == 0 && dart.bullsEyeCenter == true)
            {
                playerScore = 50;
            }
            else if (dart.dartHitsBoard == 0 && dart.bullsEyeCenter != true)
            {
                playerScore = 25;
            }
            else if (dart.outerRing == true )
            {
                playerScore = dart.dartHitsBoard * 2;
            }
            else if (dart.innerRing == true )
            {
                playerScore = dart.dartHitsBoard * 3;
            }
            else
            {
                playerScore = dart.dartHitsBoard;
            }

            player.Score += playerScore;

            
        }
    }
}