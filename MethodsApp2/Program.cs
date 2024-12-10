namespace MethodsApp2;

internal class Program
{
    static void Main(string[] args)
    {

       

        AddTwoValues(4,7);

        Console.WriteLine(" The method returned the sum of " + AddTwoValuesAndReturn(4,7));
    }
    
   static void AddTwoValues(int value1, int value2)
    {
        int sum = value1 + value2;
        Console.WriteLine("This method writes the sum of " + sum);
    }

    int AddTwoValuesAndReturn(int value1, int value2)
    {
        int sum = value1 + value2;
        return sum;
    }
}