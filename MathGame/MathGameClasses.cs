namespace MathGame
{
    public static class Menu
    {
        public static int Print()
        {
            // Show the Game Menu and wait for user input
            Console.Clear();
            Console.WriteLine("Welcome to the MathGame 2024!");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start new round");
            Console.WriteLine("2. Previous Games");
            Console.WriteLine("3. Exit");

            int selection;
            bool validInput = false;

            while (!validInput)
            {
                Console.WriteLine("Enter your selection:");
                string? userInput = Console.ReadLine();

                if (int.TryParse(userInput, out selection) && selection <= 4 && selection > 0)
                {
                    validInput = true;
                    switch (selection)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Choose an operation:");
                            Console.WriteLine("1. Addition");
                            Console.WriteLine("2. Subtraction");
                            Console.WriteLine("3. Division");
                            Console.WriteLine("4. Multiplication");
                            Console.WriteLine("5. Return");

                            int selection2;
                            bool validInput2 = false;

                            while (!validInput2)
                            {
                                Console.WriteLine("Enter your selection:");
                                string? userInput2 = Console.ReadLine();

                                if (int.TryParse(userInput2, out selection2) && selection2 < 5 && selection2 > 0)
                                {
                                    validInput2 = true;
                                    selection2 += 10;
                                    return selection2;
                                }
                                else if (selection2 == 5)
                                {
                                    validInput2 = true;
                                    Print();
                                }
                            }
                            break;

                        case 2:
                            return selection;

                        // Exit game
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Have a good day!");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid selection!");
                            break;
                    }
                }

                // Handle invalid user input
                else
                {
                    Console.WriteLine("Invalid selection!");
                }
            }
            return 2;
        }
    }

    public static class RandomNumber
    {
        public static (int, int) Generate()
        {
            Random random = new Random();
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);

            return (number1, number2);
        }

    }

    public static class Game
    {
        public static List<string[]> Start(int selection, List<string[]> gameList)
        {
            int gamePoints;
            string? name;
            string category;

            switch (selection)
            {
                case 11:
                    category = "Addition";
                    gamePoints = Addition.Play();
                    Console.Clear();
                    Console.WriteLine("GAME OVER!");
                    Console.WriteLine("Your Points: " + gamePoints);
                    Console.WriteLine("");
                    Console.WriteLine("Enter your name:");
                    name = Console.ReadLine();

                    if (name == null)
                    {
                        name = "NONAME";
                    }

                    gameList.Add(new string[] { name, category, gamePoints.ToString() });
                    return gameList;

                case 12:
                    category = "Subtraction";
                    gamePoints = Subtraction.Play();
                    Console.Clear();
                    Console.WriteLine("GAME OVER!");
                    Console.WriteLine("Your Points: " + gamePoints);
                    Console.WriteLine("");
                    Console.WriteLine("Enter your name:");
                    name = Console.ReadLine();

                    if (name == null)
                    {
                        name = "NONAME";
                    }

                    gameList.Add(new string[] { name, category, gamePoints.ToString() });
                    return gameList;

                case 13:
                    category = "Division";
                    gamePoints = Division.Play();
                    Console.Clear();
                    Console.WriteLine("GAME OVER!");
                    Console.WriteLine("Your Points: " + gamePoints);
                    Console.WriteLine("");
                    Console.WriteLine("Enter your name:");
                    name = Console.ReadLine();

                    if (name == null)
                    {
                        name = "NONAME";
                    }

                    gameList.Add(new string[] { name, category, gamePoints.ToString() });
                    return gameList;

                case 14:
                    category = "Multiplication";
                    gamePoints = Multiplication.Play();
                    Console.Clear();
                    Console.WriteLine("GAME OVER!");
                    Console.WriteLine("Your Points: " + gamePoints);
                    Console.WriteLine("");
                    Console.WriteLine("Enter your name:");
                    name = Console.ReadLine();

                    if (name == null)
                    {
                        name = "NONAME";
                    }

                    gameList.Add(new string[] { name, category, gamePoints.ToString() });
                    return gameList;

                default:
                    return gameList;
            }
        }
    }

    public static class Addition
    {
        public static int Play()
        {
            bool lostGame = false;
            int points = 0;

            do
            {
                Console.Clear();
                var numbers = RandomNumber.Generate();
                int answer;

                int number1 = numbers.Item1;
                int number2 = numbers.Item2;
                int sum = number1 + number2;

                Console.WriteLine(number1 + " + " + number2 + " = ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out answer))
                {
                    if (answer == sum)
                    {
                        points += 10;
                    }
                    else
                    {
                        lostGame = true;
                        return points;
                    }
                }

                else
                {
                    lostGame = true;
                    return points;
                }
            }
            while (lostGame == false);

            return points;
        }
    }

    public static class Subtraction
    {
        public static int Play()
        {
            bool lostGame = false;
            int points = 0;

            do
            {
                Console.Clear();
                var numbers = RandomNumber.Generate();
                int answer;

                int number1 = numbers.Item1;
                int number2 = numbers.Item2;
                int sum = number1 - number2;

                Console.WriteLine(number1 + " - " + number2 + " = ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out answer))
                {
                    if (answer == sum)
                    {
                        points += 10;
                    }
                    else
                    {
                        lostGame = true;
                        return points;
                    }
                }

                else
                {
                    lostGame = true;
                    return points;
                }
            }
            while (lostGame == false);

            return points;
        }
    }

    public static class Division
    {
        public static int Play()
        {
            bool lostGame = false;
            int points = 0;

            do
            {
                Console.Clear();
                var numbers = RandomNumber.Generate();
                int answer;

                int number1 = numbers.Item1;
                int number2 = numbers.Item2;

                while (number1 % number2 != 0)
                {
                    numbers = RandomNumber.Generate();
                    number1 = numbers.Item1;
                    number2 = numbers.Item2;
                }

                int sum = number1 / number2;

                Console.WriteLine(number1 + " / " + number2 + " = ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out answer))
                {
                    if (answer == sum)
                    {
                        points += 10;
                    }
                    else
                    {
                        lostGame = true;
                        return points;
                    }
                }

                else
                {
                    lostGame = true;
                    return points;
                }
            }
            while (lostGame == false);

            return points;
        }
    }

    public static class Multiplication
    {
        public static int Play()
        {
            bool lostGame = false;
            int points = 0;

            do
            {
                Console.Clear();
                var numbers = RandomNumber.Generate();
                int answer;

                int number1 = numbers.Item1;
                int number2 = numbers.Item2;
                int sum = number1 * number2;

                Console.WriteLine(number1 + " * " + number2 + " = ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out answer))
                {
                    if (answer == sum)
                    {
                        points += 10;
                    }
                    else
                    {
                        lostGame = true;
                        return points;
                    }
                }

                else
                {
                    lostGame = true;
                    return points;
                }
            }
            while (lostGame == false);

            return points;
        }
    }

    public static class PreviousGames
    {
        public static int List(List<string[]> previousGamesList)
        {
            Console.Clear();
            foreach (string[] row in previousGamesList)
            {
                Console.WriteLine(string.Join("\t", row));
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Back");
            Console.WriteLine("2. Exit");

            string? userInput = Console.ReadLine();
            int select;

            if (int.TryParse(userInput, out select))
            {
                if (select == 1)
                {
                    return 0;
                }
                else if (select == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Have a good day!");
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid selection. Exiting now!");
                    Environment.Exit(0);
                }
            }
            return 0;
        }
    }

}