//int AskForNumber(string text)
//{
//    while (true)
//    {
//        Console.WriteLine(text);
//        int answer = Convert.ToInt32(Console.ReadLine());

//        if (answer == 4)
//            return answer;

//        if (answer != 4)
//            Console.WriteLine("Incorrect. Try again.");

//        continue;
//    }
//}

//int result = AskForNumber("What is 2 + 2?");
//Console.WriteLine($"Congratulations, your answer is correct! {result}");

//int AskForNumberInRange(string text, int min, int max)
//{
//    while (true)
//    {
//        Console.WriteLine($"{text} {min} and {max}");

//        int answer = Convert.ToInt32(Console.ReadLine());

//        if (answer < min || answer > max)
//            continue;
//        else
//            Console.Write($"Your number is: ");
//            return answer;
//    }
//}

//int result = AskForNumberInRange("Enter a number between ", 1, 10);
//Console.WriteLine(result);

// Count down to one using recursion
//void CountDown(int num)
//{
//    if (num == 0) return; // Base case: stop at 0

//    Console.WriteLine(num); // Print current number
//    CountDown(num - 1);     // Recursive call
//}

//CountDown(10);

// END OF PART CHALLENGE
void StartGame(string text)
{
    Console.Write(text);
    int playersChoice = Convert.ToInt32(Console.ReadLine());
    string message = GamePlay("Player 2, it is your turn.", playersChoice);
    Console.WriteLine(message);
}

string GamePlay(string text, int playersChoice)
{
    // Gameplay variables
    int round = 1;
    int cityHealth = 15;
    int manticore = 10;

    Console.WriteLine(text);
    Console.WriteLine(new string('-', 30)); // 30 dashes

    // Calculate the damage each round
    int CalculateDamage(int round)
    {
        if (round % 3 == 0 & round % 5 == 0) return 10;
        else if (round % 3 == 0 || round % 5 == 0) return 3;
        return 1;
    }

    // Game Loop
    while(manticore > 0 && cityHealth > 0)
    {
        int damage = CalculateDamage(round);

        Console.WriteLine($"STATUS: Round: {round} City: {cityHealth} Manticore: {manticore}");
        Console.WriteLine($"The canon is expected to deal {damage} damage this round");
        Console.Write("Enter desired cannon range: ");
        int player2Choice = Convert.ToInt32(Console.ReadLine());

        // Applies damage according to DIRECT HITS and ROUND
        if (player2Choice == playersChoice)
        {
            manticore -= damage;
            Console.WriteLine(round % 3 == 0 && round % 5 == 0
                ? "Ultimate fire-electric blast DIRECT HIT! K.O!"
                : "That round was a DIRECT HIT!");
        }
        else if (player2Choice > playersChoice)
        {
            Console.WriteLine("That round OVERSHOT the target.");
        }
        else if (player2Choice < playersChoice)
        {
            Console.WriteLine("That round FELL SHORT of the target.");
        }

        cityHealth--;
        round++;

        Console.WriteLine(new string('-', 30)); // 30 dashes
    }

    // End Result
    string message = manticore switch
    {
        <= 0 => "The manticore has been destroyed! The city of Consolas has been saved!\nYOU WON!",
        _ => "The Manticore was victorious! The city of Consolas is destroyed!\nGAME OVER",
    };

    return message;
}

StartGame("Player 1, how far away from the city do you want to station the Manticore? ");
