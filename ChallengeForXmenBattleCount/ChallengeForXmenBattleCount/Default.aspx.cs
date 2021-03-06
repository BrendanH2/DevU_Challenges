﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };


            string most = "";
            string least = "";

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers.Max())
                {
                    most = String.Format("Most battles belong to: {0} (Value:{1})", names[i], numbers[i]);
                }
                
                if (numbers[i] == numbers.Min())
                {
                    least = String.Format("Least battles belong to: {0} (Value:{1})", names[i], numbers[i]);
                }
            }

            resultLabel.Text = most + "<br/>" + least;

        }
    }
}