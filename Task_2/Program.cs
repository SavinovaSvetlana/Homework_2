//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите номер дня недели: "!);

int a=int.Parse(Console.ReadLine()!);

if (a == 6 | a == 7)
{
   Console.WriteLine("Выходной день "); 
}
 else
 {
    Console.WriteLine("Рабочий день "); 
 }



