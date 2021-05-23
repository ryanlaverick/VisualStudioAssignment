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
    public partial class AddWebsiteForm : Form
    {
        //Local AddForm variable - allows us to access the old form to set or retrieve information from it
        AddForm addForm;
        public AddWebsiteForm(AddForm addForm)
        {
            InitializeComponent();

            //Assigns local addForm variable to parameter
            this.addForm = addForm;

            //Displays current form to user
            this.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Calls "isPopulated" method from Utils class. '!' is equal to checking if the boolean result returned from this method is false
            if(!Utils.isPopulated(this))
            {
                //Displays error message to user on "AddForm" form
                addForm.getOutputBox().Text += "You failed to complete a necessary field! \r\n";
                //Closes current form
                this.Close();
                //Closes method, preventing the code below from being executed
                return;
            }

            //Creates a new "Website" object
            Website website = new Website();

            //Assigns text from each text box on form to variable
            String projectName = txtBoxProjectName.Text;
            String projectClient = txtBoxProjectClient.Text;
            String projectDeadline = txtBoxProjectDeadline.Text;
            String projectPlatform = txtBoxProjectPlatform.Text;
            String server = txtBoxServerName.Text;

            //Checks if input in "txtBoxNumOfPages" is an integer, using a method called from the Utils class ('isInt' method)
            if(!Utils.isInt(txtBoxNumOfPages.Text))
            {
                //Displays error message to user on "AddForm" form
                addForm.getOutputBox().Text += "Invalid input: Expected integer not string! \r\n";
                //Closes current form
                this.Close();
                //Closes method, preventing the code below from being executed
                return;
            }
            int numOfPages = int.Parse(txtBoxNumOfPages.Text);

            //Sets "App" variables (information about the project)
            website.setProjectName(projectName);
            website.setProjectClient(projectClient);
            website.setProjectDeadline(projectDeadline);
            website.setProjectPlatform(projectPlatform);
            website.setServerName(server);
            website.setNumberOfPages(numOfPages);

            //Accesses "DictionaryHandler" class and the "getAppDictionary()" method (as it is static and can be referenced throughout the program easily).
            //The "Add" method adds a key-value set to the dictionary, consisting of the project ID (which is automatically generated when creating
            //an instance of the "Website" class) and the website object itself.
            DictionaryHandler.getWebsiteDictionary().Add(website.getProjectID(), website);

            //Displays text to user on "addForm" form, confirming Website has been added successfully
            addForm.getOutputBox().Text += "Added website '" + projectName + "' successfully! \r\n";

            //Closes form
            this.Close();
        }
    }
}
