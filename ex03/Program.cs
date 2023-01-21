// Вычисление количества цифр в числе
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int copy = N;
int i = 0;
while (copy > 0) //считаем количество цифр в числе
{
    
    copy = copy / 10;
    i++;
}
Console.WriteLine("В числе " + N + " " + i + " цифр");