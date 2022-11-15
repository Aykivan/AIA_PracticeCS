﻿// Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.Write("Введите значение числа а: ");
int a=Convert.ToInt32(Console.ReadLine());
int b=a/100*10+a%10;
System.Console.WriteLine($"Результат удаления второго числа с конца будет равен: {b}, удаленное число: {a/10%10}");

/* Пример: 1234
Делим число на 100, получаем 12, так как значения int(целое цисло) делятся без остатка
Умножаем его на 10, получаем 120
И прибавляем к нему остаток а от деления на 10, 1234/10=123,4, остаток равен 4
В итоге получаем 120+4=124
Таким способом мы выкидываем 2рое число с конца у любого значения*/