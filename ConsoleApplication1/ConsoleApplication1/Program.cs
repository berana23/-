using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бережная
{
    public class A
    {
        public int a = 12;
        public int b = 4;
        public int c
        {
            get
            {
                if (a < b) return a;
                else return b;
            }
            set
            {
                c = value;
            }
        }
    }
    public class B : A
    {
        public int d = 3;

        public int c2
        {
            get
            {
                return d *= +d;
            }
        }
    }
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" В рамках консольного приложения разработать класс В – наследник класса А с полем d и свойством с2. \n Свойство с2 – результат вычисления выражения над полями a, b, d.В теле свойства использовать управляющий оператор.\n У класса А создать конструктор, инициализирующий его поля. \n Для класса В определить 2 конструктора: один – наследуется от конструктора класса А, второй – собственный.\n В теле программы создать объекты классов А и В,продемонстрировав работу всех конструкторов.Вывести значения свойства на экран.");
            A obj1 = new A();
            Console.WriteLine(" Ответ 1: " + obj1.c);
            B obj2 = new B();
            Console.WriteLine(" Ответ 2: " + obj2.c2);
        }
    }
}



