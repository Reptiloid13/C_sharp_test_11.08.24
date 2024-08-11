// See https://aka.ms/new-console-template for more information
using System;
public class MainClass
{
    public static void Main()
    {
        // Считывает элементы массива с консоли через пробел 

        int n; // Создаем переменную
        n = Convert.ToInt32(Console.ReadLine()); // Запрашиваем у юзера
        string[] s = Console.ReadLine().Split(' ');// 
        int[] arr = new int[n];// Масссив числ с именем arr и размером n
        for(int i = 0;i<n; i++)// Пробегаемся по всему массиву
        {
            arr[i] = Convert.ToInt32(s[i]); // На каждом шаге массива присваем соответсвующи элемент - s[i]
        }
        Console.WriteLine(arr[3]);//выводим элемент массива
        for (int i = 0; i < n; i++)// Выводим весь массив на нашу консоль 1 ый способ 
        {
            Console.Write($"{arr[i]} ");
        }
        Console.Write("\n");


        foreach(int i in arr)// создаем переменную i в arr. Удобен если используем его последовательно , развернуть егго нельзя
        {
            Console.Write($"{i} ");
        }




    }

}