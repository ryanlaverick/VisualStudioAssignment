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
    public partial class AddForm : Form
    {

        Form1 form1;
        public AddForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.Show();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm(this);
        }

        private void btnAddApp_Click(object sender, EventArgs e)
        {
            AddAppForm addAppForm = new AddAppForm(this);
        }

        private void btnAddWebsite_Click(object sender, EventArgs e)
        {
            AddWebsiteForm addWebsiteForm = new AddWebsiteForm(this);
        }

        public TextBox getOutputBox()
        {
            return txtBoxOutput;
        }

        //Method called when "btnExit" button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Current form is closed
            this.Close();
        }
    }
}
