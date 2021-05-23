using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject
{
    //Inherits "Project" class
    class Website : Project
    {
        //Attributes
        private string serverName;
        private int numberOfPages;

        //Getter - returns "serverName" attribute
        public string getServerName()
        {
            return serverName;
        }

        //Setter - sets "serverName" attribute to specified string parameter
        public void setServerName(String serverName)
        {
            //Sets private attribute "serverName" to string parameter
            this.serverName = serverName;
        }

        //Getter - returns "numberOfPages" attribute
        public int getNumberOfPages()
        {
            return numberOfPages;
        }

        //Setter - sets "numberOfPages" attribute to specified int parameter
        public void setNumberOfPages(int numberOfPages)
        {
            //Sets private attribute "numberOfPages" to int parameter
            this.numberOfPages = numberOfPages;
        }

        //Getter that generates the project ID (this is standard across Apps, Websites and Games - using the following format: "projectType/projectName/projectClient/)"
        public String getProjectID()
        {
            return "website/" + this.getProjectName() + "/" + this.getProjectClient() + "/";
        }
    }
}
