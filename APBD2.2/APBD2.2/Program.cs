// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Change2");
Console.WriteLine("Change3");
Console.WriteLine("Change4");

double CalculateAverage(int[] values)
{
    int sum = 0;
    foreach (int n in  values)
    {
        sum += n;
    }
    double avr = sum/values.Length;
    return avr;
}

int CalculateMax(int[] values)
{
    int max = 0;
    foreach (int n in values)
    {
        if (max < n)
        {
            max = n;
        }
    }
    return max;
}

//Update on main

int CalculateMin(int[] values)
{
    int min = 0;
    foreach (int n in values)
    {
        if (min > n)
        {
            min = n;
        }
    }
    return min;
}
