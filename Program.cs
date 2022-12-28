// See https://aka.ms/new-console-template for more information
Console.WriteLine("This program finds perfect numbers within a given range. ");
Console.WriteLine("Give me a range from num1 to num2 ,Please.");
Console.WriteLine("num1= ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("num2=");
int num2 = int.Parse(Console.ReadLine());
int startPoint = Math.Min(num1, num2);
int endPoint = Math.Max(num1, num2);
int sumOfFactors;
Console.WriteLine("Perfect numbers between " + num1 + " and" + num2 + " are:");
for (int k = startPoint; k<=endPoint; k++)
{
    sumOfFactors = 0;
    for(int i = 1; i<=k/2; i++)
    {
        if(k % i ==0)
        { sumOfFactors += i; }
        
    }
    if (sumOfFactors == k && k!=0)
    { 
        Console.WriteLine(k); }
}


