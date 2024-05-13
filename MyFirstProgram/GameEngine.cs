

using MyFirstProgram.Models;

namespace MyFirstProgram
{
    internal class GameEngine
    {
       internal void DivisionGame(string message)
        {
            var startTime = DateTime.Now;  // Capture start time
            var score = 0;
            var difficulty = Helpers.getDifficultyLevel();
            int numberOfQuestions = Helpers.numberOfQuestions();
         
                for (int i = 0; i < numberOfQuestions; i++)
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
                    if (i == numberOfQuestions-1)
                    {
                     
                        Console.WriteLine($"Game over.Your final score is {score}");
                    }
                }
           

            var endTime = DateTime.Now;  // Capture end time
            var totalSeconds = Math.Round((endTime - startTime).TotalSeconds, 2);  // Calculate total time

            Helpers.AddToHistory(score, GameType.Division, difficulty, totalSeconds);


        }

       

        internal void MultiplicationGame(string message)
        {
            int numberOfQuestions = Helpers.numberOfQuestions();
            var startTime = DateTime.Now;  // Capture start time
            var difficulty = Helpers.getDifficultyLevel();
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < numberOfQuestions; i++)
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
                if (i == numberOfQuestions-1)
                {
                    Console.WriteLine($"Game over.Your final score is {score}");
                }
            }
            var endTime = DateTime.Now;  // Capture end time
            var totalSeconds = Math.Round((endTime - startTime).TotalSeconds, 2);  // Calculate total time

            Helpers.AddToHistory(score, GameType.Multiplication, difficulty, totalSeconds);
        }

        internal void SubstractionGame(string message)
        {
            int numberOfQuestions = Helpers.numberOfQuestions();
            var startTime = DateTime.Now;  // Capture start time
            var difficulty = Helpers.getDifficultyLevel();
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < numberOfQuestions; i++)
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
                if (i == numberOfQuestions-1)
                {
                    Console.WriteLine($"Game over.Your final score is {score}");
                }
            }
            var endTime = DateTime.Now;  // Capture end time
            var totalSeconds = Math.Round((endTime - startTime).TotalSeconds, 2);  // Calculate total time

            Helpers.AddToHistory(score, GameType.Substraction, difficulty, totalSeconds);
        }

        internal void AdditionGame(string message)
        {
            int numberOfQuestions = Helpers.numberOfQuestions();
            var startTime = DateTime.Now;  // Capture start time
            var difficulty = Helpers.getDifficultyLevel();
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;
            for (int i = 0; i < numberOfQuestions; i++)
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
                if (i == numberOfQuestions-1)
                {
                    Console.WriteLine($"Game over.Your final score is {score}. Press any key to go back to the main menu");
                    Console.ReadLine();
                }

            }
            var endTime = DateTime.Now;  // Capture end time
            var totalSeconds = Math.Round((endTime - startTime).TotalSeconds, 2);  // Calculate total time

            Helpers.AddToHistory(score, GameType.Addition, difficulty, totalSeconds);
        }

    }

    }

