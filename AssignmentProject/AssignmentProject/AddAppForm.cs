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
    public partial class AddAppForm : Form
    {
        //Local AddForm variable - allows us to access the old form to set or retrieve information from it
        AddForm addForm;
        
        //Constructor which takes an AppForm class instance as a parameter
        public AddAppForm(AddForm addForm)
        {
            InitializeComponent();

            //Assigns local addForm variable to parameter
            this.addForm = addForm;

            //Displays current form to user
            this.Show();
        }

        //Event that is triggered when the button "btnAdd" is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Calls "isPopulated" method from Utils class. '!' is equal to checking if the boolean result returned from this method is false
            if (!Utils.isPopulated(this))
            {
                //Displays error message to user on "AddForm" form
                addForm.getOutputBox().Text += "You failed to complete a necessary field! \r\n";
                //Closes current form
                this.Close();
                //Closes method, preventing the code below from being executed
                return;
            }

            //Creates a new "App" object
            App app = new App();

            //Assigns text from each text box on form to variable
            String projectName = txtBoxProjectName.Text;
            String projectClient = txtBoxProjectClient.Text;
            String projectDeadline = txtBoxProjectDeadline.Text;
            String projectPlatform = txtBoxProjectPlatform.Text;
            String appType = txtBoxAppType.Text;

            //Sets "App" variables (information about the project)
            app.setProjectName(projectName);
            app.setProjectClient(projectClient);
            app.setProjectDeadline(projectDeadline);
            app.setProjectPlatform(projectPlatform);
            app.setType(appType);

            //Accesses "DictionaryHandler" class and the "getAppDictionary()" method (as it is static and can be referenced throughout the program easily).
            //The "Add" method adds a key-value set to the dictionary, consisting of the project ID (which is automatically generated when creating
            //an instance of the "App" class) and the app object itself.
            DictionaryHandler.getAppDictionary().Add(app.getProjectID(), app);

            //Displays text to user on "addForm" form, confirming App has been added successfully
            addForm.getOutputBox().Text += "Added app '" + projectName + "' successfully! \r\n";

            //Closes form
            this.Close();
        }
    }
}
