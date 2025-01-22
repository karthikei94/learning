public delegate bool EligibleToPromotion(Employee employeeToPromotion);
public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Experience { get; set; }
    public int Salary { get; set; }

    public static void PromoteEmployee(List<Employee> employees, EligibleToPromotion IsEmployeeEligible)
    {
        foreach (Employee employee in employees)
        {
            if (IsEmployeeEligible(employee))
                System.Console.WriteLine($"Employee {employee.Name} Promoted");
        }
    }
}

class DelegateRealWorldExector
{

    public static void Execute()
    {
        Employee emp1 = new Employee()
        {
            ID = 101,
            Name = "Pranaya",
            Gender = "Male",
            Experience = 5,
            Salary = 10_000
        };
        Employee emp2 = new Employee()
        {
            ID = 102,
            Name = "Priyanka",
            Gender = "Female",
            Experience = 10,
            Salary = 20_000
        };
        Employee emp3 = new Employee()
        {
            ID = 103,
            Name = "Anurag",
            Experience = 15,
            Salary = 30_000
        };
        List<Employee> lstEmployess = [emp1, emp2, emp3];

        EligibleToPromotion eligibleToPromotion = new(DelegateRealWorldExector.Promote);
        Employee.PromoteEmployee(lstEmployess, eligibleToPromotion);

    }

    public static bool Promote(Employee employee) => employee.Salary > 10_000;

}
class DelegateUsingLambdaRealWorldExector
{
    public static void Execute()
    {
        Employee emp1 = new Employee()
        {
            ID = 101,
            Name = "Pranaya",
            Gender = "Male",
            Experience = 5,
            Salary = 10_000
        };
        Employee emp2 = new Employee()
        {
            ID = 102,
            Name = "Priyanka",
            Gender = "Female",
            Experience = 10,
            Salary = 20_000
        };
        Employee emp3 = new Employee()
        {
            ID = 103,
            Name = "Anurag",
            Experience = 15,
            Salary = 30_000
        };
        List<Employee> lstEmployess = [emp1, emp2, emp3];
        Employee.PromoteEmployee(lstEmployess, employee => employee.Experience > 5);

    }

}