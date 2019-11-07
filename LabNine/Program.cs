using System;
using System.Collections.Generic;

namespace LabNine
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //use lists
                var names = new List<string>{ "Jacob", "Drew", "Peter" };
                var foods = new List<string>{ "Cookies", "Ice Cream", "Thai Food" };
                var hometown = new List<string>{ "Merrillville", "Detroit", "Michigan" };
                var color = new List<string> { "Black", "Red", "Yellow" };
                string repeat = "y";

                while (repeat == "y")
                {
                    //welcome user and ask which student they want to learn about

                    Console.WriteLine("Welcome to our C# class.");
                    //show list of names

                    for (int i = 0; i < names.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {names[i]}");
                    }

                    bool again = true;
                    bool again2 = true;
                    bool again3 = true;
                    int studentNumber = 0;
                    string newInfo = "";
                    string learnInfo = "";
                    string learnMore = "";
                    string learnEvenMore = "";

                    try
                    {
                        Console.WriteLine("Would you like to add a new student? (y/n)");
                        string addStudent = Console.ReadLine().ToLower();


                        if (addStudent == "y")
                        {
                            Console.WriteLine("Please enter the student's name");
                            string name = Console.ReadLine();
                            names.Add(name);
                            Console.WriteLine("Please enter the student's hometown");
                            string town = Console.ReadLine();
                            hometown.Add(town);
                            Console.WriteLine("Please enter the student's favorite food");
                            string food = Console.ReadLine();
                            foods.Add(food);
                            Console.WriteLine("Please enter the student's favorite color");
                            string favColor = Console.ReadLine();
                            color.Add(favColor);
                            repeat = "y";
                            again = false;
                            again2 = false;
                            again3 = false;
                        }
                        else if (addStudent == "n")
                        {
                            Console.WriteLine("Would you like to learn about a student? (y/n)");
                            learnInfo = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("Input not valid, please enter y or n");
                        }

                        if (learnInfo == "y")
                        {
                            Console.WriteLine("Which student would you like to learn about? enter a number");
                            studentNumber = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Student {studentNumber} is {names[studentNumber - 1]}. What would you like to learn about {names[studentNumber - 1]}? (favorite food, hometown, or favorite color)");
                            newInfo = Console.ReadLine().ToLower();
                        }
                        else if (learnInfo == "n")
                        {
                            Console.WriteLine("Goodbye");
                            repeat = "n";
                        }

                        while (again == true)
                        {
                            if (newInfo == "favorite food")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {foods[studentNumber - 1]}. What would you like to know more about? (hometown or favorite color)");
                                again = false;
                                learnMore = Console.ReadLine().ToLower();
                            }
                            else if (newInfo == "hometown")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s hometown is {hometown[studentNumber - 1]}. What would you like to know more about? (favorite food or favorite color)");
                                again = false;
                                learnMore = Console.ReadLine().ToLower();
                            }
                            else if (newInfo == "favorite color")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite color is {color[studentNumber = 1]}. What would you like to know more about? (hometown or favorite color))");
                                again = false;
                                learnMore = Console.ReadLine().ToLower();
                            }
                            else
                            {
                                Console.WriteLine("That data does not exist. Please enter favorite food, hometown, or favorite color");
                                newInfo = Console.ReadLine().ToLower();
                            }
                        }

                        while (again2 == true)
                        {
                            if (learnMore == "hometown")
                            {

                                Console.WriteLine($"{names[studentNumber - 1]}'s hometown is {hometown[studentNumber - 1]}. Would you like to learn more? (y/n)");
                                again2 = false;
                                learnEvenMore = Console.ReadLine().ToLower();
                            }
                            else if (learnMore == "favorite food")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {foods[studentNumber - 1]}. Would you like to learn more? (y/n)");
                                again2 = false;
                                learnEvenMore = Console.ReadLine().ToLower();
                            }
                            else if (learnMore == "favorite color")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite color is {color[studentNumber - 1]}. Would you like to learn more? (y/n)");
                                again2 = false;
                                learnEvenMore = Console.ReadLine().ToLower();
                            }
                            else if (learnMore == "n")
                            {
                                repeat = "n";
                                again2 = false;
                            }
                            else
                            {
                                Console.WriteLine("Input not valid, please enter y or n");
                                learnMore = Console.ReadLine().ToLower();
                            }
                        }
                        while (again3 == true)
                        {
                            if (learnEvenMore == "y" && newInfo == "favorite food" && learnMore == "hometown")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite color is {color[studentNumber - 1]}.) Would you like to learn about a different student or add another student? (y/n)");
                                again3 = false;
                                repeat = Console.ReadLine().ToLower();
                            }
                            else if (learnEvenMore == "y" && newInfo == "favorite food" && learnMore == "favorite color")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s hometown is {hometown[studentNumber - 1]}.) Would you like to learn about a different student or add another student? (y/n)");
                                again3 = false;
                                repeat = Console.ReadLine().ToLower();
                            }
                            else if (learnEvenMore == "y" && newInfo == "hometown" && learnMore == "favorite color")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {foods[studentNumber - 1]}.) Would you like to learn about a different student or add another student? (y/n)");
                                again3 = false;
                                repeat = Console.ReadLine().ToLower();
                            }
                            else if (learnEvenMore == "y" && newInfo == "hometown" && learnMore == "favorite food")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite color is {color[studentNumber - 1]}. Would you like to learn about a different student or add another student? (y/n)");
                                again3 = false;
                                repeat = Console.ReadLine().ToLower();
                            }
                            else if (learnEvenMore == "y" && newInfo == "favorite color" && learnMore == "hometown")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s favorite food is {foods[studentNumber - 1]}.) Would you like to learn about a different student or add another student? (y/n)");
                                again3 = false;
                                repeat = Console.ReadLine().ToLower();
                            }
                            else if (learnEvenMore == "y" && newInfo == "favorite color" && learnMore == "favorite food")
                            {
                                Console.WriteLine($"{names[studentNumber - 1]}'s hometown is {hometown[studentNumber - 1]}.) Would you like to learn about a different student or add another student? (y/n)");
                                again3 = false;
                                repeat = Console.ReadLine().ToLower();
                            }
                            else if (learnEvenMore == "n")
                            {
                                again3 = false;
                                repeat = "n";
                            }
                        }
                            if (repeat == "n")
                            {
                                Console.WriteLine("Goodbye");
                            }
                            else if (repeat != "n" && repeat != "y")
                            {
                                Console.WriteLine("Input not valid, please enter y or n");
                                repeat = Console.ReadLine().ToLower();
                            }
                        
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Incorrect format. Please try again");
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine("Index out of range. Please try again");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        public static void noBlanks(string input)
        {
            
            do
            {
                if (!string.IsNullOrEmpty(input))
                {
                   
                }
                else
                {
                    Console.WriteLine("Empty input, please try again");
                }
            } while (string.IsNullOrEmpty(input));
        }
        //{
        //    StudentInfo student = new StudentInfo("Drew", "Detroit", "Chicken");
         
        //    List<StudentInfo> studentList = new List<StudentInfo>();

        //    studentList.Add(student);

        //    Console.WriteLine("Add new Student");
        //    bool repeat = true;

        //    while (repeat)
        //    {
        //        Console.WriteLine("Give me the new student's name");
        //        string name = Console.ReadLine();
        //        Console.WriteLine("Give me the student's hometown");
        //        string homeTown = Console.ReadLine();
        //        Console.WriteLine("Give me the student's favorite food");
        //        string favoriteFood = Console.ReadLine();

        //        //StudentInfo newStudent = new StudentInfo(name, homeTown, favoriteFood);

        //        studentList.Add(new StudentInfo(name, homeTown, favoriteFood));

        //        Console.WriteLine("Continue?");
        //        string input = Console.ReadLine();
        //        if (input.ToLower() != "y")
        //        {
        //            repeat = false;
        //        }
        //    }

        //    foreach (StudentInfo Student in studentList)
        //    {
        //        Console.WriteLine($"{Student.Name} {Student.HomeTown} {Student.FavoriteFood}");
        //    }

        //    Console.WriteLine();
        }
    }

