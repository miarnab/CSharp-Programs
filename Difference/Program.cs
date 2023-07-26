// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the two numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int difference = 0;
if(a > b)
{
    difference = a - b;
}
else
{
    difference = b - a;
}
Console.WriteLine("The difference of the two numbers: " + difference);
