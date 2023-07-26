// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the two numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int quotient = 1, remainder = 1;
if(a > b)
{
    quotient = a / b;
    remainder = a % b;
}
else
{
    quotient = b / a;
    remainder = b % a;
}
Console.WriteLine("The quotient of the two numbers: " + quotient);
Console.WriteLine("The remainder of the two numbers: " + remainder);
