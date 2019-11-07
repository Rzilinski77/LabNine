using System;
using System.Collections.Generic;
using System.Text;

namespace LabNine
{
    class StudentInfo
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;

        //default constructor
        public StudentInfo() { }

        //overloaded constructor

        public StudentInfo(string name)
        {
            Name = name;   
        }

        public StudentInfo(string name, string hometown)
        {
            Name = name;
            HomeTown = hometown;
        }

        public StudentInfo(string name, string hometown, string favoriteFood)
        {
            Name = name;
            HomeTown = hometown;
            FavoriteFood = favoriteFood;
        }
    }
}
