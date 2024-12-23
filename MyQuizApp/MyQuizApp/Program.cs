namespace MyQuizApp;

class Program
{
    static void Main(string[] args)
    {
        Question[] questions = new Question[]
        {
            new Question("What is the capital of France?",
            new String[] {"Paris", "Berlin", "London"},
            0)
    
        };
        
        Quiz myQuiz = new Quiz(questions);
        myQuiz.DisplayQuestion(questions[0]);

    }
}