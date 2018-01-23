using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked == true)
            {
                resultImage.ImageUrl = "pencil.png";
                resultLabel.Text = "You like pencils:";
            }
            else if (penRadioButton.Checked == true)
            {
                resultImage.ImageUrl = "pen.png";
                resultLabel.Text = "You like pens:";
            }
            else if (phoneRadioButton.Checked == true)
            {
                resultImage.ImageUrl = "phone.png";
                resultLabel.Text = "You like phones:";
            }
            else if (tabletRadioButton.Checked == true)
            {
                resultImage.ImageUrl = "tablet.png";
                resultLabel.Text = "You like tablets:";
            }
            else
            {
                resultLabel.Text = "Please make a selection";
            }
        

        }
    }
}