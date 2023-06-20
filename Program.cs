// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] Array)
// {
//     for(int i=0; i < Array.Length; i++)
//     {
//         Console.Write(Array[i]+" ");
//     }
//     Console.WriteLine();
// }

// void FindEvenNum(int[] Array)
// {
//     int count = 0;
//     for (int i  = 0; i < Array.Length; i++)
//     {
//         if(Array[i]%2 == 0) count++;
//     }
//     Console.WriteLine($"Количество чётных чисел {count}");

// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// FindEvenNum(myArray);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] Array)
// {
//     for(int i=0; i < Array.Length; i++)
//     {
//         Console.Write(Array[i]+" ");
//     }
//     Console.WriteLine();
// }

// void FindSumNotEven(int[] Array)
// {
//     int sum = 0;
//     for (int i  = 0; i < Array.Length; i++)
//     {
//         if ((i % 2)== 1)
//         {
//             sum += Array[i];
//         } 
//     }
//     Console.WriteLine($"Сумма элементов на не чётных позициях -> {sum}");

// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// FindSumNotEven(myArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


// void PrintArray(int[] Array)
// {
//     for(int i=0; i < Array.Length; i++)
//     {
//         Console.Write(Array[i]+" ");
//     }
//     Console.WriteLine();
// }
// int[] CreateRandomArray (int size, int minValue, int maxValue)
// {
//     int[] newArray = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }


// void func(int[] array)
// {
//     int min = array[0];
//     int max = array[0];
//     for(int i =0; i < array.Length; i++)
//     {
//         if(array[i] > max)
//         {
//             max = array[i];
//         }
//         if(array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     Console.WriteLine($"{max - min}");
// }

// Console.WriteLine("Input array size ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// PrintArray(myArray);
// func(myArray);