// See https://aka.ms/new-console-template for more information

//void GetUserChoice()
//{
//    Chest current = Chest.Locked;
//    string choice;

//    if (current == Chest.Locked)
//        Console.WriteLine("The chest is locked. What do you want to do? ");
//        choice = Console.ReadLine();
//        if (choice.ToLower() == "unlock") current = Chest.Unlocked;

//    if (current == Chest.Unlocked)
//        Console.WriteLine("The chest is unlocked. What do you want to do? ");
//        choice = Console.ReadLine();
//        if (choice.ToLower() == "open") current = Chest.Open;

//    if (current == Chest.Open)
//        Console.WriteLine("The chest is open. What do you want to do? ");
//        choice = Console.ReadLine();
//        if (choice.ToLower() == "close") current = Chest.Closed;

//    if (current == Chest.Closed)
//        Console.WriteLine("The chest is closed. What do you want to do? ");
//        choice = Console.ReadLine();
//        if (choice.ToLower() == "lock") current = Chest.Locked;

//}

//while (true)
//{
//    GetUserChoice();
//}

//enum Chest
//{
//    Open,
//    Closed,
//    Locked,
//    Unlocked
//}

// Tuples
//(Type type, Ingredients ingredients, Seasoning seasoning) score;

//(Type type, Ingredients ingredients, Seasoning seasoning) PickMenu()
//{
//    while(true)
//    {
//        string choice;

//        Type selectedType = default;
//        Ingredients selectedIngredients = default;
//        Seasoning selectedSeasoning = default;

//        Console.Write("What type of dish you want? Choose One.\n");
//        Console.Write("Soup, stew or Gumbo\n");
//        choice = Console.ReadLine();

//        if(choice.ToLower() == "soup") selectedType = Type.Soup;
//        if (choice.ToLower() == "stew") selectedType = Type.Stew;
//        if (choice.ToLower() == "gumbo") selectedType = Type.Gumbo;

//        Console.Write("What main ingredient do you want? Choose One.\n");
//        Console.Write("Mushrooms, chicken, carrots or potatoes.\n");
//        choice= Console.ReadLine();

//        if (choice.ToLower() == "mushrooms") selectedIngredients = Ingredients.Mushrooms;
//        if (choice.ToLower() == "chicken") selectedIngredients = Ingredients.Chicken;
//        if (choice.ToLower() == "carrots") selectedIngredients = Ingredients.Carrots;
//        if (choice.ToLower() == "potatoes") selectedIngredients = Ingredients.Potatoes;

//        Console.Write("What main seasoning do you want? Choose One.\n");
//        Console.Write("Spicy, salty or sweet.\n");
//        choice = Console.ReadLine();

//        if (choice.ToLower() == "spicy") selectedSeasoning = Seasoning.Spicy;
//        if (choice.ToLower() == "salty") selectedSeasoning = Seasoning.Spicy;
//        if (choice.ToLower() == "sweet") selectedSeasoning = Seasoning.Sweet;

//        return new (selectedType, selectedIngredients, selectedSeasoning);
//    }
//}

//var (type, ingredient, seasoning) = PickMenu();
//Console.WriteLine($"\nYou picked: {seasoning}, {ingredient}, {type}");

//enum Type
//{
//    Soup,
//    Stew, 
//    Gumbo
//}

//enum Ingredients
//{
//    Mushrooms,
//    Chicken,
//    Carrots,
//    Potatoes
//}

//enum Seasoning
//{
//    Spicy,
//    Salty,
//    Sweet
//}

//Classes
//float customizeArrow()
//{
//    while (true)
//    {
//        string arrowChoice, fletchlingChoice;
//        int shaftChoice;
//        ArrowHead arrowHead = default;
//        Fletchling fletchling = default;
//        Shaft shaft = default;
//        Arrow arrow = new Arrow(arrowHead, fletchling, shaft);

//        Console.WriteLine("Choose one arrow from the custom template:");
//        Console.WriteLine("Beginner\nMarksman\nElite");
//        Console.WriteLine("Choose between the options above: type \"beginner\" or any of the other options");
//        Console.WriteLine("Type \"custom\" if you want to make a custom arrow.");
//        string choice = Console.ReadLine();

//        if (choice.ToLower() == "beginner")
//        {
//            Arrow beginnerArrow = Arrow.CreateBeginnerArrow();
//            float beginnerCost = beginnerArrow.GetCost();
//            return beginnerCost;
//        }

//        if (choice.ToLower() == "marksman")
//        {
//            Arrow marksmanArrow = Arrow.CreateMarksmanArrow();
//            float marksmanCost = marksmanArrow.GetCost();
//            return marksmanCost;
//        }

//        if (choice.ToLower() == "elite")
//        {
//            Arrow eliteArrow = Arrow.CreateEliteArrow();
//            float eliteCost = eliteArrow.GetCost();
//            return eliteCost;
//        }

