namespace DelegatesAndEvents;

public delegate int Comparison<T>(T x, T y);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
}

public class PersonSorter
{
    public void Sort(Person[] people, Comparison<Person> comparison)
    {
        for (int i = 0; i < people.Length - 1; i++)
        {
            for (int j = i + 1; j < people.Length; j++)
            {
                if (comparison(people[i], people[j]) > 0)
                {
                    Person temp = people[i];
                    people[i] = people[j];
                    people[j] = temp;
                }
            }
        } 
    }
}



public class SortingAlgoMain
{

    static int CompareByAge(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }

    static int CompareByName(Person x, Person y)
    {
        return x.Name.CompareTo(y.Name);
    }

    static void iMain(string[] args)
    {
        Person[] people =
        {
            new Person { Name = "James", Age = 29 },
            new Person { Name = "Jack", Age = 45 },
            new Person { Name = "Jill", Age = 35 }
        };
        new PersonSorter().Sort(people, CompareByAge);

        foreach (var Person in people){
            Console.WriteLine(Person.Name + "," +  Person.Age);
            
        }
        
        new PersonSorter().Sort(people, CompareByName);
        foreach (var Person in people)
        {
            Console.WriteLine(Person.Name + "," +  Person.Age);
        }
    }
    
}