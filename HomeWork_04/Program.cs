﻿
using HomeWork_04;



Task1 task = new();
task.Decision();
Console.ReadKey();
Console.Clear();

Task2 task2 = new();
task2.Decision();
Console.ReadKey();
Console.ReadKey();

Task3 task3 = new();
Console.WriteLine("Введите русское или англиское слово:");
string word = Console.ReadLine();

task3.CheackWord(word);
Console.ReadKey();


