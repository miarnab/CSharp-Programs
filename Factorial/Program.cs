// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number to find the factorial: ");
int n = Convert.ToInt32(Console.ReadLine());
int factorial = 1;
for (int i = 1;  i <= n; i++)
{
    factorial = factorial * i;
}
Console.WriteLine("Factorial of the provided number: " + factorial);
