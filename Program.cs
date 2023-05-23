// ==============================================================Первый семинар=========================================================
// 1. Напишите программу, которая на вход принимает число 
// и выдаёт его квадрат (число умноженное на само себя).

// Например:  
// 4 -> 16
// -3 -> 9
// -7 -> 49

//Решение:

// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());
// // number=number*number;
// number*=number;
// Console.WriteLine("Квадрат числа равен: ");
// Console.WriteLine(number);

// ==========================================================

// 2. Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число квадратом второго.
// a=25, b=5 -> да
// a=2, b=10 -> нет
// a=9, b=-3 -> да
// a=-3, b=9 -> нет

//Решение:

// Console.WriteLine("Введите число 1");
// int number1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2");
// int number2=Convert.ToInt32(Console.ReadLine());
// if(number1==number2*number2)
// {
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }
// else
// {
//     Console.WriteLine("Число 1 НЕ является квадратом числа 2");
// }

// =====================================================

// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

//Решение:

// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());
// if(number==1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if(number==2)
// {
//     Console.WriteLine("Вторник");
// }
// else if(number==3)
// {
//     Console.WriteLine("Среда");
// }
// else if(number==4)
// {
//     Console.WriteLine("Четверг");
// }
// else if(number==5)
// {
//     Console.WriteLine("Пятница");
// }
// else if(number==6)
// {
//     Console.WriteLine("Суббота");
// }
// else if(number==7)
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Такого дня недели у нас нет");
// }

//==============================================================

// 5. Напишите программу, которая на вход приниает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"

//Решение:

// Console.WriteLine("Введите число");
// int number=Convert.ToInt32(Console.ReadLine());
// int negNumber=-number;
// while(number>=negNumber)
// {
//     Console.WriteLine(negNumber);
//     negNumber++; // тоже самое -> negNumber=negNumber+1;
// }

// ========================================================ВТОРОЙ СЕМИНАР============================================================

// // Канкатинация
// Console.Write("Наше число:"+t+t); 

// // Интерполяция
// Console.Write($"Наше число: {t} {t} skvbsjk slvjh");

//========================================================================================

// Задача:
// Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

//Решение:

// int num =new Random().Next(10,100); 
// Console.WriteLine(num);
// int a = num /10;
// int b = num%10;
// if(a>b)
// {
//     Console.WriteLine(a);
// }
// else if(a<b)
// {
//     Console.WriteLine(b);
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }

//=======================Задача в комнате=======================

// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

//Решение:

// int num =new Random().Next(100,1000); 
// Console.WriteLine(num);
// int a = num /100;
// int b = num % 10;
// int c = (num % 100) / 10;
// Console.WriteLine($"Итоговое число {a}{b}"); // или так: Console.WriteLine("Итоговое число " + a + b);
// Console.WriteLine($"Убранное число {c}");

// или

// int num= new Random().Next(100,1000);
// Console.WriteLine(num);
// int num1=num/100;
// int num2=num%10;
// int result= num1*10+num2;
// Console.WriteLine(result);

//====================================================

// Вычисление кратности чисел друг к другу

//Решение:

// Console.WriteLine ("Введите число 1");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите число 2");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int result = number1 % number2;
// if( result == 0)
// {
//     Console.WriteLine ("Число 2 кратно числу 1");
// }
// else
// {
//     Console.WriteLine ("Число 2 не кратно числу 1 отстаток " + result);
// }

//или

// Console.WriteLine("Введите большее  число");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число");
// int num2=Convert.ToInt32(Console.ReadLine());
// if (num1 % num2 == 0) 
// {
//     Console.WriteLine("Кратны");
// }
// else
// {   // Канкатинация:
//     // Console.WriteLine("Остаток от деления"+ num1 % num2);
//     // Интерполяция:
//     Console.WriteLine($"Остаток от деления {num1 % num2}");
// }

//==================================Вычисление кратности одновременно двум числам===================

// Напишите программу, которая принимает на вход число
//  и проверяет, кратно ли оно одновременно 
// 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

//Решение:

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0) && (num % 23 == 0)
// {
//     Console.WriteLine("ДА");    
// }
// else
// {
// Console.WriteLine("НЕТ");
// }

