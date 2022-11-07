//Напишите программу, которая на вход принимает число (N > 0),
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int count = 1;
while (count < a){
    if (count%2 ==0){
        Console.Write(count + " "); 
    }
   count++;
}
