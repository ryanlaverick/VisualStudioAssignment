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
    public partial class DisplayForm : Form
    {

        //Local Form1 variable
        Form1 form1;

        //Consuctor for DisplayForm class, passing in "Form1" as a parameter
        public DisplayForm(Form1 form1)
        {
            InitializeComponent();
            //Assigns local Form1 variable to the parameter Form1 class being passed into the constructor
            this.form1 = form1;
            //Show() method displays the form to the user
            this.Show();
        }

        //Local variable "newLine" refers to the characters " \r\n", which moves text to the next line
        private String newLine = " \r\n";

        //Method called when "btnListGames" button is clicked
        private void btnListGames_Click(object sender, EventArgs e)
        {
            //Calls local method "listGames()"
            listGames();
        }

        //Method called when "btnListWebsites" button is clicked
        private void btnListWebsites_Click(object sender, EventArgs e)
        {
            //Calls local method "listWebsites()"
            listWebsites();
        }

        //Method called when "btnListApplications" button is clicked
        private void btnListApplications_Click(object sender, EventArgs e)
        {
            //Calls local method "listApps()"
            listApps();
        }

        //Method called when "btnListAll" button is clicked
        private void btnListAll_Click(object sender, EventArgs e)
        {
            //Calls local methods "listGames()", "listWebsites()" and "listApps()"
            listGames();
            listWebsites();
            listApps();
        }

        //Method called when "btnClear" button is clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Calls "clear();" method
            clear();
        }

        //Defines private (can only be accessed from this class) "listGames()" method, this means I can repeatedly refer to this method without having to rewrite the code contained in the method
        private void listGames()
        {
            //Checks if "getGameDictionary()" getter from the "DictionaryHandler" class has entries (if it does, the "Count()" of the method will be > 0)
            if (DictionaryHandler.getGameDictionary().Count() == 0)
            {
                //Displays message to user than no game projects have been logged using custom "output()" method
                output("No Game projects have been logged!");
            }
            //Otherwise
            else
            {
                //Loops through each entry from the Dictionary<string, Game> returned by the "DictionaryHandler.getGameDictionary()" method
                foreach (var kvp in DictionaryHandler.getGameDictionary())
                {
                    //Returns "Game" class from each entry of the Dictionary
                    Game game = kvp.Value;
                    //Uses private method to print out game information
                    output("Project name: " + game.getProjectName());
                    output("Project ID: " + game.getProjectID());
                    output("Project client: " + game.getProjectClient());
                    output("Project due date: " + game.getProjectDeadline());
                    output("Project platform: " + game.getProjectPlatform());
                    output("Game rating: " + game.getRating());
                    output("Game genre: " + game.getGenre());
                    output(" ");
                }
            }
        }

        //Defines private (can only be accessed from this class) "listApps()" method, this means I can repeatedly refer to this method without having to rewrite the code contained in the method
        private void listApps()
        {
            //Checks if "getAppDictionary()" getter from the "DictionaryHandler" class has entries (if it does, the "Count()" of the method will be > 0)
            if (DictionaryHandler.getAppDictionary().Count() == 0)
            {
                //Displays message to user than no app projects have been logged using custom "output()" method
                output("No Application projects have been logged!");
            }
            //Otherwise
            else
            {
                //Loops through each entry from the Dictionary<string, App> returned by the "DictionaryHandler.getAppDictionary()" method
                foreach (var kvp in DictionaryHandler.getAppDictionary())
                {
                    App app = kvp.Value;
                    //Uses private method to print out app information
                    output("Project name: " + app.getProjectName());
                    output("Project ID: " + app.getProjectID());
                    output("Project client: " + app.getProjectClient());
                    output("Project due date: " + app.getProjectDeadline());
                    output("Project platform: " + app.getProjectPlatform());
                    output("App type: " + app.getType());
                    output(" ");
                }
            }
        }

        //Defines private (can only be accessed from this class) "listWebsites()" method, this means I can repeatedly refer to this method without having to rewrite the code contained in the method
        private void listWebsites()
        {
            //Checks if "getWebsiteDictionary()" getter from the "DictionaryHandler" class has entries (if it does, the "Count()" of the method will be > 0)
            if (DictionaryHandler.getWebsiteDictionary().Count() == 0)
            {
                //Displays message to user than no website projects have been logged using custom "output()" method
                output("No Website projects have been logged!");
            }
            //Otherwise
            else
            {
                //Loops through each entry from the Dictionary<string, Website> returned by the "DictionaryHandler.getWebsiteDictionary()" method
                foreach (var kvp in DictionaryHandler.getWebsiteDictionary())
                {
                    //Retrieves the "Value" from the Dictionary, Value is the Website object associated with the "string" Key in each entry
                    Website website = kvp.Value;
                    //Uses private method to print out website information
                    output("Project name: " + website.getProjectName());
                    output("Project ID: " + website.getProjectID());
                    output("Project client: " + website.getProjectClient());
                    output("Project due date: " + website.getProjectDeadline());
                    output("Project platform: " + website.getProjectPlatform());
                    output("Website server name: " + website.getServerName());
                    output("Number of website pages: " + website.getNumberOfPages());
                    output(" ");
                }
            }
        }

        //Defines private "output" method which can only be referenced from inside of this class (as it is "private") The method takes a singular "string" parameter, which is required for the method to work
        private void output(string s)
        {
            //Appends the "string" parameter, plus the "newLine" variable (" \r\n") to the "txtBoxOutput" text
            txtBoxOutput.Text += s + newLine;
        }

        //Defines private "clear()" method.
        private void clear()
        {
            //Clears "txtBoxOutput" etxtbox by setting the text to blank
            txtBoxOutput.Text = "";
        }

        //Method called when "btnExit" button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Current form is closed
            this.Close();
        }
    }
}
