// Задать массив из 8 элементов и вывести их на экран 
Console.WriteLine("Сгенерирован массив из 8ми цифр");
int[] array = new int[8];
for (int i = 0; i <= 7; i++)
{
    array[i] = new Random().Next(1,100);
}

for (int i = 0; i <= 7; i++)
{
    Console.WriteLine("Элемент массива под номером: " + i + " равен: " + array[i]);
}
