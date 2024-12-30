namespace MyQuizApp;

class Program
{
    static void Main(string[] args)
    {
        Question[] questions = new Question[]
        {
            new Question("What is the capital of France?",
            new String[] {"Paris", "Berlin", "London"},
            0),
            new Question("What is 2 + 2?",
                new String[] {"1", "2", "4", "8"},
                2)
    
        };
        
        Quiz myQuiz = new Quiz(questions);
        myQuiz.StartQuiz();

    }
}