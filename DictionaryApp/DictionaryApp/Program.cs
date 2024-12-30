namespace DictionaryApp;

class Program
{
    static void Main(string[] args)
    {
        // //Dictionary uses key value pair
        // Dictionary<int, string> employees = new Dictionary<int, string>();
        //
        // employees.Add(1, "Alex");
        // employees.Add(2, "Bob");
        //
        // string name = employees[1];
        //
        // Console.WriteLine(name);
        
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
         //update data in dictionary
         employees.Add(1,new Employee("Jane Smith", 30, 50000));
         employees.Add(2,new Employee("Joe Smith", 20, 500000));
         employees.Add(3,new Employee("Bob Smith", 40, 30000));
        
         foreach (KeyValuePair<int, Employee> e in employees)
         {
             Console.WriteLine(e.Value.Name);
         }
        
         employees.Remove(1);
        
         if (!employees.ContainsKey(1))
         {
             employees.Add(1, new Employee("Mike Smith", 30, 50000));
         }
        
         foreach (KeyValuePair<int, Employee> e in employees)
         {
             Console.WriteLine(e.Value.Name);
         }
        
         bool added =  employees.TryAdd(1, new Employee("Mike Smith", 30, 50000));
         if (!added)
         {
             Console.WriteLine("Could not add employee.");
        }
        
         if (employees.TryGetValue(2, out Employee employee))
         {
             Console.WriteLine(employee.Name);
         }
        
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}