//=======================сравнение==========================

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine("Введите 1 число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 == num1*num1)
// {
//     Console.WriteLine("Число 2 является квадратом числа 1");
// }
// else if (num1 == num2*num2)
// {
//     Console.WriteLine("Число 1 является квадратом числа 2");
// }
// else
// {
//     Console.WriteLine("Числа несовместимы");
// }

//========================================================ТРЕТИЙ СЕМИНАР==========================================================

// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

//Решение:

// Console.WriteLine("Введите число ");
//  int X = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Введите число ");
//  int Y = Convert.ToInt32(Console.ReadLine());
//  if (X>0 &&Y>0)
//  {
//     Console.WriteLine("1 четверть ");
//  }
//  else if(X<0 &&Y>0)
//  {
//     Console.WriteLine("2 четверть ");
//  }
// else if(X<0 &&Y<0)
//  {
//     Console.WriteLine("3 четверть ");
//  }
//  else if(X>0 &&Y<0)
//  {
//     Console.WriteLine("4 четверть ");
//  }
//  else
//  {
//     Console.WriteLine("Точка находитя на одной или двух осях координат ");
//  }

//===============================================================================

// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
//  возможных координат точек в этой четверти (x и y).

//Решение:

// Console.WriteLine("Введите число ");
// int input = Convert.ToInt32(Console.ReadLine());
// if (input == 1)
// {
//     Console.WriteLine("1 четверть ");
//     Console.WriteLine("X>0 && Y>0");
// }
// else if (input == 2)
// {
//     Console.WriteLine("2 четверть ");
//     Console.WriteLine("X<0 && Y>0");
// }
// else if (input == 3)
// {
//     Console.WriteLine("3 четверть ");
//     Console.WriteLine("X<0 && Y<0");
// }
// else if (input == 4)
// {
//     Console.WriteLine("4 четверть ");
//     Console.WriteLine("X>0 && Y<0");
// }
// else
// {
//     Console.WriteLine("Неверный ввод");
// }

// Второе решение:

// Console.WriteLine("Введите число ");
//  int num = Convert.ToInt32(Console.ReadLine());
// switch(num)
// {
//     case 1:
//     {
//         Console.WriteLine("X>0 Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("X<0 Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("X<0 Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("X>0 Y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Такой четверти нет");
//         break;
//     }
// }

//======================================================================

// Задача 21: Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//Решение:

// Console.WriteLine("Введите число ");
//  int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число ");
//  int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число ");
//  int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число ");
//  int Y2 = Convert.ToInt32(Console.ReadLine());
// double d=Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));
// Console.WriteLine(d);

//=====================================================================

// Задача 22: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

//Решение:

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++)
// {
//     Console.WriteLine(Math.Pow(i, 2));
// }

//=======================================================СЕМИНАР ЧЕТВЕРТЫЙ========================================================

// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Решение:

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int GetSumNum()
// {
//     int sum = 0;
//     int count = 0;
//     while (number > count)
//     {
//         count++;
//         sum += count;      // тоже самое: sum= sum+count;
//     }
//     return sum;
// }
// Console.WriteLine(GetSumNum());

//==============================================

// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//Первый вариант решения:

// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (value > 0)
// {
//     count++;
//     value = value / 10;
// }
// Console.WriteLine(count);

//Второй вариант решения:

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int getNumCount()
// {
//     return number.ToString().Length;
// }
// Console.WriteLine("Количество цифр в числе: " + getNumCount());

//==================================================

// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

//Решение:

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int temp = 1;
// for (int i = 1; i <= num; i++)
// {
//     temp = temp * i;
// }
// Console.WriteLine(temp);

//===================================================

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//Решение:

// int[] numArr = new int[8];  // ввели имя массива и его длинну
// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(0, 2);
//     Console.Write(numArr[i] + ",");
// }

//=====================================================СЕМИНАР ПЯТЫЙ=============================================================

// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// Решение:

// int[] numArr = new int[12];
// int positiveNum = 0;
// int negNum = 0;
// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(-9, 10);
//     if (numArr[i] > 0)
//     {
//         positiveNum += numArr[i];
//     }
//     else
//     {
//         negNum += numArr[i];
//     }
// }
// Console.WriteLine(String.Join(",", numArr) +
// "\nСумма положительных " + positiveNum + " отрицательных " + negNum); // символ "\n" в тексте позволяет из одной строки сделать две

