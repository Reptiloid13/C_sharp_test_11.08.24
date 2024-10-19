// See https://aka.ms/new-console-template for more information
using System;
public class MainClass
{
    public static void Main(string[] args)
    {
        var userInfo = EnterUser();
        Console.WriteLine($"User Info:\nИмя {userInfo.Name} \nФамилия {userInfo.LastName} \nВозраст: {userInfo.Age} \nДомашние питомцы: {userInfo.Pets} \nЛюбимые цвета: {string.Join(", ", userInfo.favcolors)}");
    }

    public static (string Name, string LastName, int Age, bool Pets, string[] favcolors) EnterUser()
    {
        (string Name, string LastName, int Age, bool Pets, string[] favcolors) User = (Name: "", LastName: "", Age: 0, Pets: true, favcolors: new string[0]);


        Console.WriteLine("Введите имя");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите Фамилию");
        User.LastName = Console.ReadLine();


        do
        {
            Console.WriteLine("Введите возраст цифрами");

        } while (!int.TryParse(Console.ReadLine(), out User.Age));


        bool? Pets = null;
        do
        {
            Console.WriteLine("У вас есть домашний питомец ( Да/Нет):  ");
            var inPut = Console.ReadLine();
            if (inPut == "Да")
            {
                Pets = true;
            }
            else if (inPut == "Нет")
            {
                Pets = false;
            }


        }
        while (Pets == null);
        if (Pets != null && Pets == true)
        {
            var petsCount = ReadPositiveInt("Как много у вас домшних питомцов");
            var hasPets = ReadStrings(petsCount, "Имя животного/ых");
            
        }
        var colorCount = ReadPositiveInt("Как много у тебя любимых цветов");
        User.favcolors = ReadStrings(colorCount, "Color:");


        return User;
    }
    static bool CheckNum(string number, out int corrnumber)
    {


        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return true;
            }
        }
        {
            corrnumber = 0;
            return false;
        }

    }
    static string[] ReadStrings(int count, string message)
    {
        var strings = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{message} № {i + 1}: ");
            strings[i] = Console.ReadLine();
        }
        return strings;
    }
    static int ReadPositiveInt(string message)
    {
        int colorCount;
        do
        {
            Console.Write($"{message}: ");
        } while (!int.TryParse(Console.ReadLine(), out colorCount) && colorCount <= 0);
        return colorCount;
    }
}
