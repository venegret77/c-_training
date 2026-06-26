using CsharpLecture2Practice;

Console.WriteLine ("Введите число от 0 до 3");
var userInput = Console.ReadLine();

var isValid = Lecture2Exercises.TryParseUserChoice(userInput, out var userChoice);

var computerChoice = Random.Shared.Next(1, 4);

Console.WriteLine(Lecture2Exercises.ChoiceToString(userChoice));
Console.WriteLine(Lecture2Exercises.ChoiceToString(computerChoice));

Console.WriteLine(Lecture2Exercises.GetRoundResultText(userChoice, computerChoice));