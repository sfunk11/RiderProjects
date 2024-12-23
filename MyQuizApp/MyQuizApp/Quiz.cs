namespace MyQuizApp;

public class Quiz
{
    private Question[] questions;

    public Quiz(Question[] questions)
    {
        this.questions = questions;
    }

    public void DisplayQuestion(Question question)
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

        if (GetUserChoice() == question.CorrectAnswerIndex)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Wrong!");
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
}