/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.*/

int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];
NewArray(numbers, -100, 100);
WriteArray(numbers);
double max=numbers[0];
double min = numbers[0];
double dif = 0;
for (int i = 0;i<numbers.Length;i++)
{
    if (numbers[i]>max)
    max = numbers[i];
    else if  (numbers[i]<min)
    min = numbers[i];
}
dif = max - min;
Console.Write($"Max: {max}, min: {min}, Difference: {Math.Round(dif,1)}");

void NewArray(double[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (max - min)+ min, 1);
    }
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}