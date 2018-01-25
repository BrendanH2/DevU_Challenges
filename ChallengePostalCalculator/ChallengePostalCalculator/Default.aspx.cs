using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            calculateRate();
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateRate();
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateRate();
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateRate();
        }


        private void calculateRate()
        {


            //   verify TextBox Inputs
            if (!validEntry()) return;

            //   find volumes
            double volume = 0;
            if (!validVolume(out volume)) return;

            //   get shipping rate
            double methodRate = getMethodRate();

            //   calculate shipping
            double price = volume * methodRate;

            //   show rate to customer
            resultLabel.Text = String.Format("{0:C}", price);
        }
 
        private bool validEntry()
        {
            if (widthTextBox.Text.Trim().Length == 0 ||
                heigthTextBox.Text.Trim().Length == 0)
                return false;
            return true;
        }

        private bool validVolume(out double volume)
        {
            volume = 0;
            double width = 0;
            double heigth = 0;
            double length = 0;

            if (!double.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!double.TryParse(heigthTextBox.Text.Trim(), out heigth)) return false;
            if (!double.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1 ;

            volume = width * heigth * length;
            return true;
        }

        private double getMethodRate()
        {
            if (airRadioButton.Checked) return 0.25;
            else if (nextDayRadioButton.Checked) return 0.45;
            else return 0.15;
        }

      

       
    }
}