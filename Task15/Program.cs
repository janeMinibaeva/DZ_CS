//Напишите программу, которая принимает на вход цифру, 
 //обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8){
    if (day == 6 || day == 7){
         Console.WriteLine("Выходной");
        if (day == 6){
            Console.WriteLine("Суббота");
            }
        if (day == 7){
             Console.WriteLine("Воскресенье");
            }
    }
    else
    Console.WriteLine("Будний");
}
else Console.WriteLine("Ввод неверный. Введите число от 1 до 7");
