/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/ 
Console.WriteLine("Введите 5-значное число: ");
int input = int.Parse(Console.ReadLine());
int inputSafe = input;
int[] arr = new int[input.ToString().Length];
int[] copy = new int[arr.Length];
for(int i=0; i<arr.Length; i++)
{
    arr[i] = input%10;
    copy[i]= input%10;
    input/=10;
}
Console.WriteLine(" ");
Array.Reverse(arr);
bool isEqual = Enumerable.SequenceEqual(arr, copy);
Console.Write($"{inputSafe} - палиндром? - "); 
Console.WriteLine(isEqual);