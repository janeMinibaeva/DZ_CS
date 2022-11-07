//Напишите программу, которая принимает на 
//вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max){
    max = b;
    if (c > max ){
        max = c;
    }
}
else if (c > max){
    max = c;
}
Console.WriteLine("Максимальное число : " + max);