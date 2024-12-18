namespace WeatherStationSimulator;

class Program
{




    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of days to simulate the weather");

        int days = int.Parse(Console.ReadLine());

        int[] temperatures = new int[days];

        string[] conditions = { "Sunny", "Rainy", "Snowy", "Cloudy" };
        string[] weatherConditions = new string[days];

        Random random = new Random();

        for (int i = 0; i < days; i++)
        {
            temperatures[i] = random.Next(-10, 100);
            weatherConditions[i] = conditions[random.Next(conditions.Length)];
            Console.WriteLine($"Temperature: {temperatures[i]} degrees and Condition: {weatherConditions[i]}");

        }

        Console.WriteLine($"The average temperature was {GetAverageTemperature(temperatures)} degrees");
        Console.WriteLine($"The highest temperature was {temperatures.Max()} degrees");
        Console.WriteLine($"The lowest temperature was {temperatures.Min()} degrees");
        Console.WriteLine($"The most common condition was {MostCommonCondition(conditions)}");

    }

    static double GetAverageTemperature(int[] temperatures)
    {
        double sum = 0;
        foreach (int temp in temperatures)
        {
            sum += temp;
        }

        return sum / temperatures.Length;
    }

    static string MostCommonCondition(string[] conditions)
    {
        int count = 0;
        string mostCommon = conditions[0];

        for (int i = 0; i < conditions.Length; i++)
        {
            int tempCount = 0;
            for (int j = 0; j < conditions.Length; j++)
            {
                if (conditions[j] == conditions[i])
                {
                    tempCount++;
                }
            }

            if (tempCount > count)
            {
                count = tempCount;
                mostCommon = conditions[i];
            }
        }
        return mostCommon;
    }
} 