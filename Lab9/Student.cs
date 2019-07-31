using System;
namespace Lab9
{
    public class Student
    {
        public string Name;
        public string Hometown;
        public string FaveFood;
        public string FaveBand;

        public Student(string name, string hometown, string faveFood, string faveBand)
        {
            Name = name;
            Hometown = hometown;
            FaveFood = faveFood;
            FaveBand = faveBand;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetHometown()
        {
            return Hometown;
        }

        public string GetFaveFood()
        {
            return FaveFood;
        }

        public string GetFaveBand()
        {
            return FaveBand;
        }
    }
}
