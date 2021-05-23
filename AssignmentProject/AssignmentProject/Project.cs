using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject
{
    class Project
    {
        //Basic project attributes
        private string projectName;
        private string projectDeadline;
        private string projectClient;
        private string projectPlatform;

        //Getters
        public string getProjectName()
        {
            //Returns "projectName" variable
            return projectName;
        }

        public string getProjectDeadline()
        {
            //Returns "projectDeadline" variable
            return projectDeadline;
        }

        public string getProjectClient()
        {
            //Returns "projectClient" variable
            return projectClient;
        }

        public string getProjectPlatform()
        {
            //Returns "projectPlatform" variable
            return projectPlatform;
        }
        



        //Setters - each method takes a String parameter
        public void setProjectName(String projectName)
        {
            //Sets variable "projectName" to the parameter taken by the method
            this.projectName = projectName;
        }

        public void setProjectDeadline(String projectDeadline)
        {
            //Sets variable "projectDeadline" to the parameter taken by the method
            this.projectDeadline = projectDeadline;
        }

        public void setProjectClient(String projectClient)
        {
            //Sets variable "projectClient" to the parameter taken by the method
            this.projectClient = projectClient;
        }

        public void setProjectPlatform(String projectPlatform)
        {
            //Sets variable "projectPlatform" to the parameter taken by the method
            this.projectPlatform = projectPlatform;
        }
    }
}
