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

