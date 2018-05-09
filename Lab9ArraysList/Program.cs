using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Arrays
{
    class Program
    {
        private static object myList;

        static void Main(string[] args)
        {
            ArrayList ListOfNames = new ArrayList();
            ListOfNames.Add("Allen");
            ListOfNames.Add("Barry");
            ListOfNames.Add("Chris");
            ListOfNames.Add("Danny");
            ListOfNames.Add("Elle");

            ArrayList ListOfFoods = new ArrayList();
            ListOfFoods.Add("Apples");
            ListOfFoods.Add("Bananas");
            ListOfFoods.Add("Carrots");
            ListOfFoods.Add("Dounuts");
            ListOfFoods.Add("Eggplants");

            ArrayList ListOfColors = new ArrayList();
            ListOfColors.Add("Red");
            ListOfColors.Add("Orange");
            ListOfColors.Add("Yellow");
            ListOfColors.Add("Green");
            ListOfColors.Add("Blue");

            ArrayList ListOfTowns = new ArrayList();
            ListOfTowns.Add("Detroit");
            ListOfTowns.Add("Ferndale");
            ListOfTowns.Add("Oak");
            ListOfTowns.Add("Berkley");
            ListOfTowns.Add("Camden");







            Console.WriteLine("Welcome to our C# class.");



            string MoreInfo = "";


            while (true)
            {

                Console.WriteLine("Which student would you like to learn more about (enter a number 1-5) or quit?  Type 'extra' to add another student:");
                string input = Console.ReadLine();
                int index;
                int.TryParse(input, out index);

                if (input.Length <= 0)
                {
                    Console.WriteLine("That was invaild input");
                    continue;
                }
                else if (input.ToLower() == "quit")
                {
                    return;
                }

                while (input == "extra")
                {
                    Console.WriteLine("What is the students name?");
                    ListOfNames.Add(Console.ReadLine());

                    Console.WriteLine("What is the students color?");
                    ListOfColors.Add(Console.ReadLine());

                    Console.WriteLine("What is the students Town?");
                    ListOfTowns.Add(Console.ReadLine());

                    Console.WriteLine("What is the students Food?");
                    ListOfFoods.Add(Console.ReadLine());

                    Console.WriteLine("Would you like to add another student, enter yes or no?");


                    string add = Console.ReadLine();


                    if (add == "yes")
                    {
                        input = "extra";

                    }
                    else
                    {
                        Console.WriteLine("Which student would you like to learn more about (enter a number 1-5) or quit?  Type 'extra' to add another student:");
                        input = Console.ReadLine();

                        int.TryParse(input, out index);
                    }






                }



                //This allow the names to be diplayed 1-5
                index--;


                if (index >= 0 || index < input.Length)
                {

                    Console.WriteLine($"Student {index + 1} is {ListOfNames[index]}. What would you like to know about {ListOfNames[index]}?");
                    Console.WriteLine($"Plese type hometown, favorite food or color)");
                    //ToLower to fix
                    MoreInfo = Console.ReadLine();


                }
                else
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-5)");
                }




                while (true)
                {

                    if (MoreInfo == "hometown")
                    {
                        Console.WriteLine($"{ListOfNames[index]} is from {ListOfTowns[index]}. Would you like to know more about {ListOfNames[index]}'s food, color or Y for another student?");
                    }
                    else if (MoreInfo == "food")
                    {
                        Console.WriteLine($"{ListOfNames[index]} likes {ListOfFoods[index]}. Would you like to know more about {ListOfNames[index]}'s hometown, color or Y for another student?");
                    }
                    if (MoreInfo == "color")
                    {
                        Console.WriteLine($"{ListOfNames[index]} likes {ListOfColors[index]}. Would you like to know more about {ListOfNames[index]}'s hometown, food or Y for another student?");
                    }


                    break;

                }

                Console.WriteLine("Press Y to see another student, or N to exit program");
                string input2 = Console.ReadLine();
                if (input2 != "Y")
                {
                    break;
                }


            }

        }

    }
}
