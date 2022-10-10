/*******************************************************************************
 * Name: Jason D'Oyley
 * Date: Oct. 9, 2022
 * Assignment CIS214 Performance Assessment - Classes
 *
 * Employee Class
 * The Employee class must meet the following requirements
 *
 *   Include public properties for the following:
 *    First Name (String)
 *    Last Name (String)
 *    Monthly Salary (double)
 *     Property set should be private
 *
 *   Include a public constructor
 *     Include parameters to initialize all variables
 *     Only set the Monthly Salary if the provided salary is greater than or
 *     equal to 1000
 *
 *   Include a method to update the Monthly Salary property
 *     Only set the Monthly Salary if the provided salary is greater than or
 *     equal to 1000
 */
public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double MonthlySalary { get; private set; }

    // Constructor takes 3 parameters to set the instance variables
    public Employee(string firstName, string lastName, double monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;

        // Check if balance provided is greater that 0
        // If it is, set the instance variables
        // If not, leave the instance variable as the defaul 0.0
        if (monthlySalary >= 1000)
        {
            MonthlySalary = monthlySalary;
        }
    }

    // Method to add an amount to the Monthly Salary, if it is valid
    public void Employee(double amount)
    {
        if (amount >= 1000)
        {
            MonthlySalary = MonthlySalary + amount;
        }
    }
}