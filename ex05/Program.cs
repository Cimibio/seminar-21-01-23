// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int sum_pos = 0;
int sum_neg = 0;


for (int i = 0; i <= 11; i++)
{
    array[i] = new Random().Next(0,9);
}

//for (int i = 0; i <= 11; i++)
//{
//    Console.WriteLine(array[i]);
//}

for (int i = 0; i <=11; i++)
{
    if (array[i] < 0)
    {
        sum_neg = sum_neg + array[i];
    }
    else if (array[i] >= 0)
    {
        sum_pos = sum_pos + array[i];
    }
}

Console.WriteLine("Сумма положительных чисел: " + sum_pos + ". Сумма отрицательных чисел: " + sum_neg);