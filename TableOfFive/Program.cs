// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the length of the multiplication table: ");
int n = Convert.ToInt32(Console.ReadLine());
int product = 1;
Console.WriteLine("The multiplication table of 5: ");
for (int i = 1; i <= n; i++)
{
    product = 5 * i;
    Console.WriteLine("5" + "*" + i + "=" + product);
}
