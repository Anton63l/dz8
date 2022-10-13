// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// // Генерация двухмерного массива
// int[,] GenerateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
            
//         }
//     }
//         return array;

// }

// //  Вывод на печать двухмерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");

//         }
//         Console.WriteLine();

//     }
// }


// // Сортировка от макс до мин
// int[,] FromMintoMax(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }


// int[,] matrix = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// GenerateArray(matrix);
// PrintArray(matrix);
// System.Console.WriteLine();
// PrintArray(FromMintoMax(matrix));


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// // // Генерация двухмерного массива
// int[,] GenerateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
            
//         }
//     }
//         return array;

// }

// // //  Вывод на печать двухмерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");

//         }
//         Console.WriteLine();

//     }
// }

 
//  void StringLowNumbers (int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minRow += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }


// int[,] matrix = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

// GenerateArray(matrix);
// PrintArray(matrix);
// System.Console.WriteLine();
// StringLowNumbers(matrix);

//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Функция заполнения массива рандомными числами от 1 до 9
// void GenerateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // Функция вывода двумерного массива в терминал 
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] array = new int[4, 4];
// int[,] secondArray = new int[4, 4];
// int[,] resultArray = new int[4, 4];

// GenerateArray(array);
// PrintArray(array);

// Console.WriteLine();

// GenerateArray(secondArray);
// PrintArray(secondArray);

// Console.WriteLine();

// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array[i, k] * secondArray[k, j];
//         }
//     }
// }
// PrintArray(resultArray);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.




// //  Функция заполнения массива по спирали начиная с 1
// void FillArraySpiral(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// //  Функция вывода двумерного массива в терминал
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// System.Console.Write("Введите число строк:");
// int len = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[len, len];
// FillArraySpiral(array, len);
// PrintArray(array);

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.




// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);
// // Функция вывода индекса элементов 3D массива
// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// // Функция заполнения 3D массива не повторяющимеся числами
// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }