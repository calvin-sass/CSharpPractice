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
    GamePlay("Player 2, it is your turn.", playersChoice);
}

void GamePlay(string text, int playersChoice)
{
    // Gameplay variables
    int round = 1;
    int cityHealth = 15;
    int manticore = 10;
    int damage = 1;

    Console.WriteLine(text);
    Console.WriteLine(new string('-', 30)); // 30 dashes

    // Calculate the damage each round
    int CalculateDamage(int round)
    {
        if (round % 3 == 0 & round % 5 == 0)
        {
            damage = 10;
            return damage;
        }
        else if (round % 3 == 0 || round % 5 == 0)
        {
            damage = 3;
            return damage;
        } else
        {
            damage = 1;
            return damage;
        }
    }

    while(true)
    {
        damage = CalculateDamage(round);

        Console.WriteLine($"STATUS: Round: {round} City: {cityHealth} Manticore: {manticore}");
        Console.WriteLine($"The canon is expected to deal {damage} damage this round");
        Console.Write("Enter desired cannon range: ");
        int player2Choice = Convert.ToInt32(Console.ReadLine());

        // Applies damage according to DIRECT HITS and ROUND
        if (player2Choice == playersChoice)
        {
            if (round % 3 == 0 & round % 5 == 0)
            {
                manticore -= damage;
                Console.WriteLine("Ultimate fire-electric blast DIRECT HIT! K.O!");
            }
            else if (round % 3 == 0 || round % 5 == 0)
            {
                manticore -= damage;
                Console.WriteLine("That round was a DIRECT HIT!");
            }
            else
            {
                manticore -= damage;
                Console.WriteLine("That round was a DIRECT HIT!");
            }
        }
        else if (player2Choice > playersChoice)
        {
            Console.WriteLine("That round OVERSHOT the target.");
        }
        else if (player2Choice < playersChoice)
        {
            Console.WriteLine("That round FELL SHORT of the target.");
        }

        // GAME OVER
        if (cityHealth <= 0)
        {
            Console.Write("The Manticore was victorious! The city of Consolas is destroyed!\nGAME OVER");
            return;
        }

        // GAME WON
        if (manticore <= 0)
        {
            Console.WriteLine("The manticore has been destroyed! The city of Consolas has been saved!");
            return;
        }

        cityHealth--;
        round++;

        Console.WriteLine(new string('-', 30)); // 30 dashes
    } 
}

StartGame("Player 1, how far away from the city do you want to station the Manticore? ");
