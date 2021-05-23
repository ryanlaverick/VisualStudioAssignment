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
    public partial class Form1 : Form
    {
        //Constructor
        public Form1()
        {
            InitializeComponent();
        }

        //Method called when "btnHelp" button is clicked
        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Creates new "HelpForm" object, with "this" (referring to Form1) passed as a parameter
            HelpForm helpForm = new HelpForm(this);
        }

        //Method called when "btnDisplay" button is clicked
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Creates new "DisplayForm" object, with "this" (referring to Form1) passed as a parameter
            DisplayForm displayForm = new DisplayForm(this);
        }

        //Method called when "btnAdd" button is clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Creates new "AddForm" object, with "this" (referring to Form1) passed as a parameter
            AddForm addForm = new AddForm(this);
        }
    }
}
