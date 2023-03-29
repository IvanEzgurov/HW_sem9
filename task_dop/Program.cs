// Задача со звездочкой Найти второй максимум в массиве.
// 4, 4, 3, 0, 2 => 3

int[] array = {4, 4, 3, 0, 2};
int max1 = 0;
int max2 = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max1)
    {
        max1 = array[i];
    }
}
Console.WriteLine($"Максимальный элемент массива равен {max1}");
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > max2 && array[i] != max1)
    {      
        max2 = array[i];
    }
}
Console.WriteLine($"Второй по величине элемент массива равен {max2}");