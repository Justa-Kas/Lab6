using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tryAgain = true;
            while (tryAgain == true)
            {
                //copied the list of names from lecture time, different order than the post with names, hometowns and foods
                String[] names = {

                "Justin",
                "Aron",
                "Brandon",
                "Chris",
                "Delmar",
                "Josh",
                "Kasean",
                "Logan",
                "Matt",
                "Radeen",
                "Raston",
                "Scott",
                "Yash",
                "Yousif"
                };
                String[] hometown =
                {
                "Wyoming, MI",
                "Berea, KY",
                "Novi, MI",
                "Novi, MI",
                "Detroit, MI",
                "Northville, MI",
                "Detroit, MI",
                "Plymouth, MI",
                "Flint, MI",
                "Warren, MI",
                "Zeeland, MI",
                "Lansing, MI",
                "Detroit, MI",
                "Oak Park, MI"
                };
                String[] favFood =
                {
                "Baja Blast",
                "sushi",
                "Sushi",
                "Tacos",
                "vietnamese food",
                "Naleśniki",
                "steak",
                "Funyuns",
                "Hot Wings",
                "Mexican",
                "Vanilla Instant Pudding",
                "Nashville Chicken",
                "Hot Cheeto Puffs",
                "Deep Dish Pizza"
                };
                int studentChosen = -1;
                int searchType;
                {
                    //checks to make sure you choose 1 or 2 to decide how you look for students
                    while (true)
                    {
                        Console.WriteLine("Welcome to our C# class. Here you can learn more about the students. 1 will let you find a student by number and 2 will let you find a student by name.");
                        searchType = int.Parse(Console.ReadLine());
                        if (searchType == 1 || searchType == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid search type. Please try again.");
                        }
                    }
                    if (searchType == 1)
                    {
                        //makes sure you give a valid input for student's number
                        while (true)
                        {
                            Console.WriteLine("Which student would you like to learn about. Enter a number 0-13.");
                            studentChosen = int.Parse(Console.ReadLine());
                            if (studentChosen < 0 || studentChosen >= names.Length)
                            {
                                Console.WriteLine("That student does not exist. Please try again.");
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        //foinds the student's number from their name
                        while (true)
                        {
                            Console.WriteLine("Which student would you like to learn about. Enter student's first name");
                            string nameGiven = Console.ReadLine();
                            for (int l = 0; l < names.Length; l++)
                            {
                                if (nameGiven.ToLower().Trim() == names[l].ToLower())
                                {
                                    studentChosen = l;
                                    break;
                                }

                                if (studentChosen == l)
                                {
                                    break;
                                }
                            }
                            if (studentChosen < 0 || studentChosen >= names.Length)
                            {
                                Console.WriteLine("That student does not exist.");
                            }
                            else { break; }

                        }
                    }
                    Console.Write($"{names[studentChosen]} is student number {studentChosen}. What would you like to know about {names[studentChosen]}? ");
                    string findWithInfo;
                    while (true)
                    {
                        //checks to make sure you enter either hometown or favorite food then breaks out of it
                        Console.WriteLine($"(enter /“hometown/” or /“favorite food/”)");
                        findWithInfo = Console.ReadLine();
                        if (findWithInfo.ToLower() == "hometown")
                        {
                            Console.WriteLine($"{names[studentChosen]}'s hometown is {hometown[studentChosen]}. Would you like to know more?");
                            string moreResponse = Console.ReadLine();
                            if (moreResponse == "no")
                            {
                                Console.WriteLine("Thank you!");
                                break;
                            }
                            else if (moreResponse != "yes")
                            {
                                Console.WriteLine("Please try again.");
                            }
                        }
                        else if (findWithInfo.ToLower() == "favorite food")
                        {
                            Console.WriteLine($"{names[studentChosen]}'s favorite food is {favFood[studentChosen]}. Would you like to know more?");
                            string moreResponse = Console.ReadLine();
                            if (moreResponse == "no")
                            {
                                Console.WriteLine("Thank you!");
                                break;
                            }
                            else if (moreResponse != "yes")
                            {
                                Console.WriteLine("Please try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please try again.");
                        }
                    }

                }
                while (true)
                {
                    //asks to retry.
                    Console.WriteLine("Do you want to check a different student? yes or no");
                    string tryAgainAnswer = Console.ReadLine();
                    if (tryAgainAnswer == "no")
                    {
                        Console.WriteLine("Thank you!");
                        tryAgain = false;
                        break;
                    }
                    else if (tryAgainAnswer != "yes")
                    {
                        Console.WriteLine("Please try again. Invalid response");
                    }
                    else
                    {
                        break;
                    }

                }
            }
            Console.ReadKey();
        }
    }
}