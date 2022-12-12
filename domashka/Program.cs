/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/





// ЗАДАНИЕ 1.
/*
Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

int a= number%10;
int b= number%100;
int c= number%1000;
int d= number%10000;
int f= number/10000;
if ( a!=0 & f != 0)
{
    
    if  ( a==f | b==d ) 
   {
    Console.WriteLine("Число  палиндром");
    } 
}
 
else 
{
    Console.WriteLine("Число не палиндром");
}
*/




// ЗАДАНИЕ 3.
/*
Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());
 for (int i = 1; i <= number; i++)
 {
   int result = i*i*i;
   Console.WriteLine($"{i}^3 = {result}");
 }

*/




// ЗАДАНИЕ 2 .

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

