//Напишите программу, которая с помощью деления выводит
//третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (a/100  == 0){
    Console.WriteLine("Третьей цифры нет");
}
else {
    while (a > 999) {
        a = a/10;
    }
    int result = a%10;
    Console.WriteLine(result);
}
 
 
 


