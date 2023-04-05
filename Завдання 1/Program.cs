using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.Intrinsics.Arm;

namespace Завдання_1
{
    //Створити об'єкт класу Простий дріб, використовуючи клас Число, Знак.
    //Методи: висновок на екран, додавання, віднімання, множення, ділення.

    class Number // число (відповідає за зберігання значення чисельника і знаменника простого дробу)
    {
        private int value;

        public Number(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            Console.WriteLine("Метод GetValue викликаний");
            return value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Number other = (Number)obj;
            return value == other.value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    class Sign // знак (відповідає за зберігання знаку дробу)
    {
        private char value;

        public Sign(char value)
        {
            this.value = value;
        }

        public char GetValue()
        {
            Console.WriteLine("Метод GetValue викликаний");
            return value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Sign sign = (Sign)obj;
            return value == sign.value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    class SimpleFraction // простий дріб
    {
        private Number numerator; //чисельник
        private Number denominator; //знаменник
        private Sign sign; //знак дробу

        public SimpleFraction(int numeratorVal, int denumeratorVal, char signVal)
        {
            numerator = new Number(numeratorVal);
            denominator = new Number(denumeratorVal);
            sign = new Sign(signVal);
        }

        public void Print()
        {
            Console.WriteLine("Метод Print викликано");

            Console.WriteLine("{0}{1}/{2}", sign.ToString(), numerator.ToString(), denominator.ToString());
        }


        public SimpleFraction Add(SimpleFraction other) // додавання
        {
            Console.WriteLine("Метод Add викликаний");

            int newNumeratorVal = (sign.GetValue() == '-' ? -1 : 1) * numerator.GetValue() * other.denominator.GetValue()
                + (other.sign.GetValue() == '-' ? -1 : 1) * other.numerator.GetValue() * denominator.GetValue();

            int newDenumeratorVal = denominator.GetValue() * other.denominator.GetValue();

            char newSignVal = newNumeratorVal < 0 ? '-' : '+';
            newNumeratorVal = Math.Abs(newNumeratorVal);

            return new SimpleFraction(newNumeratorVal, newDenumeratorVal, newSignVal);
        }


        public SimpleFraction Subtract(SimpleFraction other) // віднімання
        {
            Console.WriteLine("Метод Substract викликаний");

            int newNumeratorVal = (sign.GetValue() == '-' ? -1 : 1) * numerator.GetValue() * other.denominator.GetValue()
                - (other.sign.GetValue() == '-' ? -1 : 1) * other.numerator.GetValue() * denominator.GetValue();

            int newDenumaratorVal = denominator.GetValue() * other.denominator.GetValue();

            char newSignVal = newNumeratorVal < 0 ? '-' : '+';

            return new SimpleFraction(newNumeratorVal, newDenumaratorVal, newSignVal);
        }


        public SimpleFraction Multiply(SimpleFraction other) // множення
        {
            Console.WriteLine("Метод Multiply викликано");

            int newNumeratorVal = numerator.GetValue() * other.numerator.GetValue();
            int newDenumaratorVal = denominator.GetValue() * other.denominator.GetValue();
            char newSignVal = sign.GetValue() == other.sign.GetValue() ? '+' : '-';

            return new SimpleFraction(newNumeratorVal, newDenumaratorVal, newSignVal);
        }


        public SimpleFraction Devide(SimpleFraction other) // ділення
        {
            Console.WriteLine("Метод Devide викликано");

            int newNumeratorVal = (sign.GetValue() == '+' ? -1 : 1) * numerator.GetValue() * other.denominator.GetValue();
            int newDenumaratorVal = denominator.GetValue() * other.numerator.GetValue();
            char newSignVal = newNumeratorVal < 0 ? '-' : '+';
            newNumeratorVal = Math.Abs(newNumeratorVal);

            return new SimpleFraction(newNumeratorVal, newDenumaratorVal, newSignVal);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            SimpleFraction other = (SimpleFraction)obj;
            return numerator.Equals(other.numerator) && denominator.Equals(other.denominator) && sign.Equals(other.sign);

        }

        public override int GetHashCode()
        {
            return numerator.GetHashCode() ^ denominator.GetHashCode() ^ sign.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0}{1}/{2}", sign.ToString(), denominator.ToString(), numerator.ToString());
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            SimpleFraction fraction1 = new SimpleFraction(3, 5, '+');
            SimpleFraction fraction2 = new SimpleFraction(1, 8, '-');

            Console.WriteLine("1 дріб:");
            fraction1.Print();
            Console.WriteLine("\n2 дріб:");
            fraction2.Print();

            Console.WriteLine("\nДодавання:");
            SimpleFraction resultAdd = fraction1.Add(fraction2);
            resultAdd.Print();

            Console.WriteLine("\nВіднімання:");
            SimpleFraction resultSub = fraction1.Subtract(fraction2);
            resultSub.Print();

            Console.WriteLine("\nМноження:");
            SimpleFraction resultMult = fraction1.Multiply(fraction2);
            resultMult.Print();

            Console.WriteLine("\nДілення:");
            SimpleFraction resultDev = fraction1.Devide(fraction2);
            resultDev.Print();

            Console.ReadKey();
        }
    }
}