//        // Create a custom arrow
//        if (choice.ToLower() == "custom")
//        {
//            // Choose an Arrow
//            while (true)
//            {
//                Console.WriteLine("Pick an Arrow Head");
//                Console.WriteLine("Steel, Wood or Obsidian?");
//                arrowChoice = Console.ReadLine();
//                if (arrowChoice.ToLower() == "steel")
//                {
//                    arrow.ArrowHead = ArrowHead.Steel;
//                    break;
//                }
//                else if (arrowChoice.ToLower() == "wood")
//                {
//                    arrow.ArrowHead = ArrowHead.Wood;
//                    break;
//                }
//                else if (arrowChoice.ToLower() == "obsidian")
//                {
//                    arrow.ArrowHead = ArrowHead.Obsidian;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Invalid Option.");
//                }
//            }

//            // Choose Fletchling
//            while (true)
//            {
//                Console.WriteLine("Pick an Arrow Fletchling");
//                Console.WriteLine("Plastic, Turkey Feathers or Goose Feathers?");
//                fletchlingChoice = Console.ReadLine();
//                if (fletchlingChoice.ToLower().Trim() == "plastic")
//                {
//                    arrow.Fletchling = Fletchling.Plastic;
//                    break;
//                }
//                else if (fletchlingChoice.ToLower().Trim() == "turkey feathers")
//                {
//                    arrow.Fletchling = Fletchling.TurkeyFeathers;
//                    break;
//                }
//                else if (fletchlingChoice.ToLower().Trim() == "goose feathers")
//                {
//                    arrow.Fletchling = Fletchling.GooseFeathers;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Invalid Option.");
//                }
//            }

//            // Choose a Shaft
//            while (true)
//            {
//                Console.WriteLine("Pick an Arrow Shaft Lenght");
//                Console.WriteLine("60 or 100?");
//                shaftChoice = Convert.ToInt32(Console.ReadLine());
//                if (shaftChoice == 60)
//                {
//                    arrow.Length = Shaft.Short;
//                    break;
//                }
//                else if (shaftChoice == 100)
//                {
//                    arrow.Length = Shaft.Long;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Invalid Option.");
//                }
//            }
//        }

//        float cost = arrow.GetCost();

//        return cost;
//    }
//}

//float cost = customizeArrow();

//Console.WriteLine($"You arrow will cost roughly {cost} gold");


//class Arrow
//{
//    public ArrowHead ArrowHead { get; set; }
//    public Fletchling Fletchling { get; set; }
//    public Shaft Length { get; set; }

//    public Arrow(ArrowHead arrowHead, Fletchling fletchling, Shaft length)
//    {
//        ArrowHead = arrowHead;
//        Fletchling = fletchling;
//        Length = length;
//    }

//    public static Arrow CreateEliteArrow()
//    {
//        ArrowHead arrowHead = ArrowHead.Steel;
//        Fletchling fletchling = Fletchling.Plastic;
//        Shaft length = Shaft.Elite;

//        return new Arrow(arrowHead, fletchling, length);
//    }

//    public static Arrow CreateBeginnerArrow()
//    {
//        ArrowHead arrowHead = ArrowHead.Wood;
//        Fletchling fletchling = Fletchling.GooseFeathers;
//        Shaft length = Shaft.Beginner;

//        return new Arrow(arrowHead, fletchling, length);
//    }

//    public static Arrow CreateMarksmanArrow()
//    {
//        ArrowHead arrowHead = ArrowHead.Steel;
//        Fletchling fletchling = Fletchling.GooseFeathers;
//        Shaft length = Shaft.Marksman;

//        return new Arrow(arrowHead, fletchling, length);
//    }

//    public float GetCost()
//    {
//        float cost = 0;

//        if (ArrowHead == ArrowHead.Steel) cost += 10;
//        if (ArrowHead == ArrowHead.Wood) cost += 3;
//        if (ArrowHead == ArrowHead.Obsidian) cost += 5;

//        if (Fletchling == Fletchling.Plastic) cost += 10;
//        if (Fletchling == Fletchling.TurkeyFeathers) cost += 5;
//        if (Fletchling == Fletchling.GooseFeathers) cost += 3;

//        if (Length == Shaft.Long)
//            cost += (float)Shaft.Long * 0.05f;
//        else if (Length == Shaft.Short)
//            cost += (float)Shaft.Short * 0.05f;

//        return cost;
//    }
//}

//enum ArrowHead
//{
//    Steel,
//    Wood,
//    Obsidian
//}

//enum Shaft
//{
//    Long = 100,
//    Short = 60,
//    Beginner = 75,
//    Marksman = 65,
//    Elite = 95,
//}

//enum Fletchling
//{
//    Plastic,
//    TurkeyFeathers,
//    GooseFeathers
//}

// LEVEL 24 CHALLENGES
//Point newPoint = new Point(2, 3);
//Point anotherPoint = new Point(-4, 0);

