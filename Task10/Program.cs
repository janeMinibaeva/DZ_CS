﻿//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число"); 
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000){
    int result = (number/10)%10;
    Console.WriteLine(result); 
}
else Console.WriteLine("не трехзначное число"); 
