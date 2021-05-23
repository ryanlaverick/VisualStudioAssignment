using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentProject
{
    class Utils
    {
        //Defines private static method which returns a boolean value, taking a TextBox as a parameter
        private static Boolean isPopulated(TextBox textBox)
        {
            //Returns the boolean value of textBox parameter's text being blank
            return textBox.Text == "";
        }

        /*Defines public static method which returns a boolean, taking a Form as a parameter. This method was created using code found on Stackoverflow
        (https://social.msdn.microsoft.com/Forums/en-US/db55a8dc-5c1c-4831-af1f-a7016d42970c/foreach-loop-to-loop-all-the-text-box-in-a-form?forum=csharplanguage -
        specifically the reply from the user 'Ali Raza Shaikh'
        */
        public static Boolean isPopulated(Form form)
        {
            //Loops through each Control object in the form
            foreach (Control control in form.Controls)
            {
                //Checks if control is a TextBox object
                if (control is TextBox)
                {
                    //Casts a TextBox variable to the control
                    TextBox textBox = (TextBox)control;
                    //Checks textBox text
                    if(textBox.Text == "")
                    {
                        //Returns false if the TextBox is blank
                        return false;
                    }
                }
            }

            //Default value returned if all text boxes are looped and all have values
            return true;
        }

        public static Boolean isInt(string s)
        {
            int res;
            bool result = int.TryParse(s, out res);

            return result;
        }
    }
}
