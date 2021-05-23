using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProject
{
    class DictionaryHandler
    {
        //Creates private private static Dictionaries for Apps, Games and Websites. As a Dictionary uses a key-value set for information stored inside,
        //I have chosen to use the project ID (string) for the key - as each ID will be unique and different from others stored within the Dictionary.
        //The Dictionary object itself is private, preventing it from being accessed from external classes/files though it must be static so I am able
        //to use static getters to reference it (static objects/variables can be accessed from anywhere in the program using the format
        //"ClassName.staticMethod();" or "ClassName.staticVariable;"
        private static Dictionary<string, App> appDictionary = new Dictionary<string, App>();
        private static Dictionary<string, Game> gameDictionary = new Dictionary<string, Game>();
        private static Dictionary<string, Website> websiteDictionary = new Dictionary<string, Website>();

        //Getters for each individual dictionary. There is no "setters" as we will have no use for the methods (we would have no reason to be setting the Dictionary object)
        public static Dictionary<String, App> getAppDictionary()
        {
            return appDictionary;
        }

        public static Dictionary<String, Game> getGameDictionary()
        {
            return gameDictionary;
        }

        public static Dictionary<String, Website> getWebsiteDictionary()
        {
            return websiteDictionary;
        }
    }
}
