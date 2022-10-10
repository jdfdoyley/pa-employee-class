/*******************************************************************************
 * Name: Jason D'Oyley
 * Date: Oct. 9, 2022
 * Assignment CIS214 Performance Assessment - Classes
 *
 * Main application (program) class.
 * Print a line that states "Your Name - Week 1 PA Classes"
 * Create 2 Employee class objects (instances)
 *   Use an invalid salary for one of the employees (i.e. less than 1000)
 * Print the name and salary information for each employee with a header line  * above the information
 *   Update the employee information as follows
 *   Update the last name of one employee
 *   Update the first name of the other employee
 *   Update the salary information of both employees
 * Print the updated employee information for each employee with a header line
 * above the information
 */
public class EmployeeProgram
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("Jason D'Oyley - Week 1 PA Classes\n");

        // Create 2 Employee class objects (instances)
        // Use an invalid salary for one of the employees (i.e. less than 1000)
        Employee emp1 = new Employee("Jason", "Doyley", 0.00);
        Employee emp2 = new Employee("Luna", "James", 2500.00);

        // Print the name and salary information for each employee with a
        // header line above the information
        Console.WriteLine("Initial information for each employee");
        Console.WriteLine($"Name: {emp1.FirstName} {emp1.LastName}");
        Console.WriteLine("Monthly Salary: {0:F2}", emp1.MonthlySalary);

        Console.WriteLine();

        Console.WriteLine($"Name: {emp2.FirstName} {emp2.LastName}");
        Console.WriteLine("Monthly Salary: {0:F2}", emp2.MonthlySalary);

        Console.WriteLine();

        // Update the last name of one employee
        emp1.LastName = "Brown";

        // Update the first name of the other employee
        emp2.FirstName = "Maria";

        // Update the salary information of both employees
        emp1.UpdateSalary(1500.00);
        emp2.UpdateSalary(250.00);

        // Print the updated employee information for each employee with a
        // header line above the information
        Console.WriteLine("Updated information for each employee");
        Console.WriteLine($"Name: {emp1.FirstName} {emp1.LastName}");
        Console.WriteLine("Monthly Salary: {0:F2}", emp1.MonthlySalary);

        Console.WriteLine();

        Console.WriteLine($"Name: {emp2.FirstName} {emp2.LastName}");
        Console.WriteLine("Monthly Salary: {0:F2}", emp2.MonthlySalary);
    }
}