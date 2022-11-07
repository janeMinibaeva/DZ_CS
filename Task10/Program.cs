//Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = new Random().Next(100,1000);
Console.WriteLine(number); 
int result = (number/10)%10;
Console.WriteLine(result); 