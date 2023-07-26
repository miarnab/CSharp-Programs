// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number whose multiplication table you want to find: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number of elements in the multiplication table: ");
int n = Convert.ToInt32(Console.ReadLine());
int product = 1;
for (int i = 1;  i <= n; i++)
{
    product = a * i;
    Console.WriteLine(a + "*" + i + "=" + product);
}
