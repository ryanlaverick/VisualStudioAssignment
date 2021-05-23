using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject
{
    //Inherits "Project" class
    class App : Project
    {
        //Attributes
        private string type;

        //Getter - returns "type" attribute
        public string getType()
        {
            return type;
        }

        //Setter - sets "type" attribute
        public void setType(String type)
        {
            //Sets private attribute (type) to parameter string
            this.type = type;
        }

        //Getter that generates the project ID (this is standard across Apps, Websites and Games - using the following format: "projectType/projectName/projectClient/)"
        public String getProjectID()
        {
            return "app/" + this.getProjectName() + "/" + this.getProjectClient() + "/";
        }
    }
}
