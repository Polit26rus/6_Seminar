// int i  = new Random().Next(1,10);
// либо копия массива либо попарно менять
// String.Join(',', array);


// 42:На вход три числа проверка существует ли треугольник


// int [] InputNumbs(int quant){
//     int [] array = new int[quant];
//     int j = 1;
//     for(int i = 0;i < quant;i++){
//         Console.Write($"Введите {j}-ое: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//         j++;
//     }
//     return array;
// }
// string TriangleCheck(int [] triangle){
//     string check = "Нет";
//     if(triangle[0] + triangle[1] > triangle[2] & triangle[2] + triangle[1] > triangle[0] & triangle[0] + triangle[2] > triangle[1]){
//         check = "Да";
//     }
//     return check;
// }

// Console.Write("Сколько чисел собираетесь ввести: ");
// int nu = Convert.ToInt32(Console.ReadLine());
// int [] triangle = InputNumbs(nu);
// Console.WriteLine($"{TriangleCheck(triangle)}");

// Напишите программу,которая будет преобразовывать десятичное число в двоичное

// string DoubleSys(int n){
//     string num = "";
//     while(n != 0){
//         num += Convert.ToString(n % 2);
//         n /= 2;
//     }
//     Console.WriteLine(num);

//     string rev_num = "";
//     int i = 1;
//     while(i <= num.Length){
//         rev_num += num[num.Length - i];
//         i++;
//     }
//     return rev_num;
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{DoubleSys(n)}");




