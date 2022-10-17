

double Factorial(int n)
{
    if (n==1)
    {
        return 1;
    }
    else return n * Factorial(n-1);
}

for (int i = 1; i < 31; i++)
{
    System.Console.Write($"{i}  ");
    System.Console.WriteLine(Factorial(i));
}

//System.Console.WriteLine($"{n}  {Factorial(n-1)*n}");