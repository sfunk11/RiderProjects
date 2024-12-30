namespace MyQuizApp;

public class Quiz
{
    private Question[] _questions;

    public Quiz(Question[] questions)
    {
        this._questions = questions;
    }

    private int _score = 0;

    public void StartQuiz()
    {
        Console.WriteLine("Welcome to my quiz!");
        int questionNumber = 1;
        foreach (Question question in _questions)
        {
            Console.WriteLine($"Question {questionNumber++}:");
            DisplayQuestion(question);
            int userChoice = GetUserChoice();
            if(question.IsCorrectAnswer(userChoice))
            {
                Console.WriteLine("Correct!");
                _score++;
            }else
            {
                Console.WriteLine($"Wrong! The correct answer is {question.Answers[question.CorrectAnswerIndex]}    ");
            }
        }

        DisplayResults();

    }
    private void DisplayQuestion(Question question)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Question                                ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.WriteLine(question.QuestionText);

        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"    {i + 1}. {question.Answers[i]}");
        }
  
    }

    private int GetUserChoice()
    {
        Console.Write("Your answer (number):   ");
        string input = Console.ReadLine();
        int choice = 0;
        while (!int.TryParse(input, out choice)|| choice < 1 || choice > 4)
        {
            Console.WriteLine("Please input a valid choice .");
        }

        return choice - 1; //Adjust to match index
    }

    private void DisplayResults()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                                 Results                                 ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine($"Quiz finished. Your score is {_score} out of {_questions.Length}");
    }
}