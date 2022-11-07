// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите 1 число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b){
    Console.WriteLine($"{a} - большее число, {b} - меньшее число");
}
else Console.WriteLine($"{b} - большее число, {a} - меньшее число");