// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Change2");
Console.WriteLine("Change3");
Console.WriteLine("Change4");

int CalculateAverage(int[] values)
{
    int avr = 0;
    foreach (int n in  values)
    {
        avr += n;
    }
    return avr/values.Length;
}
