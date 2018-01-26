using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*int firstCal = (int)firstCalendar.SelectedDate.Day;
            int secondCal = (int)secondCalendar.SelectedDate.Day;

            if (firstCal > secondCal)
            {
                int result = firstCal - secondCal;
                resultLabel.Text = result.ToString() + " days have elapsed";
            }
            else if (secondCal > firstCal)
            {
                int result = (secondCal - firstCal);
                resultLabel.Text = result.ToString() + " days have elapsed";      
            }
            else
            {
                resultLabel.Text = "0 days have elapsed";
            }
            */

            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                resultLabel.Text = firstCalendar.SelectedDate.Subtract(secondCalendar.SelectedDate).TotalDays.ToString();
            }
            else
            {
                resultLabel.Text = secondCalendar.SelectedDate.Subtract(firstCalendar.SelectedDate).TotalDays.ToString();
            }
        }
    }
}