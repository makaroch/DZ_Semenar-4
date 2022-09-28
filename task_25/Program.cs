/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*
Console.WriteLine("введи 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введи 2 число");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;
for (int i = 1; i < b; i++)
{
    c = c * a;
}
Console.WriteLine(c);
*/




/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму
цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*
Console.WriteLine("введи число");
string a = Console.ReadLine();
int sum = 0;
for (int i = 0; i < a.Length; i++)
{// проверка на цифру 
    if (a[i] == '1' | a[i] == '2' | a[i] == '3' | a[i] == '4' | a[i] == '5' | a[i] == '6' | a[i] == '7' | a[i] == '8' | a[i] == '9' | a[i] == '0'){
        sum = sum + Convert.ToInt32(Convert.ToString(a[i]));
    }
}
Console.WriteLine(sum);
*/




/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

/*
int[] arr = new int[8];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0,10);
    if (i != arr.Length - 1) Console.Write(arr[i] + ", ");
    else Console.Write(arr[i] + ". ");
}
*/