//======================================================================

// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// Решение:

// int[] numArr = new int[] {1,7898,66,-6,-52,0};
// Console.WriteLine(String.Join(",",numArr));
// for(int i=0;i<numArr.Length;i++)
// {
//     numArr[i]=-numArr[i];
// }
// Console.WriteLine(String.Join(",",numArr));

//===============================================================================

// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Решение:

// Console.WriteLine("Ведите число");
// int nom = Convert.ToInt32(Console.ReadLine());
// int[] numArr = new int[] { 1, 7898, 66, -6, -52, 0 };
// Console.WriteLine(String.Join(",", numArr));
// bool flag = false;
// for (int i = 0; i < numArr.Length; i++)
// {
//     if (numArr[i] == nom)
//     {
//         flag = true;
//         break;
//     }
// }
// if (flag == true)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

//========================================================

// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//Решение:

// int[] numArr = new int[123];
// int num = 0;
// for (int i = 0; i < numArr.Length; i++)
// {
//     numArr[i] = new Random().Next(0, 501);
//     if ((numArr[i] > 9) && (numArr[i] < 100))
//     {
//         num = num + 1;
//     }
// }
// Console.WriteLine(String.Join(",", numArr));
// Console.WriteLine("Количество двухзначных чисел = " + num);

//===========================================================

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Решение:

// int[] arr = new int[5] { 3, 8, 2, 6, 5 }; //первый массив
// int lg = arr.Length;                //задаем переменную для длинны первого массива для простоты формул
// int middle = lg / 2 + lg % 2;           //узнаем длину второго массива(четный или нет)
// int[] arr2 = new int[middle];       //задаем длину второго массива
// for (int i = 0; i < middle; i++)
// {
//     arr2[i] = arr[i] * arr[lg - i - 1];  //берем пары элементов(1 и последний, 2й и предпоследний...) и перемножаем
//     if (i == lg - 1 - i)               //если массив не четный
//     {
//         arr2[i] = arr[lg - 1 - i];    //то записать центральный элемент в конец второго массива
//     }
// }
// Console.WriteLine(String.Join(",", arr2)); // выводим второй массив через запятую

//=====================================================СЕМИНАР ШЕСТОЙ=============================================================

// Задача 40: Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.

//Решение:

// Console.WriteLine("Ведите число 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите число 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ведите число 3");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < (num2 + num3) && (num2 < (num1 + num3)) && (num3 < (num1 + num2)))
// {
//     Console.WriteLine("Такой треугольник существует");
// }
// else if ((num1 <= 0) || (num2 <= 0) || (num3 <= 0))
// {
//     Console.WriteLine("Некорректный ввод");
// }
// else
// {
//     Console.WriteLine("Такой треугольник не существует");
// }

//===========================================================

// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

//Решение:

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string text = "";

// while (num > 0)
// {
//     text = num % 2 + text;
//     num = num / 2;
// }
// Console.WriteLine(text);

//===========================================================

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

//Решение: 

// Console.WriteLine("Введите число больше 2");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 2;
// if (N >= i)
// {
//     int[] fib = new int[N];
//     fib[0] = 0;
//     fib[1] = 1;
//     Console.Write($"{fib[0]} {fib[1]}");//Console.Write("0 1");
//     while (i < N) //for(int i=2;i<N;i++)
//     {
//         fib[i] = fib[i - 1] + fib[i - 2];
//         Console.Write($" {fib[i]}");
//         i++;
//     }
// }
// else
// {
//     Console.WriteLine("Некорректный ввод");
// }

//===========================================================

// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

//Решение:

// int[] array = new int[5] { 1, 2, 3, 4, 5 };

// int temp = 0;
// for (int i = 0; i < array.Length / 2; i++)
// {
//     temp = array[i];
//     array[i] = array[array.Length - 1 - i];
//     array[array.Length - 1 - i] = temp;
// }

// Console.WriteLine(String.Join(",", array));

//====================================================СЕМИНАР СЕДЬМОЙ==========================================================

