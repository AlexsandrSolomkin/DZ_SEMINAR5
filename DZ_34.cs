// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

//==============================================================================================================================================================

//Решение:

// Console.WriteLine("Какой размер массива вам необходим для вашей задачи?");
// int arrayLength = int.Parse(Console.ReadLine()!);
// int minElement = 100;
// int maxElement = 999;

// int[] array = GetArray(arrayLength, minElement, maxElement);
// Console.WriteLine($"{String.Join(", ", array)}");

// Console.WriteLine($"В массиве {EvenArrayElements(array)} четных элементов");

// int EvenArrayElements(int[] arrayElement){
//     int count = 0;
//     for (int i = 0; i < arrayElement.Length; i++){
//         if (arrayElement[i] % 2 == 0){
//             count++;
//         }
//     }
//     return count;
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