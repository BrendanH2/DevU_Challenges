using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendarChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime dateOne = Calendar1.SelectedDate;
            DateTime dateTwo = Calendar2.SelectedDate;

            TimeSpan result = dateTwo.Subtract(dateOne);

            int numberDays = int.Parse(result.Days.ToString());
            //converting number of days from TimeSpan into string and back to int

            int absoluteDays = Math.Abs(numberDays);
            //instead of if else, use absolute value

            resultLabel.Text = absoluteDays.ToString();
        }
    }
}