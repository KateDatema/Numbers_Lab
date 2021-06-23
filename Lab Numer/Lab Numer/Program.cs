using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_Numer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entering data for the project
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

            //NUM PART
            Console.WriteLine("THIS IS FOR THE NUMBER PART");
            Console.WriteLine();

            //1
            int minNum = nums.Min();
            Console.WriteLine("Min Num: " + minNum);
            //2
            int maxNum = nums.Max();
            Console.WriteLine("Max Num: " + maxNum);
            Console.WriteLine();
            //3
            List<int> lessThanBigNum = nums.Where(x => x < 10000).ToList();

            Console.WriteLine("Less than 10000:");
            foreach (int number in lessThanBigNum)
            { Console.WriteLine(number); }
            Console.WriteLine();

            //4
            List<int> filter1 = nums.Where(x => x < 100 && x > 10).ToList();
            Console.WriteLine("Less than 100, bigger than 10:");
            foreach (int number in filter1)
            { Console.WriteLine(number); }
            Console.WriteLine();

            //5
            List<int> filter2 = nums.Where(x => x >= 100000 && x <= 999999).ToList();
            Console.WriteLine("SOME BIG NUMBERS (Inclusive, between  100000 and  999999):");
            foreach (int number in filter2)
            { Console.WriteLine(number); }
            Console.WriteLine();
           
            //6
            
            List<int> evens = nums.Where(x => x % 2 == 0).ToList();
            int countEvens = evens.Count();
            Console.WriteLine("Total Evens:" + countEvens);
            Console.WriteLine();

            // STUDENTS
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("STUDENTS PART");
            Console.WriteLine();

            //1
            List<Student> over21 = (from student in students
                                    where student.Age >= 21
                                    select student).ToList();
            Console.WriteLine("Man you know these guys are going to be hungover Monday (over 21):");
            PrintStudentList(over21);
            Console.WriteLine();

            //2
            int oldest = (from student in students
                          select student.Age).Max();
            List<Student> oldestStudent = students.Where(s => s.Age >= oldest).ToList();
            Console.WriteLine("MAN this student is Ancient (Oldest student):");
            PrintStudentList(oldestStudent);
            Console.WriteLine();

            // Question 4, for students
            List<Student> under21 = (from student in students
                                     where student.Age < 21
                                     select student).ToList();
            int oldestUnder21Int = (from student in under21
                                    select student.Age).Max();
            List<Student> oldestUnder21 = (from student in under21
                                           where student.Age == oldestUnder21Int
                                           select student).ToList();

            Console.WriteLine("This young grass hopper will be an old gresser soon (Oldest Student under 21):");
            PrintStudentList(oldestUnder21);
            Console.WriteLine();

            //Question 5, for students
            //using list of students from last question
            //Starting to get my code more compact
            List<Student> evenUnder21 = (from student in under21
                                         where student.Age % 2 == 0
                                         select student).ToList();
            Console.WriteLine("I have no idea why you would want this information, but these are all the students that are even and under 21:");
            PrintStudentList(evenUnder21);
            Console.WriteLine();

            //Question 6, for students
            List<Student> teenagers = (from student in students
                                       where student.Age >= 13 && student.Age <= 19
                                       select student).ToList();
            Console.WriteLine("TEENAGERS, Better watch out for these students:");
            PrintStudentList(teenagers);
            Console.WriteLine();

            //Question 7, for students
            //There is probably a better way to do the way statement, must ask around tomorrow
            List<Student> startsWithVowel = (from student in students
                                             where student.Name.ToLower().StartsWith('a')| student.Name.ToLower().StartsWith('i')| student.Name.ToLower().StartsWith('e')| student.Name.ToLower().StartsWith('o')| student.Name.ToLower().StartsWith('u')
                                             select student).ToList();
            Console.WriteLine("OO, look - these guys names start with a vowel:");
            PrintStudentList(startsWithVowel);
            Console.WriteLine();

            Console.WriteLine("THE END");
        }
        public static void PrintStudentList(List<Student> students)
        {
            foreach(Student s in students)
            {
                Console.WriteLine(s.Name + "(" + s.Age + ")");
            }
        }
    }
}
