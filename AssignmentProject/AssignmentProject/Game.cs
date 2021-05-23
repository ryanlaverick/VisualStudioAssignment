using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject
{
    //Inherits "Project" class
    class Game : Project
    {
        //Attributes
        private string rating;
        private string genre;

        //Methods

        //Getter - returns "rating" attribute
        public string getRating()
        {
            return rating;
        }

        //Setter - sets "rating" attribute to specified string parameter
        public void setRating(String rating)
        {
            //Sets local attribute to parameter
            this.rating = rating;
        }

        //Getter - returns "genre" attribute
        public string getGenre()
        {
            return genre;
        }

        //Setter - sets "genre" attribute to specified string parameter
        public void setGenre(String genre)
        {
            this.genre = genre;
        }

        //Getter that generates the project ID (this is standard across Apps, Websites and Games - using the following format: "projectType/projectName/projectClient/)"
        public String getProjectID()
        {
            return "game/" + this.getProjectName() + "/" + this.getProjectClient() + "/";
        }
    }
}
