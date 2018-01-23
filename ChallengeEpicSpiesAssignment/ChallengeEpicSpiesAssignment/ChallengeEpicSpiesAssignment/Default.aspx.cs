using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                logoImage.ImageUrl = "epic-spies-logo.jpg";
                previousAssignmentEndCalendar.SelectedDate = DateTime.Now.Date;
                startNewAssignmentCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                projectedEndNewAssignmentCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            DateTime previousAssignmentEnd = previousAssignmentEndCalendar.SelectedDate;
            DateTime startNewAssignment = startNewAssignmentCalendar.SelectedDate;
            DateTime endNewAssignment = projectedEndNewAssignmentCalendar.SelectedDate;

            //there must be at least two weeks of paid time between assignments

            TimeSpan permissionToStart = startNewAssignment.Subtract(previousAssignmentEnd);
            TimeSpan missionFee = endNewAssignment.Subtract(startNewAssignment);
            String permissionToBegin = "";
            Double fee = 0;
            string result = "";


            if (permissionToStart.Days >= 14)
            {
                

                if (missionFee.Days <= 21)
                {
                    fee = permissionToStart.Days * 500;

                    result = String.Format("{0} has permission to begin the mission: {1}. " +
                                           "<br />{0} will depart {2: dddd, MMMM dd, yyyy } and is expected to return {3: dddd, MMMM dd, yyyy}. " +
                                           "<br />The mission is  21 days or less and will be charged at $500 per day for an expected total of:" +
                                           "<br />{4:C}.",
                                           codeNameTextBox.Text,
                                           assignmentNameTextBox.Text,
                                           startNewAssignment,
                                           endNewAssignment,
                                           fee);

                    resultLabel.Text = result;
                }

                else
                {
                    fee = permissionToStart.Days * 500 + 1000;

                    result = String.Format("{0} has permission to begin the mission: {1}. " +
                                          "<br />{0} will depart {2: dddd, MMMM dd, yyyy } and is expected to return {3: dddd, MMMM dd, yyyy}. " +
                                          "<br />The mission is more than 21 days and will be charged at $500 per day  with an additional $1,000 " +
                                          "<br />for an expected total of:" +
                                          " <br />{4:C}.",
                                          codeNameTextBox.Text,
                                          assignmentNameTextBox.Text,
                                          startNewAssignment,
                                          endNewAssignment,
                                          fee);

                    resultLabel.Text = result;
                }
                
            }
            else
            {
                result = String.Format("{0} does not have permission to begin mission: {1}.", 
                                                  codeNameTextBox.Text,
                                                  assignmentNameTextBox.Text);

                resultLabel.Text = result;
            }

            


        }
    }
}