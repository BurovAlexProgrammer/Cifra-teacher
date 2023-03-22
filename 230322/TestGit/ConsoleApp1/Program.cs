//Разобрать домашку

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NumbersIdentificator
{
    class Program
    {
        static void Main(string[] args)
        {
            string _userInput;
            float _value = 0;
            bool isInteger = false;
            bool isError = false;
            bool isPositive = false;

            _userInput = Console.ReadLine();
            Parse(_userInput);
            Verify();
            Console.ReadLine();






            void Parse(string line)
            {
                int temp;
                float tempFloat;

                if (int.TryParse(line, out temp))
                {
                    isInteger = true;
                }

                if (float.TryParse(line, out tempFloat))
                {
                    isInteger = false;
                }

                isError = true;

                if (isError = false)
                {
                    bool isPositive = IsPositive(tempFloat);
                }
            }

            /* Основной метод, анализирующий пользовательский ввод */
            void Verify()
            {
                if (isError)
                {
                    Console.WriteLine("Error");
                    //return;
                } 
                else
                {
                    string result = "The number is ";

                    if (isPositive)
                    {
                        result += "positive";
                    } 
                    else
                    {
                        result += "negative";
                    }

                    result += " and ";

                    if (isInteger)
                    {
                        result += "integer";
                    } 
                    else
                    {
                        result += "float";
                    }
                }
            }


            bool IsPositive(float value)
            {
                return value >= 0;
            }
        }
    }
}
