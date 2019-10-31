using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace BasicsCSharp
{
    // Classes are an encapsulation of data properties and data methods.
    // Properties - describe the data the class will be holding.
    // Methods - identifies which operations can be performed on the data.
    class Tutorial
    {
        // Defining the fields of the class
        int TutorialID;
        string TutorialName;

        // Defining the SetTutorial method
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public string GetTutorial()
        {
            return TutorialName;
        }
    }
}
