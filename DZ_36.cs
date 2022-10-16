// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//==============================================================================================================================================================

//Решение:

// Console.WriteLine("Какой размер массива вам необходим для вашей задачи?");
// int arrayLength = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите минимальную границу значения элементов массива.");
// int minElement = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите максимальную границу значения элементов массива.");
// int maxElement = int.Parse(Console.ReadLine()!);

// int[] array = GetArray(arrayLength, minElement, maxElement);
// Console.WriteLine($"{String.Join(", ", array)}");

// Console.WriteLine($"Сумма всех элементов массива с нечетным индексом: {SumOddElementArray(array)}.");

// int SumOddElementArray(int[] arrayElement){
//     int res = 0;
//     for (int i = 0; i < arrayElement.Length; i++){
//         if (i % 2 != 0){
//             res = res + arrayElement[i];
//         }
//     }
//     return res;
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