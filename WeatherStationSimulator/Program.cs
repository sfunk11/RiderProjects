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
          temperatures[i] = random.Next(-10,100);
          weatherConditions[i] = conditions[random.Next(conditions.Length)];
          Console.WriteLine($"Temperature: {temperatures[i]} and Condition: {weatherConditions[i]}");
      }
      
    }
}