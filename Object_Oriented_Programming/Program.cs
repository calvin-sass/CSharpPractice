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
float customizeArrow()
{
    while (true)
    {
        string arrowChoice, fletchlingChoice;
        int shaftChoice;
        ArrowHead arrowHead = default;
        Fletchling fletchling = default;
        Shaft shaft = default;
        Arrow arrow = new Arrow(arrowHead, fletchling, shaft);

        Console.WriteLine("Choose one arrow from the custom template:");
        Console.WriteLine("Beginner\nMarksman\nElite");
        Console.WriteLine("Choose between the options above: type \"beginner\" or any of the other options");
        Console.WriteLine("Type \"custom\" if you want to make a custom arrow.");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "beginner")
        {
            Arrow beginnerArrow = Arrow.CreateBeginnerArrow();
            float beginnerCost = beginnerArrow.GetCost();
            return beginnerCost;
        }

        if (choice.ToLower() == "marksman")
        {
            Arrow marksmanArrow = Arrow.CreateMarksmanArrow();
            float marksmanCost = marksmanArrow.GetCost();
            return marksmanCost;
        }

        if (choice.ToLower() == "elite")
        {
            Arrow eliteArrow = Arrow.CreateEliteArrow();
            float eliteCost = eliteArrow.GetCost();
            return eliteCost;
        }

        // Create a custom arrow
        if (choice.ToLower() == "custom")
        {
            // Choose an Arrow
            while (true)
            {
                Console.WriteLine("Pick an Arrow Head");
                Console.WriteLine("Steel, Wood or Obsidian?");
                arrowChoice = Console.ReadLine();
                if (arrowChoice.ToLower() == "steel")
                {
                    arrow.ArrowHead = ArrowHead.Steel;
                    break;
                }
                else if (arrowChoice.ToLower() == "wood")
                {
                    arrow.ArrowHead = ArrowHead.Wood;
                    break;
                }
                else if (arrowChoice.ToLower() == "obsidian")
                {
                    arrow.ArrowHead = ArrowHead.Obsidian;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option.");
                }
            }

            // Choose Fletchling
            while (true)
            {
                Console.WriteLine("Pick an Arrow Fletchling");
                Console.WriteLine("Plastic, Turkey Feathers or Goose Feathers?");
                fletchlingChoice = Console.ReadLine();
                if (fletchlingChoice.ToLower().Trim() == "plastic")
                {
                    arrow.Fletchling = Fletchling.Plastic;
                    break;
                }
                else if (fletchlingChoice.ToLower().Trim() == "turkey feathers")
                {
                    arrow.Fletchling = Fletchling.TurkeyFeathers;
                    break;
                }
                else if (fletchlingChoice.ToLower().Trim() == "goose feathers")
                {
                    arrow.Fletchling = Fletchling.GooseFeathers;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option.");
                }
            }

            // Choose a Shaft
            while (true)
            {
                Console.WriteLine("Pick an Arrow Shaft Lenght");
                Console.WriteLine("60 or 100?");
                shaftChoice = Convert.ToInt32(Console.ReadLine());
                if (shaftChoice == 60)
                {
                    arrow.Length = Shaft.Short;
                    break;
                }
                else if (shaftChoice == 100)
                {
                    arrow.Length = Shaft.Long;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option.");
                }
            }
        }

        float cost = arrow.GetCost();

        return cost;
    }
}

float cost = customizeArrow();

Console.WriteLine($"You arrow will cost roughly {cost} gold");


class Arrow
{
    public ArrowHead ArrowHead { get; set; }
    public Fletchling Fletchling { get; set; }
    public Shaft Length { get; set; }

    public Arrow(ArrowHead arrowHead, Fletchling fletchling, Shaft length)
    {
        ArrowHead = arrowHead;
        Fletchling = fletchling;
        Length = length;
    }

    public static Arrow CreateEliteArrow()
    {
        ArrowHead arrowHead = ArrowHead.Steel;
        Fletchling fletchling = Fletchling.Plastic;
        Shaft length = Shaft.Elite;

        return new Arrow(arrowHead, fletchling, length);
    }

    public static Arrow CreateBeginnerArrow()
    {
        ArrowHead arrowHead = ArrowHead.Wood;
        Fletchling fletchling = Fletchling.GooseFeathers;
        Shaft length = Shaft.Beginner;

        return new Arrow(arrowHead, fletchling, length);
    }

    public static Arrow CreateMarksmanArrow()
    {
        ArrowHead arrowHead = ArrowHead.Steel;
        Fletchling fletchling = Fletchling.GooseFeathers;
        Shaft length = Shaft.Marksman;

        return new Arrow(arrowHead, fletchling, length);
    }

    public float GetCost()
    {
        float cost = 0;

        if (ArrowHead == ArrowHead.Steel) cost += 10;
        if (ArrowHead == ArrowHead.Wood) cost += 3;
        if (ArrowHead == ArrowHead.Obsidian) cost += 5;

        if (Fletchling == Fletchling.Plastic) cost += 10;
        if (Fletchling == Fletchling.TurkeyFeathers) cost += 5;
        if (Fletchling == Fletchling.GooseFeathers) cost += 3;

        if (Length == Shaft.Long)
            cost += (float)Shaft.Long * 0.05f;
        else if (Length == Shaft.Short)
            cost += (float)Shaft.Short * 0.05f;

        return cost;
    }
}

enum ArrowHead
{
    Steel,
    Wood,
    Obsidian
}

enum Shaft
{
    Long = 100,
    Short = 60,
    Beginner = 75,
    Marksman = 65,
    Elite = 95,
}

enum Fletchling
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}




