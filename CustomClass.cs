using System;
namespace Learn
{
    public class CustomClass
    {
        public const double PI = 3.14;
        public int Number { get; set; }

        public virtual int Multiply(int num)
        {
            return num * Number;
        }

        public CustomClass()
        {
            Number = 0;
        }

        public static void MyMain()
        {
            CustomClass custom = new CustomClass();
            custom.Number = 3;
            Console.WriteLine(custom.Multiply(3));
        }
    }

    public class Person : CustomClass
    {
        public string Name { get; set; }

        public Person()
        {
            Name = "unknown";
        }

        public override int Multiply(int num) {
            int temp = base.Multiply(num);
            return temp + Number;
        }


        public override string ToString()
        {
            return string.Format("[Person: Name={0}]", Name);
        }

        public static new void MyMain()
        {
            Person p1 = new Person();
            p1.Name = "p1";
            Console.WriteLine(p1.Name);

            Person p2 = p1;
            p2.Name = "p2";
            Console.WriteLine(p2.Name);
            Console.WriteLine(p1.Name);
            p2.Number = 3;
            Console.WriteLine(p2.Multiply(3));

            CustomClass c1 = new Person();
            c1.Number = 3;
            Console.WriteLine(c1.Multiply(3));
            Console.WriteLine(CustomClass.PI);
        }
    }

    public struct PersonStruct
    {
        public string name;

        public PersonStruct(string name) {
            this.name = name;
        }

        public static void MyMain() {
            PersonStruct p1 = new PersonStruct("p1");
            p1.name = "p1";
            Console.WriteLine(p1.name);
            PersonStruct p2 = p1;
            p2.name = "p2";
            Console.WriteLine(p2.name);
            Console.WriteLine(p1.name);
            PersonStruct p3;
            p3.name = "p3";
            Console.WriteLine(p3.name);
        }
    }

    public interface Shape 
    {
        double Area { get; }    
    }

    public class Rectangle : Shape
    {
        public double length;

        public double Area {
            get => length * length;
        }

        public double Length {
            get => length;
            set => length = value;
        }

        public double Perimeter() => 4 * length;

        public static void MyMain() {
            Rectangle r = new Rectangle();
            r.Length = 10;
            Console.WriteLine(r.Length);
            Console.WriteLine(r.Area);
            Console.WriteLine(r.Perimeter());
        }
    }

    public class Calculator
    {
        public static void Square(ref int value)
        {
            value *= value;
        }

        public static void MyMain() {
            int value = 5;
            Console.WriteLine(value);
            Square(ref value);
            Console.WriteLine(value);
        }
    }
}
