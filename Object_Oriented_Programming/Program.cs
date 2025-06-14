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

// Classes
float customizeArrow()
{
    while(true)
    {
        string arrowChoice, fletchlingChoice;
        int shaftChoice;
        ArrowHead arrowHead = default;
        Fletchling fletchling = default;
        Shaft shaft = default;

        // Choose an Arrow
        while (true)
        {
            Console.WriteLine("Pick an Arrow Head");
            Console.WriteLine("Steel, Wood or Obsidian?");
            arrowChoice = Console.ReadLine();
            if (arrowChoice.ToLower() == "steel")
            {
                arrowHead = ArrowHead.Steel;
                break;
            }
            else if (arrowChoice.ToLower() == "wood")
            {
                arrowHead = ArrowHead.Wood;
                break;
            }
            else if (arrowChoice.ToLower() == "obsidian")
            {
                arrowHead = ArrowHead.Obsidian;
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
                fletchling = Fletchling.Plastic;
                break;
            }
            else if (fletchlingChoice.ToLower().Trim() == "turkey feathers")
            {
                fletchling = Fletchling.TurkeyFeathers;
                break;
            }
            else if (fletchlingChoice.ToLower().Trim() == "goose feathers")
            {
                fletchling = Fletchling.GooseFeathers;
                break;
            } else
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
                shaft = Shaft.Short;
                break;
            }
            else if (shaftChoice == 100)
            {
                shaft = Shaft.Long;
                break;
            } else
            {
                Console.WriteLine("Invalid Option.");
            }
        }

        Arrow newArrow = new Arrow(arrowHead, fletchling, shaft);

        float cost = newArrow.GetCost();

        return cost;
    }
}

float cost = customizeArrow();

Console.WriteLine($"You arrow will cost roughly {cost} gold");


class Arrow
{
    ArrowHead arrowHead;
    Fletchling fletchling;
    Shaft length;

    public Arrow(ArrowHead arrowHead, Fletchling fletchling, Shaft length)
    {
        this.arrowHead = arrowHead;
        this.fletchling = fletchling;
        this.length = length;
    }

    public float GetCost()
    {
        float cost = 0;

        if (arrowHead == ArrowHead.Steel) cost += 10;
        if (arrowHead == ArrowHead.Wood) cost += 3;
        if (arrowHead == ArrowHead.Obsidian) cost += 5;

        if (fletchling == Fletchling.Plastic) cost += 10;
        if (fletchling == Fletchling.TurkeyFeathers) cost += 5;
        if (fletchling == Fletchling.GooseFeathers) cost += 3;

        if (length == Shaft.Long)
            cost += (float)Shaft.Long * 0.05f;
        else if (length == Shaft.Short)
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
    Short = 60
}

enum Fletchling
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}

