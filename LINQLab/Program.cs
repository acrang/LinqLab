using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            // #1 for nums
            Console.WriteLine("#1 for nums:");

            var minValue = nums.Min();
            Console.WriteLine(minValue);

            Console.WriteLine();

            // #2 for nums
            Console.WriteLine("#2 for nums:");

            var maxValue = nums.Max();
            Console.WriteLine(maxValue);

            Console.WriteLine();

            // #3 for nums
            Console.WriteLine("#3 for nums:");

            var maxValueBelow10000 = nums.Where(x => x < 10000).Max();
            Console.WriteLine(maxValueBelow10000);

            Console.WriteLine();

            // #4 for nums
            Console.WriteLine("#4 for nums:"); // everything seems right here but it won't print. Same issue prevents me from completing #5

            var between10And100 = nums.Where(x => x > 10 && x < 100);
            foreach(var x in between10And100)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine();

            // #6 for nums
            Console.WriteLine("#6 for nums:");

            var allEvens = nums.Count(x => x % 2 == 0);
            Console.WriteLine(allEvens);

            Console.WriteLine();

            // #1 for students
            Console.WriteLine("#1 for students:");

            var drinkingAgeStudents = students.Where(x => x.Age >= 21);
            PrintStudentList(drinkingAgeStudents.ToList());

            Console.WriteLine();

            // #2 for students
            Console.WriteLine("#2 for students:");

            int oldestAge = students.Max(x => x.Age);
            Console.WriteLine(oldestAge);

            var oldestStudent = students.Where(x => x.Age == oldestAge).First();

            Console.WriteLine(oldestStudent.Name);

            Console.WriteLine();

            // #3 for students
            Console.WriteLine("#3 for students:");

            int youngestAge = students.Min(x => x.Age);
            Console.WriteLine(youngestAge);

            var youngestStudent = students.Where(x => x.Age == youngestAge).First();

            Console.WriteLine(youngestStudent.Name);

            Console.WriteLine();

            // #4 for students
            Console.WriteLine("#4 for students:");

            var oldestAgeUnder25 = students.Where(x => x.Age < 25).OrderBy(x => x.Age);
            Console.WriteLine(oldestAgeUnder25.Last().Age);
            Console.WriteLine(oldestAgeUnder25.Last().Name);

            Console.WriteLine();

            // #5 for students
            Console.WriteLine("#5 for students:");

            var over21AndEven = students.Where(x => x.Age > 21 && x.Age % 2 == 0);
            PrintStudentList(over21AndEven.ToList());

            Console.WriteLine();

            // #6 for students
            Console.WriteLine("#6 for students:");

            var allTeens = students.Where(x => x.Age >= 13 && x.Age <= 19).ToList();
            PrintStudentList(allTeens);

            // #7 for students
            //Console.WriteLine("#7 for students:");        // could not get this to work, was only able to get it to find one letter at a time

            //string[] vowels = { "A", "E", "I", "O", "U" };
            //var startsWithVowel = students.Where(x => x.Name.StartsWith(vowels.Any()));
            //PrintStudentList(startsWithVowel);
        }


        public static void PrintStudentList(List<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"Name: {s.Name} Age: {s.Age}");
            }
        }
    }
}
