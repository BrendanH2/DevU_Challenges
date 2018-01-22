using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            double fortune = double.Parse(fortuneTextBox.Text);
             
            string result = String.Format("At  {0}  years old, I would expect you to have more than  {1:C}  in your pocket.",  age, fortune);
            //I realize I'm jumping the gun with the String.Format, but it felt it was good practice, and makes sense using a money value
            resultLabel.Text = result;
        }
    }
}