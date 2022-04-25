
class Program
{
    public static void Main()
    {
        Employee emp = new Employee();
        emp.GetBranchData();
        emp.DisplayData();
        emp.GetEmployeeData();
        emp.DisplayEmployeeData();
    }
}

class Branch
{
    int branchCode;
    string branchName;
    public void GetBranchData()
    {
        Console.WriteLine("ENTER BRANCH DETAILS:");
        Console.WriteLine("ENTER BRANCH CODE");
        branchCode = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER BRANCH NAME");
        branchName = Console.ReadLine();
    }
    public void DisplayData()
    {
        Console.WriteLine(branchCode);
        Console.WriteLine(branchName);
    }
}

class Employee : Branch
{
    int employeeCode;
    string employeeName;
    public void GetEmployeeData()
    {
        Console.WriteLine("ENTER Employee DETAILS:");
        Console.WriteLine("ENTER Employee CODE");
        employeeCode = int.Parse(Console.ReadLine());
        Console.WriteLine("ENTER BRANCH NAME");
        employeeName = Console.ReadLine();
    }
    public void DisplayEmployeeData()
    {
        Console.WriteLine(employeeCode);
        Console.WriteLine(employeeName);
    }
}
