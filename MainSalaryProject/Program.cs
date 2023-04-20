using System;

namespace EmployeeSalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input employee information
            Console.WriteLine("Enter employee information:");
            Console.Write("Total salary: ");
            int totalSalary = int.Parse(Console.ReadLine());

            Console.Write("Marital status (E for married, D for single): ");
            char maritalStatus = char.Parse(Console.ReadLine());

            Console.Write("Number of children: ");
            int numChildren = int.Parse(Console.ReadLine());

            Console.Write("Is employee disabled? (Y or N): ");
            char isDisabled = char.Parse(Console.ReadLine());

            // Calculate allowances and deductions
            int familyAllowance = 0;
            int childAllowance = 0;
            if (maritalStatus == 'E')
            {
                familyAllowance = 50;
                if (numChildren >= 1)
                {
                    childAllowance += 30;
                }
                if (numChildren >= 2)
                {
                    childAllowance += 25;
                }
                if (numChildren >= 3)
                {
                    childAllowance += 20 * (numChildren - 2);
                }
            }
            else if (maritalStatus == 'D')
            {
                if (numChildren >= 1)
                {
                    childAllowance += 20;
                }
                if (numChildren >= 2)
                {
                    childAllowance += 15;
                }
                if (numChildren >= 3)
                {
                    childAllowance += 10 * (numChildren - 2);
                }
            }

            // Calculate gross salary
            int grossSalary = totalSalary + familyAllowance + childAllowance;

            // Calculate income tax
            double incomeTaxRate = 0;
            if (grossSalary <= 1000)
            {
                incomeTaxRate = 0.15;
            }
            else if (grossSalary <= 2000)
            {
                incomeTaxRate = 0.20;
            }
            else if (grossSalary <= 3000)
            {
                incomeTaxRate = 0.25;
            }
            else
            {
                incomeTaxRate = 0.30;
            }

            if (isDisabled == 'Y')
            {
                incomeTaxRate *= 0.5;
            }

            double incomeTaxAmount = grossSalary * incomeTaxRate;

            
            double netSalary = grossSalary - incomeTaxAmount;
            int roundedNetSalary = (int)Math.Round(netSalary);

            // Print the results
            Console.WriteLine($"Family allowance: {familyAllowance} AZN");
            Console.WriteLine($"Child allowance: {childAllowance} AZN");
            Console.WriteLine($"Income tax rate: {incomeTaxRate * 100}%");
            Console.WriteLine($"Income tax amount: {incomeTaxAmount:F2} AZN");
            Console.WriteLine($"Total salary: {totalSalary} AZN");
            Console.WriteLine($"Net salary: {roundedNetSalary} AZN");

            Console.ReadLine();
        }
    }
}
