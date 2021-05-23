using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentProject
{
    public partial class HelpForm : Form
    {
        //Local Form1 variable
        Form1 form1;

        //Consuctor for DisplayForm class, passing in "Form1" as a parameter
        public HelpForm(Form1 form1)
        {
            InitializeComponent();

            //Assigns local Form1 variable to the parameter Form1 class being passed into the constructor
            this.form1 = form1;

            //Show() method displays the form to the user
            this.Show();

            //Calls "displayHelp()" method
            displayHelp();
        }

        //Defines "displayHelp()" method as private (cannot be accessed from outside this class)
        private void displayHelp()
        {
            //Displays help to user
            display("Help");
            display("");
            display("Adding a Project");
            display("Step 1: From the Home page, press the 'Add' button, a new form should be displayed");
            display("Step 2: Select which type of project you wish to add (Game, Website or Application) and click the corresponding button");
            display("Step 3: Fill in the fields on the form that pops up");
            display("Step 4: Click 'Add' - you should see a confirmation message if it has worked!");
            display("");
            display("");
            display("");
            display("");
            display("Displaying Projects");
            display("Step 1: From the Home page, press the 'Display' button, a new form should be displayed");
            display("Step 2: Select which type of Project you wish to see (Games, Apps, Websites or all) and click the corresponding button");
            display("Step 3 (OPTIONAL): To clear the text box, you can click the 'Clear' button next to it!");
        }

        //Defines "display" method with string parameter
        private void display(String str)
        {
            //Creates variable that moves text to new line
            String newLine = " \r\n";

            //Adds string parameter to txtBoxHelp with "newLine" appended to the end, ensuring that text goes onto the next line
            txtBoxHelp.Text += str + newLine;
        }

        //Method called when "btnExit" button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes current form
            this.Close();
        }
    }
}
