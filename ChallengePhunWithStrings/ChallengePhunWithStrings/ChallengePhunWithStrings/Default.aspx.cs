using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

         

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //initilize a blank string
            string challenge1Solution = "";

            //data from textBox
            string textFromTextBox1 = challenge1TextBox.Text;

            //output input in reverse with a for loop
            for (int i = 0; i < textFromTextBox1.Length ; i++)
            {
                challenge1Solution += textFromTextBox1[textFromTextBox1.Length - i - 1 ].ToString();
            }

            resultLabel1.Text = challenge1Solution;
                                   
;       }



        protected void challenge2Button_Click(object sender, EventArgs e)
        {

            //for challenge 2 - reverse the order an array is printed 
            string[] challenge2Array = new string[4];
            challenge2Array[0] = challenge2TextBox1.Text;
            challenge2Array[1] = challenge2TextBox2.Text;
            challenge2Array[2] = challenge2TextBox3.Text;
            challenge2Array[3] = challenge2TextBox4.Text;

            string challenge2Solution = " ";

            for (int i = 0; i < challenge2Array.Length; i++)
            {
                challenge2Solution += challenge2Array[challenge2Array.Length - i - 1] + ", ".ToString();
            }
                        
            string challenge2SolutionString = challenge2Solution.ToString();

            challenge2SolutionString = challenge2SolutionString.Remove(challenge2SolutionString.Length- 2, 1);

            challenge2Label.Text = challenge2SolutionString;


        }

        protected void challenge3Button_Click(object sender, EventArgs e)
        {
            //use PadLeft and PadRight 

            string[] challenge3Array = new string[4];

            challenge3Array[0] = challenge3TextBox1.Text;
            challenge3Array[1] = challenge3TextBox2.Text;
            challenge3Array[2] = challenge3TextBox3.Text;
            challenge3Array[3] = challenge3TextBox4.Text;

            string challenge3SolutionString = " ";
            string challenge3Solution = " ";

            int paddingLeft = 0;
            int paddingRight = 0;

            for (int i = 0; i < challenge3Array.Length; i++)
            {
                paddingLeft = 12 - (12 - challenge3Array[i].Length)/2  ;
                paddingRight = 12 ;
                challenge3Solution = challenge3Array[i].PadLeft(paddingLeft , '*' ).PadRight(paddingRight, '*') + "<br/>";
               
                challenge3SolutionString += challenge3Solution;

                challenge3Label.Text = challenge3SolutionString;
            }

            /*
            paddingLeft = (12 - challenge3Array[i].Length) / 2;
            paddingRight = 12 - challenge3Array[i].Length - paddingLeft;
            */

        }

        protected void challenge4Button_Click(object sender, EventArgs e)
        {
            string stringToConvert = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID ZHEIR COUNZRY.";
            string ammendedString = stringToConvert.ToLower();
            ammendedString = ammendedString.Replace('z', 't').Replace("now", "Now").Remove(10, 9);
            ammendedString = ammendedString;

        
            challenge4Label.Text = ammendedString;
        }
    }
}