//Console.WriteLine($"The points are: ({newPoint.X},{newPoint.Y})");

//class Point
//{
//    public int X { get; set; }
//    public int Y { get; set; }

//    public Point(int pointX, int pointY)
//    {
//        X = pointX;
//        Y = pointY;
//    }

//    // Create a point in the middle when no arguments are given
//    public Point()
//    {
//        X = 0;
//        Y = 0;
//    }
//}

// Color challenge
//Color[] newColor = [new Color(255, 255, 0), Color.CreateRed()];


//Color[] colors = new Color[newColor.Length];

//foreach (Color color in newColor)
//{
//    Console.WriteLine($"{color.Red}, {color.Blue}, {color.Green}");
//}

//class Color
//{
//    public int Red { get; set; } = 0;
//    public int Blue { get; set; } = 0;
//    public int Green { get; set; } = 0;

//    public Color(int red, int blue, int green)
//    {
//        Red = red;
//        Blue = blue;
//        Green = green;
//    }

//    public static Color CreateWhite()
//    {
//        return new Color(255, 255, 255);
//    }

//    public static Color CreateBlack()
//    {
//        return new Color(0, 0, 0);
//    }

//    public static Color CreateRed()
//    {
//        return new Color(255, 0, 0);
//    }

//    public static Color CreateOrange()
//    {
//        return new Color(255, 165, 0);
//    }

//    public static Color CreateYellow()
//    {
//        return new Color(255, 255, 0);
//    }

//    public static Color CreateGreen()
//    {
//        return new Color(0, 128, 0);
//    }

//    public static Color CreateBlue()
//    {
//        return new Color(0, 0, 255);
//    }

//    public static Color CreatePurple()
//    {
//        return new Color(128, 0, 128);
//    }
//}

// TIC-TAC-TOE

Game game = new Game();
game.Run();

class Game
{
    private Board board = new Board();
    private char currentPlayer = 'X';

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            board.DrawBoard();
            Console.WriteLine($"\nPlayer {currentPlayer}, choose your position (e.g., A1, B2):");
            string input = Console.ReadLine();

            if (!board.PlaceMark(input, currentPlayer))
            {
                Console.WriteLine("Invalid move. Press Enter to try again...");
                Console.ReadLine();
                continue;
            }

            if (board.CheckWin(currentPlayer))
            {
                Console.Clear();
                board.DrawBoard();
                Console.WriteLine($"\n🎉 Player {currentPlayer} wins!");
                break;
            }

            if (board.IsFull())
            {
                Console.Clear();
                board.DrawBoard();
                Console.WriteLine("\nIt's a draw!");
                break;
            }

            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }
}

class Board
{
    public char[,] Grid { get; set; } = new char[3, 3];

    public Board()
    {
        for (int row = 0; row < 3; row++)
            for (int col = 0; col < 3; col++)
                Grid[row, col] = ' ';
    }

    public void DrawBoard()
    {
        Console.WriteLine("    A   B   C");

        for (int row = 0; row < 3; row++)
        {
            Console.Write($"{row + 1}  ");
            for (int col = 0; col < 3; col++)
            {
                Console.Write(Grid[row, col]);
                if (col < 2) Console.Write(" | ");
            }

            Console.WriteLine();
            if (row < 2) Console.WriteLine("   ---+---+---");
        }
    }

    public bool PlaceMark(string position, char symbol)
    {
        position = position.ToUpper().Trim();

        if (position.Length != 2)
            return false;

        int col = -1;
        int row = -1;

        char colChar = position[0];
        char rowChar = position[1];

        if (colChar == 'A') col = 0;
        else if (colChar == 'B') col = 1;
        else if (colChar == 'C') col = 2;
        else return false;

        if (rowChar == '1') row = 0;
        else if (rowChar == '2') row = 1;
        else if (rowChar == '3') row = 2;
        else return false;

        if (Grid[row, col] != ' ')
            return false;

        Grid[row, col] = symbol;
        return true;
    }

    public bool IsFull()
    {
        for (int row = 0; row < 3; row++)
            for (int col = 0; col < 3; col++)
                if (Grid[row, col] == ' ')
                    return false;
        return true;
    }

    public bool CheckWin(char symbol)
    {
        // Check rows
        for (int row = 0; row < 3; row++)
            if (Grid[row, 0] == symbol && Grid[row, 1] == symbol && Grid[row, 2] == symbol)
                return true;

        // Check columns
        for (int col = 0; col < 3; col++)
            if (Grid[0, col] == symbol && Grid[1, col] == symbol && Grid[2, col] == symbol)
                return true;

        // Diagonals
        if (Grid[0, 0] == symbol && Grid[1, 1] == symbol && Grid[2, 2] == symbol)
            return true;

        if (Grid[0, 2] == symbol && Grid[1, 1] == symbol && Grid[2, 0] == symbol)
            return true;

        return false;
    }
}



