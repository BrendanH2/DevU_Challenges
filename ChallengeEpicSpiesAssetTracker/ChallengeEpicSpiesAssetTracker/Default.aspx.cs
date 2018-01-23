using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            logoImage.ImageUrl = "epic-spies-logo.jpg";

            if (!Page.IsPostBack)
            {
                double[] elections = new double[0];
                //initialize an array, elections , with 0 elements
                ViewState.Add("Elections", elections);
                //Elections is a key, elections is the array

                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);
                
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            double[] elections = (double[])ViewState["Elections"];
            //(double[]) is casting Eleections to an Array of type double
            //Viewstate key used to access array
            Array.Resize(ref elections, elections.Length + 1);
            int newestItem = elections.GetUpperBound(0);
            //in GetUpperBound, a dimesion is required. For a single array, dimension = 0
            elections[newestItem] = double.Parse(electionsRiggedTextBox.Text);
            ViewState["Elections"] = elections;


            double[] subterfuge = (double[])ViewState["Subterfuge"];

            Array.Resize(ref subterfuge, subterfuge.Length + 1);
            int newestItem1 = subterfuge.GetUpperBound(0);
            subterfuge[newestItem1] = double.Parse(subterfugeTextBox.Text);
            ViewState["Subterfuge"] = subterfuge;

            resultLabel.Text = String.Format("Total elections rigged:{0}" +
                                             "<br />Average subterfuges completed: {1:N2} " +
                                             "<br />(Last agent to complete a mission: {2})", 
                                             elections.Sum(), 
                                             subterfuge.Average(), 
                                             assetNameTextBox.Text);
        }
    }
}