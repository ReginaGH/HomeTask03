// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом (14212 -> нет; 12821 -> да; 23432 -> да)
Console.WriteLine("Введите пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
int digit1 = n/10000;
int digit2 = (n-digit1*10000)/1000;
int digit5 =n%10;
int digit4 = (n%100-digit5)/10;
Console.WriteLine(digit5);
int digit45 = n%100;
if(digit1==digit5 && digit2==digit4)
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число НЕ является палиндромом");
}