using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Lab9
{
    public class StudentManager
    {
        public List<Student> students = new List<Student>();

        public StudentManager()
        {
            //populate list
            students.Add(new Student("Cody", "Lawton", "Potato Soup", "The Strokes"));
            students.Add(new Student("Dakota", "Kent City", "Pho", "ABBA"));
            students.Add(new Student("Flaka", "Pristina", "Thai Food", "Dua Lipa"));
            students.Add(new Student("James", "Grand Rapids", "Cheeseburger and Fries", "Kanye West"));
            students.Add(new Student("Jason", "Holland", "Burgers", "ABBA"));
            students.Add(new Student("Joshua", "Grand Rapids", "Cheese Tortellini", "The Black Keys"));
            students.Add(new Student("KimVy", "Grand Rapids", "Sushi", "A Tribe Called Quest"));
            students.Add(new Student("Liz", "Earth", "Smoked Salmon", "Young the Giant"));
            students.Add(new Student("Mahruchi", "Teaneck", "Chicken Wings", "ABBA"));
            students.Add(new Student("Manik", "Cox's Bazar", "Spicy Beef Curry", "ABBA"));
            students.Add(new Student("Maricela", "Morelia", "Tacos", "ABBA"));
            students.Add(new Student("Moise", "Grand Rapids", "Lasagna", "ABBA"));
            students.Add(new Student("Sam", "Grand Rapids", "Tacos", "I'm Glad It's You"));
            students.Add(new Student("Tommy", "Raleigh", "Chicken Curry", "Tom Petty"));
        }

        public void Start()
        {
            try
            {
                Console.WriteLine("\nWelcome to our C# class.");
                Console.WriteLine("Would you like to find out about an existing student, or add a student?\n");
                Console.WriteLine("1. Find out about an existing student");
                Console.WriteLine("2. Add a student to the directory");
                Console.Write("\nEnter a number: ");

                int choiceNum = int.Parse(Console.ReadLine());

                if (choiceNum == 1)
                { 
                    DisplayInfo(GetStudentIndex());
                }
                else if (choiceNum == 2)
                {
                    AddStudent();
                }
                else
                {
                    Console.WriteLine("Please enter a 1 or 2");
                    Start();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a 1 or 2");
                Start();
            }
        }

        public int GetStudentIndex()
        {
            int index = 0;
            bool isValid = false;

            while (isValid == false)
            {
                try
                {
                    Console.WriteLine("\nWhich student would you like to learn more about?");

                    for (int i = 1; i <= students.Count; i++)
                    {
                        Thread.Sleep(30);
                        Console.WriteLine(i + ". " + students[i - 1].GetName());
                    }

                    Console.WriteLine();
                    Console.Write("Please enter a student number between 1 and " + students.Count + ": ");
                    index = int.Parse(Console.ReadLine());

                    if (index > 0 && index <= students.Count)
                    {
                        isValid = true;
                        return index;
                    }
                    else
                    {
                        Console.WriteLine("Entry not between 1 and " + students.Count + ".\n");
                        continue;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Entry not a valid integer.\n");
                    continue;
                }
            }
            return -1;
        }


        public void DisplayInfo(int studentNum)
        {
            Student stu = students[studentNum - 1]; //reduce studentNum by 1 for list starting at 0

            Console.WriteLine("Student " + studentNum + " is " + stu.GetName() + ".");
            Console.WriteLine("What would you like to know about " + stu.GetName() + "?");
            Console.Write("(enter \"hometown\" or \"favorite food\" or \"favorite band\"): ");

            string response = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (response == "hometown")
            {
                bool isValid = false;

                while (isValid == false)
                {
                    Console.WriteLine("\n" + stu.GetName() + " is from " + stu.GetHometown() + ".");
                    Console.Write("Would you like to know more? (enter \"yes\" or \"no\"): ");
                    string response2 = Console.ReadLine().ToLower();

                    if (response2 == "yes")
                    {
                        Console.WriteLine();
                        isValid = true;
                        DisplayInfo(GetStudentIndex());
                    }
                    else
                    {
                        isValid = true;
                        Console.Write("Would you like to return to main menu? (enter \"yes\" or \"no\"): ");
                        string response3 = Console.ReadLine().ToLower();

                        if (response3 == "yes")
                        {
                            Start();
                        }
                        else
                        {
                            Console.WriteLine("Thanks!");
                        }
                    }
                }
            }
            else if (response == "favorite food")
            {
                bool isValid = false;

                while (isValid == false)
                {
                    Console.WriteLine("\n" + stu.GetName() + "'s favorite food is " + stu.GetFaveFood() + ".");
                    Console.Write("Would you like to know more? (enter \"yes\" or \"no\"): ");
                    string response2 = Console.ReadLine().ToLower();

                    if (response2 == "yes")
                    {
                        Console.WriteLine();
                        isValid = true;
                        DisplayInfo(GetStudentIndex());
                    }
                    else
                    {
                        isValid = true;
                        Console.Write("Would you like to return to main menu? (enter \"yes\" or \"no\"): ");
                        string response3 = Console.ReadLine().ToLower();

                        if (response3 == "yes")
                        {
                            Start();
                        }
                        else
                        {
                            Console.WriteLine("Thanks!");
                        }
                    }
                }
            }
            else if (response == "favorite band")
            {
                bool isValid = false;

                while (isValid == false)
                {
                    Console.WriteLine("\n" + stu.GetName() + "'s favorite band is " + stu.GetFaveBand() + ".");
                    Console.Write("Would you like to know more? (enter \"yes\" or \"no\"): ");
                    string response2 = Console.ReadLine().ToLower();

                    if (response2 == "yes")
                    {
                        Console.WriteLine();
                        isValid = true;
                        DisplayInfo(GetStudentIndex());
                    }
                    else
                    {
                        isValid = true;
                        Console.Write("Would you like to return to main menu? (enter \"yes\" or \"no\"): ");
                        string response3 = Console.ReadLine().ToLower();

                        if (response3 == "yes")
                        {
                            Start();
                        }
                        else
                        {
                            Console.WriteLine("Thanks!");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("That data does not exist. Please try again.\n");
                DisplayInfo(studentNum);
            }
        }

        public void AddStudent()
        {
            Console.Write("\nEnter student's first name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student's hometown: ");
            string hometown = Console.ReadLine();

            Console.Write("Enter student's favorite food: ");
            string favefood = Console.ReadLine();

            Console.Write("Enter student's favorite artist: ");
            string faveband = Console.ReadLine();

            students.Add(new Student(name, hometown, favefood, faveband));

            //sort
            students = students.OrderBy(x => x.Name).ToList();

            Console.WriteLine("\nStudent #" + students.Count + " added to directory!");
            Console.Write("\nWould you like to add another student? (enter \"yes\" or \"no\"): ");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                AddStudent();
            }
            else
            {
                Console.Write("Would you like to return to main menu? (enter \"yes\" or \"no\"): ");
                string response2 = Console.ReadLine().ToLower();

                if (response2 == "yes")
                {
                    Start();
                }
                else
                {
                    Console.WriteLine("Thank you!");
                }
            }
        }
    }
}
