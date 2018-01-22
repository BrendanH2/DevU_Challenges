using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void additionButton_Click(object sender, EventArgs e)
        {
            double valueOne = double.Parse(value1TextBox.Text);
            double valueTwo = double.Parse(value2TextBox.Text);

            double sum = valueOne + valueTwo;

            resultLabel.Text = sum.ToString();
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            double valueOne = double.Parse(value1TextBox.Text);
            double valueTwo = double.Parse(value2TextBox.Text);

            double difference = valueOne - valueTwo;

            resultLabel.Text = difference.ToString();
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            double valueOne = double.Parse(value1TextBox.Text);
            double valueTwo = double.Parse(value2TextBox.Text);

            double product = valueOne * valueTwo;

            resultLabel.Text = product.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            double valueOne = double.Parse(value1TextBox.Text);
            double valueTwo = double.Parse(value2TextBox.Text);

            double factor = valueOne / valueTwo;

            resultLabel.Text = factor.ToString();
        }
    }
}