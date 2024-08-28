
List<Employee> employees = new List<Employee>();

var manager1 = new Manager("Jess", 18023, 50000, 150);
employees.Add(manager1);

var developer1 = new Developer("Ophelia", 18340, 40000, "python");
employees.Add(developer1);

foreach (var employee in employees)
{
    
    IWorkable workableEmp = employee as IWorkable;
    if (workableEmp != null)
    {
        workableEmp.Work();
        workableEmp.TakeBreak();
    }

}

public interface IWorkable
{
    void Work();
    void TakeBreak();

}
public class Employee
{
    public string Name { get; }
    public int EmplyeeID { get; }
    public int Salary { get; }

   public Employee(string name, int emplyeeID, int salary)
   {
        Name = name;
        EmplyeeID = emplyeeID;
        Salary = salary;
   }

}

public class Manager : Employee, IWorkable
{
    int PeopleManaging { get; }
    public Manager(string name, int emplyeeID, int salary, int peopleManaging) : base(name, emplyeeID, salary)
    {
        PeopleManaging = peopleManaging;
    }

    public void Work() => Console.WriteLine("Working managing people");
    public void TakeBreak() => Console.WriteLine("Taking a break from managing");
}

public class Developer : Employee, IWorkable
{
    string ProgramLang { get; }
    public Developer(string name, int emplyeeID, int salary, string programLang) : base(name, emplyeeID, salary)
    {
        ProgramLang = programLang;
    }

    public void Work() => Console.WriteLine("Working developing applications");
    public void TakeBreak() => Console.WriteLine("Taking a break from coding");
}
