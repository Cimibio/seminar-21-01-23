// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}
