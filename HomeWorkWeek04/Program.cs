using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace HomeWorkWeek0404
//{
//    internal class Program
//    {       
//        public static void Main(string[] args)
//        {
//            Person[] persons = new Person[3];
//            for (int i = 0; i < persons.Length; i++) { persons[i] = new Person(Console.ReadLine()); }
//            for (int i = 0; i < persons.Length; i++) { Console.WriteLine(persons[i].ToString()); }
//        }
//    }
//    public class Person
//    {
//        public string Name { get; set; }
//        public Person(string name) { Name = name; }
//        public override string ToString() { return "Hello! My name is " + Name; }
//        ~Person() { Name = string.Empty; }
//    }
//}

//namespace HomeWorkWeek0403
//{
//    internal class Program
//    {
//        public static void Main(string[] args)
//        {
//            Dog a = new Dog();
//            a.SetName(Console.ReadLine());
//            Console.WriteLine(a.GetName());
//            a.Eat();
//        }
//        public abstract class Animal
//        {
//            public string Name { get; set; }
//            public void SetName(string name) { Name = name; }
//            public  string GetName() { return Name; }
//            public abstract void Eat();
//        }
//        public class Dog : Animal
//        {
//            public override void Eat(){Console.WriteLine("Eating");}
//        }
//    }
//}

//namespace HomeWorkWeek0402
//{
//    internal class Program
//    {
//        public static void Main(string[] args)
//        {
//            Teacher teacher = new Teacher();
//            teacher.SetName(Console.ReadLine());
//            teacher.Explain();
//            Student student1 = new Student();
//            student1.SetName(Console.ReadLine());
//            student1.Study();
//            Student student2 = new Student();
//            student2.SetName(Console.ReadLine());
//            student2.Study();
//        }    
//        public class Person
//        {
//            public string Name { get; set; }
//            public void SetName(string name) { Name = name; }
//            public override string ToString() { return Name; }
//            public virtual string Study() { return "Study"; }
//            public virtual string Explain() { return "Explain"; }
//        }
//            public class Teacher : Person { public void Explain() { Console.WriteLine("Explain"); } }
//            public class Student : Person { public void Study() { Console.WriteLine("Study"); } }
//    }
//}





