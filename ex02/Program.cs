//  Сумма чисел от 1 до N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int result = ((1 + N)*N) / 2;
Console.WriteLine(result);

for (int i = 1; i <= N; i++) //в качестве факультатива добавили расчет всех сумм чисел от 1 до N
{
    result = ((1 + i)*i) / 2;
    Console.WriteLine(result); 
}