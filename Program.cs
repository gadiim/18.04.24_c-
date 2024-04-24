using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тема: Структури, перелік
//Модуль 8

namespace _18._04._24_c_
{

    //Task_1

    struct ThreeDimVector
    {
        public double X;
        public double Y;
        public double Z;
        public ThreeDimVector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void MultByNum(ThreeDimVector vector1, double num)
        {
            X = vector1.X * num;
            Y = vector1.Y * num;
            Z = vector1.Z * num;
        }
        public void SumOfVectors(ThreeDimVector vector1, ThreeDimVector vector2)
        {
            X = vector1.X + vector2.X;
            Y = vector1.Y + vector2.Y;
            Z = vector1.Z + vector2.Z;
        }
        public void SubOfVectors(ThreeDimVector vector1, ThreeDimVector vector2)
        {
            X = vector1.X - vector2.X;
            Y = vector1.Y - vector2.Y;
            Z = vector1.Z - vector2.Z;
        }
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }

    //Task_2

    struct DecimalNumber
    {
        private int _value;
        public DecimalNumber(int value)
        {
            this._value = value;
        }
        public int Value { get { return _value; } set { _value = value; } }
        public string ToBinary()
        {
            return Convert.ToString(_value, 2);
        }
        public string ToOctal()
        {
            return Convert.ToString(_value, 8);
        }
        public string ToHexadecimal()
        {
            return Convert.ToString(_value, 16);
        }
    }


    //Task_3

    struct RGB
    {
        private int _red;
        private int _green;
        private int _blue;
        public RGB(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }
        public int Red { get { return _red; } set { _red = value; } }
        public int Green { get { return _green; } set { _green = value; } }
        public int Blue { get { return _blue; } set { _blue = value; } }

        public void ToHEX(int red, int green, int blue)
        {
            Console.WriteLine($"use converter:\t\thttps://g.co/kgs/uTbKXYd");
        }
        public void ToHSL(int red, int green, int blue)
        {
            Console.WriteLine($"use converter:\t\thttps://g.co/kgs/uTbKXYd");
        }
        public void ToCMYK(int red, int green, int blue)
        {
            Console.WriteLine($"use converter:\t\thttps://g.co/kgs/uTbKXYd");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {

            //Завдання 1
            //Створіть структуру «Тривимірний вектор».
            //Визначте в ній необхідні поля і методи.
            //Реалізуйте наступну функціональність:
            //■ Помножити вектор на число;
            //■ Додавання векторів;
            //■ Віднімання векторів.

            Console.WriteLine($"Task 1\n");

            ThreeDimVector vector_1 = new ThreeDimVector(1, 2, 3);
            ThreeDimVector vector_2 = new ThreeDimVector(4, 5, 6);
            ThreeDimVector vector_3 = new ThreeDimVector();
            Console.WriteLine($"vector 1:\t\t{vector_1}");
            Console.WriteLine($"vector 2:\t\t{vector_2}");

            vector_3.MultByNum(vector_1, 10);
            Console.WriteLine($"mult:\t\t\t{vector_3}");

            vector_3.SumOfVectors(vector_1, vector_2);
            Console.WriteLine($"sum:\t\t\t{vector_3}");

            vector_3.SubOfVectors(vector_2, vector_1);
            Console.WriteLine($"sub:\t\t\t{vector_3}");

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 2
            //Створіть структуру «Десяткове число». Визначте в
            //ній необхідні поля і методи.
            //Реалізуйте наступну функціональність:
            //■ Перевести число у двійкову систему;
            //■ Перевести число у вісімкову систему;
            //■ Перевести число у шістнадцяткову систему.

            Console.WriteLine($"Task 2\n");

            DecimalNumber num = new DecimalNumber();
            num.Value = 10;
            Console.WriteLine($"{num.Value} to binary:\t\t{num.ToBinary()}");
            Console.WriteLine($"{num.Value} to octal:\t\t{num.ToOctal()}");
            Console.WriteLine($"{num.Value} to hexadecimal:\t{num.ToHexadecimal()}");

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 3
            //Створіть структуру «RGB колір».
            //Визначте в ній необхідні поля і методи.
            //Реалізуйте наступну функціональність:
            //■ Перевести у HEX формат;
            //■ Перевести у HSL;
            //■ Перевести у CMYK.

            Console.WriteLine($"Task 3\n");

            RGB rgb = new RGB();
            rgb.ToHEX(0, 0, 0);
            rgb.ToHSL(0, 0, 0);
            rgb.ToCMYK(0, 0, 0);

            Console.WriteLine();

        }
    }
}
