// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int [] ArrayCreateAndInput(int l){
//     int [] array = new int[l];
//     for(int i = 0;i < l;i++){
//         Console.Write($"Введите {i + 1} элемент массива: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int NumberOfNatural(int [] array){

//     int count = 0;

//     for(int i = 0;i < array.Length;i++){
//         if(array[i] > 0){
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Введите количество элементов вводимиого вами массива: ");
// int l = Convert.ToInt32(Console.ReadLine());
// int [] mas = ArrayCreateAndInput(l);
// Console.WriteLine($"{NumberOfNatural(mas)} элементов");


// Console.WriteLine($"{count} чисел");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// Console.Write("k1 = ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("b1 = ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("k2 = ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("b2 = ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// int x = (k1 - k2)*(b2 - b1);
// int y = k1 * x + b1;


// Console.WriteLine($"({x};{y})");


