// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
int r = 0, sum = 0, num1 = num;
while(num1 > 0)
{
    r = num1 % 10;
    sum = sum + (r * r * r);
    num1 = num1 / 10;
}
if(num == sum)
{
    Console.WriteLine("Pallindrome Number");
}
else
{
    Console.WriteLine("Not a Paliindrome Number");
}
