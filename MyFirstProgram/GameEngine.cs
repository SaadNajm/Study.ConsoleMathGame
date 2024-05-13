

using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class GameEngine
    {
       internal void DivisionGame(string message)
        {
            var score = 0;
            var difficulty = Helpers.getDifficultyLevel();
            for (int i = 0; i < 5; i++)
            {

                
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];
                Console.WriteLine($"{firstNumber}/{secondNumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 1)
                {
                    Console.WriteLine($"Game over.Your final score is {score}");
                }
            }
            Helpers.AddToHistory(score, GameType.Division,difficulty);


        }

       

        internal void MultiplicationGame(string message)
        {
            var difficulty = Helpers.getDifficultyLevel();
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over.Your final score is {score}");
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication,difficulty);
        }

        internal void SubstractionGame(string message)
        {
            var difficulty = Helpers.getDifficultyLevel();
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over.Your final score is {score}");
                }
            }
            Helpers.AddToHistory(score, GameType.Substraction,difficulty);
        }

        internal void AdditionGame(string message)
        {
            var difficulty = Helpers.getDifficultyLevel();
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();
                while(string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _)) {
                    Console.WriteLine("Your answer needs to be an integer. Try again.");
                    result = Console.ReadLine();
                }
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }
                if (i == 4)
                {
                    Console.WriteLine($"Game over.Your final score is {score}. Press any key to go back to the main menu");
                    Console.ReadLine();
                }

            }
            Helpers.AddToHistory(score, GameType.Addition, difficulty);

        }

    }
}
