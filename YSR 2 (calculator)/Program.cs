using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YSR_2__calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a; // вводим переменные
            double b;
            string  operation; // вводим строку операция (арифметическая)
            Console.WriteLine("Введите число 1"); // выводим текст
            a = double.Parse(Console.ReadLine()); // преобразуем переменные в числа 
            Console.WriteLine("Введите число 2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию: '+' '-' '*' '/' ");
              operation = Console.ReadLine(); // считывание операции
           
            if (operation == "+") // если +, то сложение
            {
                Console.WriteLine(a + b);
            }
            else if (operation == "-") // -, вычитание
            {
                Console.WriteLine(a - b);
            }
            else if (operation == "*") // *, умножение

            {
                Console.WriteLine(a * b);
            }
            else if (operation == "/") // /, деление
            {
                if (b == 0) // если знаменатель 0
                
                    Console.WriteLine("На нуль делить нельзя"); // выводится текст "На нуль делить нельзя"
                else
                    Console.WriteLine(a / b); // деление
            }

            else // если не '+' '-' '*' '/' выводится текст "Error. Operation not fouded"
            {
                Console.WriteLine("Error. Operation not fouded");
            }
            Console.ReadLine(); // считывание с консоли


            }
               
                    



        }
    }

