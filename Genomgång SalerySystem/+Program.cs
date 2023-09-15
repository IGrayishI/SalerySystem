namespace Genomgång_SalerySystem
{
    internal class Program
    {

        //Create a salary system for a company such as McDonalds, there should be diffrent classes that do diffrent things. 
        //One class for the employee CHECK
        //One class for outlet
        //One class for head office
        //One class to salaries (Optional)

        static void Main(string[] args)
        {
            Employee Oliver     = new Employee(1, "Oliver", 3000);
            Employee Kymia      = new Employee(2, "Kymia", 5000);
            Employee Ben        = new Employee(3, "Benjamin", 2000);
            Employee Fatima     = new Employee(4, "Fatima", 5000);

            Outlet frolunda     = new Outlet("Frolunda", 10);

            frolunda.AddEmployee(Oliver);
            frolunda.AddEmployee(Kymia);
            frolunda.AddEmployee(Ben);

            Outlet nordstan     = new Outlet("Nordstan", 5);

            nordstan.AddEmployee(Fatima);
            
            Console.WriteLine(frolunda.GetTotalOutletSalary());

            HeadOffice HeadQuarterSweden = new HeadOffice(10);

            HeadQuarterSweden.AddOutlet(frolunda);

            Console.WriteLine(HeadQuarterSweden.GetTotalCompanySalary());

        }   


    }
}