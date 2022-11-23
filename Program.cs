// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

// int [] array = new int [12];

// int negNum = 0;
// int posNum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-9, 10);

//     if (array[i] > 0)
//     {
//         posNum = posNum + array[i];
//     }
//     if (array[i] < 0)
//     {
//         negNum = negNum + array[i];
//     }
//     Console.Write(array[i] + ",");
// }
// Console.WriteLine("Сумма положительных числе = " + posNum);
// Console.WriteLine("Сумма положительных числе = " + negNum);

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int [] array = {5, -3, 14, -9, -21};

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
// }
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i] + ", ");
// }

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int [] Array()
// {
//      int[] arrayNumber = new int[num];
//      for (int i = 0; i < num; i++)
//      {
//         arrayNumber[i] = new Random().Next(100, 999);
//      }
//      return arrayNumber;

// }

// void PrintArray(int[] arrPrint)
// {
//     System.Console.WriteLine(string.Join(", ", arrPrint));

// }

// PrintArray(Array());
// ____________________________________________________________________
// Console.WriteLine("Введите число, оно будет размером массива и областью определиния");
// int num = Convert.ToInt32(Console.ReadLine());

// void FillArray(int[] collection)
// {
//     int Length = collection.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         collection[index] = new Random().Next(-num, num);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }
// static void IndexSum(int[] collection)
// {
//     int sum = 0;
//     for (int i = 1; i < collection.Length; i+= 2)
//     {
//         sum+= collection[i];
//     }
//     Console.WriteLine("Сумма чисел массива, с нечетным индексом = " + sum);
// }
// int [] array = new int [num];
// FillArray(array);
// PrintArray(array);
// IndexSum(array);

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
static void MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double sum = 0;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        sum = max - min;
    }
    Console.WriteLine("Разница между максимальным и минимальным значением массива = " + sum);
}
double [] Array = {6.7, 4.8, 9.5, 1.1, 2.6};

PrintArray(Array);
MaxMin(Array);





