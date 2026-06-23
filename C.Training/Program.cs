Console.WriteLine("Hello this is Rock Paper Scissors");

Console.WriteLine("Enter your rounds count:");
var userInputRoundsCount = Console.ReadLine();

int roundsCount;

while (!int.TryParse(userInputRoundsCount, out roundsCount) || roundsCount <= 0)
{
    Console.Clear();
    
    Console.WriteLine("Invalid input");
    Console.WriteLine("Enter your rounds count:");
    userInputRoundsCount = Console.ReadLine();
}

Console.WriteLine("Enter your step");


var userWinsCount = 0;
var userLoseCount = 0;
var userDrawCount = 0;

while (userWinsCount + userLoseCount + userDrawCount <= roundsCount)
{
    Console.Clear();

    if (userWinsCount != 0 || userLoseCount != 0)
    {
        Console.WriteLine($"You wins {userWinsCount}");
        Console.WriteLine($"Computer wins {userLoseCount}");
    }

    if (userWinsCount > (roundsCount - userDrawCount) / 2)
    {
        Console.WriteLine("You won!");
        
        Thread.Sleep(3000); //чтобы увидеть сообщение выше
        
        return;
    }
    
    if (userLoseCount > (roundsCount - userDrawCount) / 2)
    {
        Console.WriteLine("You loose(");
        
        Thread.Sleep(3000); //чтобы увидеть сообщение выше
        
        return;
    }

    Console.WriteLine("1 - Rock");
    Console.WriteLine("2 - Paper");
    Console.WriteLine("3 - Scissors");
    Console.WriteLine("4 - Well");
    Console.WriteLine("0 - Exit");

    var userInput = Console.ReadLine(); // "5"

    int userChoice;

    // parse user input = string into int 
    // put result to out result param
    // return if parse was successful

    if (!int.TryParse(userInput, out userChoice) || !(userChoice >= 0 && userChoice <= 4))
    {
        Console.WriteLine("Invalid input");
        continue;
    }

    if (userChoice == 0)
    {
        return;
    }

    var random = new Random();
    var computerChoice = random.Next(1, 5); // generate random number 1-4

    string userChoiceString;
    switch (userChoice)
    {
        case 1:
            Console.WriteLine("Rock");
            userChoiceString = "Rock";
            break;
        case 2:
            userChoiceString = "Paper";
            break;
        case 3:
            userChoiceString = "Scissors";
            break;
        default:
            userChoiceString = "Well";
            break;
    }

    Console.WriteLine($"You chose {userChoiceString}");

    string computerChoiceString = computerChoice switch
    {
        1 => "Rock",
        2 => "Paper",
        3 => "Scissors",
        _ => "Well"
    };

    Console.WriteLine($"Computer chose {computerChoiceString}");

    if (computerChoice == userChoice)
    {
        Console.WriteLine("Draw");
        userDrawCount++;
    }
    else if (userChoice == 1 && computerChoice == 3 || userChoice == 2 && computerChoice == 1 ||
             userChoice == 3 && computerChoice == 2
             || userChoice == 4 && computerChoice == 1
             || userChoice == 4 && computerChoice == 3)
    {
        Console.WriteLine("You win");
        userWinsCount++;
    }
    else
    {
        Console.WriteLine("You lose");
        userLoseCount++;
    }
    
    Thread.Sleep(3000); // прочитал в интернете, что так можно сделать паузу в работе, чтобы видеть результаты раунда до очистки консоли

    // Ctrl + K + D 
}