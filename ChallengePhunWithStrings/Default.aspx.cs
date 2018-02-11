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
            // 1.  Reverse your name
            string name = "Bob Tabor";
            // In my case, the result would be:
            // robaT boB

            /*
            for (int i = name.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += name[i];
            }
            */


            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            /*
            string[] namesArray = names.Split(',');
            for (int i = namesArray.Length - 1; i >= 0; i--)
            {
                resultLabel.Text += namesArray[i]+", ";
            }
            */


            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            /*
            string[] namesArray = names.Split(',');
            for (int i = 0; i < namesArray.Length; i++)
            {
                string newName = namesArray[i].PadLeft(namesArray[i].Length+(14-namesArray[i].Length)/2,'*').PadRight(14,'*');
                resultLabel.Text += newName + "<br />";
            }
            */


            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.


            string remove = "remove-me";
            int removeMe = puzzle.IndexOf(remove);
            puzzle = puzzle.Remove(removeMe,remove.Length);
            puzzle = puzzle.Replace('Z', 'T');
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            resultLabel.Text = puzzle;
            


        }
    }
}