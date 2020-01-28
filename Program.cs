using System;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
   
            string[] nameOfStudent =
             {
                "Brea Spencer",
                "John Stempowski",
                "Lucero Toral",
                "Socrates Katrievsis",
                "Thomas Barron",
                "Andrew Steward",
                "Ardella Shelton",
                "Brandon Brewer",
                "Jacob Fish",
                "Mark Ellis",
                "Michael Dubose",
                "Mike Schwarz",
                "Nic Gerhart",
                "O Omishope",
                "Laura Broke",
                "Sameer Siddiqui"
            };

            string[] favoriteFood =
            {
                "Pizza",
                "Mexican",
                "Chili Dogs",
                "Salads",
                "Nachos",
                "Burgers",
                "Fish",
                "Hot Dogs",
                "Chicken Wings",
                "Tacos",
                "Cake",
                "Ice Cream",
                "Seafood",
                "Pizza",
                "Thai",
                "Crab Legs"
            };

            string[] previousPosition =
          {
                "Teacher",
                "Model",
                "Basketball Player",
                "Track Star",
                "President",
                "Rapper",
                "UI/UX Designer",
                "Graphic Designer",
                "Teacher",
                "Model",
                "Singer",
                "CEO",
                "Sales Associate",
                "Tennis Player",
                "Bartender",
                "Football Player"
            };

            bool valid = false;
            string userContinue = null;
            string name, food, position;
            int iName;
            Console.Write("Welcome to our Dev.Build class. ");

            do
            {
                do
                {
                    Console.Write("Which student would you like to learn more about? (Enter a number 1-16):  ");
                    iName = Convert.ToInt32(Console.ReadLine());

                    if (iName > 0 && iName <= nameOfStudent.Length )
                    {
                        Console.WriteLine();
                        valid = false;
                    }
                    else
                    {
                        Console.Write("That student does not exist. Please try again.\n");
                        valid = true;
                    }

                } while (valid ==  true);

                name = nameOfStudent[iName - 1];
                food = favoriteFood[iName - 1];
                position = previousPosition[iName - 1];

                
                    Console.Write($"Student {iName} is {name}.\nWhat would you like to know about {name}? Favorite Food or Previous Position?: ");
                    string input = Console.ReadLine();

                while ((input != "Favorite Food") && (input != "Previous Position"))
                {
                    Console.Write("That data does not exist. Please try again.\nFavorite Food or Previous Position?: ");
                    input = Console.ReadLine();
                }
                    if (input == "Favorite Food")
                    {
                        Console.Write($"{name}'s favorite food is {food}.\n");

                    }

                    else if (input == "Previous Position")
                    {
                        Console.WriteLine($"{name}'s previous position is a {position}.");

                    }

                Console.Write("Would you like to know about another student? Yes or No? ");
                userContinue = Console.ReadLine();
                    
            } while (userContinue == "Yes" || userContinue == "yes" );
                 Console.WriteLine("See ya!");
        }
    }
}
