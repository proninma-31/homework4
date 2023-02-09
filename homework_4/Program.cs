
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// double GetNumber(string message)
// {
//     int result = 0;
   
//     while (true)
//     {
//          Console.WriteLine(message);
//         if (int.TryParse(Console.ReadLine(), out result) && result > 0)
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Пиши ещё раз");
//         }
//     }
//     return result;
// }
// double a = GetNumber("Вводи первое число");
// double b = GetNumber("Вводи второе число");

// double n = (Math.Pow(a, b));
// Console.WriteLine ($" Число {a} в степени {b} = {n} ");

//====================================================================================================
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.WriteLine("Вводи число друг");
// string array = Console.ReadLine();
// int length = array.Length;
// int sum = 0;
// for (int i = 0; i < length; i++)
// {
//     int r = array[i] - '0'; 
// //Не очень понял как это работает, подсмотрел в интернете, что это способ как преобразовать чар в инт. 
// //Если подскажите почему не работают обычные parse и convert to int буду рад:))) 
//     sum = sum + r;
// }
// Console.WriteLine($"Сумма цифр числа {array} = {sum}");
//===================================================================================================================
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



// int[] array = new int[8];

// void InitArray(int[] array)
// {
// int length = array.Length; 
// int index = 0;
// Random rnd = new Random(); 
// while (index < length)
// {
// array[index] = rnd.Next(1, 100); 
// index++;
// }
// }

// void PrintArray(int [] array)
// {
// for (int i = 0; i < array.Length; i++ )
// {
// Console.Write($" {array[i]} ");
// }

// }

// InitArray(array);
// PrintArray(array);