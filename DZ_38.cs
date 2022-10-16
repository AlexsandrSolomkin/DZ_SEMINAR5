// Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

//==============================================================================================================================================================

//Решение:

// Console.WriteLine("Какой размер массива вам необходим для вашей задачи?");
// int arrayLength = int.Parse(Console.ReadLine()!);
// int minElement = -1000000;
// int maxElement = 1000000;

// int[] array = GetArray(arrayLength, minElement, maxElement);
// Console.WriteLine($"{String.Join(", ", array)}");

// Console.WriteLine($"Разница между элементом массива с максимальным значением и элементом с минимальным значением:\n{MaxArray(array) - MinArray(array)}.");

// int MinArray (int[] arrayElement){
//     int min = arrayElement[0];
//     for(int i = 0; i < arrayElement.Length; i++){
//         if (min > arrayElement[i]){
//             min = arrayElement[i];
//         }
//     }
//     return min;
// }

// int MaxArray (int[] arrayElement){
//     int max = arrayElement[0];
//     for(int i = 0; i < arrayElement.Length; i++){
//         if (max < arrayElement[i]){
//             max = arrayElement[i];
//         }
//     }
//     return max;
// }

// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

//===============================================================================================================================================================