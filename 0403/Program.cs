using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403
{
    public class Person
    {
        public string name;
        public int age;
        public int size;
        public string hairColor;


        public void Walk(int distance)
        {
            Console.WriteLine("걸은 거리: "+distance);
        }

        public void Food(string food)
        {
            Console.WriteLine("먹은 음식: "+food);
        }

        public void Speak(string language)
        {
            Console.WriteLine("사용 언어: " + language);
        }
    }
    public class Student : Person
    {
        public Student(string name, int age, int size, string hairColor)
        {
            this.name = name;
            this.age = age;
            this.size = size;
            this.hairColor = hairColor;
        }

        public void Study(string subject)
        {
            Console.WriteLine("수강 과목: "+subject);
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name, int age, int size, string hairColor)
        {
            this.name = name;
            this.age = age;
            this.size = size;
            this.hairColor = hairColor;
        }

        public void Teach(string subject)
        {
            Console.WriteLine("강의 과목: "+subject);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("학생", 20, 3, "갈색");
            Teacher teacher = new Teacher("선생", 35, 3, "검정색");

            Console.WriteLine("Student");
            student.Walk(20);
            student.Food("햄버거");
            student.Speak("한국어");
            student.Study("OOP");

            Console.WriteLine("\nTeacher");
            teacher.Walk(24);
            teacher.Food("김치찌개");
            teacher.Speak("영어");
            teacher.Teach("OOP");
        }
    }
}
