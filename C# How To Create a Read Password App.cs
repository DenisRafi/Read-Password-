﻿//-By Denis Rafi

using System;
using System.Threading;

class Program
{
    public static string Password()
    {
        string password = "";
        ConsoleKeyInfo info = Console.ReadKey(true);
        while (info.Key != ConsoleKey.Enter)
        {
            if (info.Key != ConsoleKey.Backspace)
            {
                Console.Write("x");
                password += info.KeyChar;
            }
            else if (info.Key == ConsoleKey.Backspace)
            {
                if (!string.IsNullOrEmpty(password))
                {
                    password = password.Substring(0, password.Length - 1);
                    int pos = Console.CursorLeft;
                    Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    Console.Write(" ");
                    Console.SetCursorPosition(pos - 1, Console.CursorTop);
                }
            }
            info = Console.ReadKey(true);
        }
        Console.WriteLine();
        return password;
    }
    static void Main()
    {
        Console.Write("Enter your user name : ");
        string userName = Console.ReadLine();
        Console.Write("Enter your password  : ");
        string password = Password();
        Console.ReadKey(true);
        Console.Write("\nThe password entered is : " + password);
        Thread.Sleep(10000);
        Console.Clear();
        Console.ReadKey(true);
    }    
}
