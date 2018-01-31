using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{


    public class Dart
    {
        public int dartHitsBoard { get; set; }
        public bool outerRing { get; set; }
        public bool innerRing { get; set; }
        public bool bullsEyeCenter { get; set; }

        private Random _random; //a random variable may be need in other classes, so private

        public Dart(Random random)
        {
            _random = random;

        }

        public void Throw() //simulate throwing a dart at the board
        {
            dartHitsBoard = _random.Next(0, 21);

            int bonusMultiplier = _random.Next(1, 21);

            //5%chance to hit outerRing for 2X bonus multiplier
            if (bonusMultiplier == 1) outerRing = true;
            //5%chance to hit  innerRing for 3X bonus multiplier
            else if (bonusMultiplier == 2) innerRing = true;
            //5% to hit inner bull's eye 
            else if (bonusMultiplier == 3) bullsEyeCenter = true;
        }
    }
}


//use constructor to make new instance of Dart
//pass an instance of the random calss through Dart 
