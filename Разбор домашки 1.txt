//Разобрать домашку

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersIdentificator
{
    class Program
    {
        static void Main(string[] args)
        {
            string _UserInput;
            _UserInput = Console.ReadLine();

            Identificator(_UserInput);



            /* Основной метод, анализирующий пользовательский ввод */
            void Identificator(string UserInput)
            {
                if (isIntegerPlus(UserInput))
                {
                    Console.WriteLine("The number is integer and positive");
                }
                else if (isIntegerMinus(UserInput))
                {
                    Console.WriteLine("The number is integer and negative");
                }
                else if (isDoublePlus(UserInput))
                {
                    Console.WriteLine("The number is double and positive");
                }

                else if (isDoubleMinus(UserInput))
                {
                    Console.WriteLine("The number is double and negative");
                }
                else
                {
                    Console.WriteLine("Unknown number");
                }
            }




            bool isIntPositive(int value)
            {
                return value > 0;
            }



            bool isDoublePositive(double value)
            {
                return value > 0;
            }


            /* Проверка, является ли число целочисленным и положительным */
            bool isIntegerPlus(string UserInput)
            {
                int result = 0;
                bool isInteger = false;
                if (int.TryParse(UserInput, out result) && isIntPositive(result))
                {
                    isInteger = true;
                }
                return isInteger;
            }


            /* Проверка, является ли число целочисленным и отрицательным */
            bool isIntegerMinus(string UserInput)
            {
                int result = 0;
                bool isInteger = false;
                if (int.TryParse(UserInput, out result) && !isIntPositive(result))
                {
                    isInteger = true;
                }
                return isInteger;
            }


            /* Проверка, является ли число вещественным и положительным */
            bool isDoublePlus(string UserInput)
            {
                double result = 0.0;
                bool isDouble = false;
                if (double.TryParse(UserInput, out result) && isDoublePositive(result))
                {
                    isDouble = true;
                }
                return isDouble;
            }


            /* Проверка, является ли число вещественным и отрицательным */
            bool isDoubleMinus(string UserInput)
            {
                double result = 0.0;
                bool isDouble = false; //result => return
                if (double.TryParse(UserInput, out result) && !isDoublePositive(result))
                {
                    isDouble = true;
                }
                return isDouble;
            }
        }
    }
}
