// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the length of the multiplication table: ");
int n = Convert.ToInt32(Console.ReadLine());
int product = 1;
Console.WriteLine("The multiplication table of 10: ");
for (int i = 1;  i <= n; i++)
{
    product = 10 * i;
    Console.WriteLine("10" + "*" + i + "=" + product);
}
