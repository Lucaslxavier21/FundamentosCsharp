using System;
using System.Collections.Generic;
using System.Linq;

namespace NetDiretoAoPonto.ArraysListasLinq
{
     class Linq
    {
        static void Main(string[] args)
        {
            #region LINQ
            var students = new List<Student>
            {
                new Student(1, "Luis", "12345678910", 100),
                new Student(2, "Lucas", "10987654321", 85),
                new Student(3, "Bianca", "1245789554", 34),
                new Student(4, "Luis", "46485444516", 70),
                new Student(5, "Marcella", "5487512545", 65),
            };

            var any = students.Any();
            var any100 = students.Any(s => s.Grade == 100);

            var single = students.Single(students => students.Id == 1);
            var singelOrDefault = students.SingleOrDefault(s => s.Document == "12345678910");

            var firts = students.First(s => s.FullName == "Luis");
            var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

            var orderByGrade = students.OrderBy(s => s.Grade);
            var orderByGradeDescending = students.OrderByDescending(s => s.Grade);

            var approvedStudent = students.Where(s => s.Grade >= 70);

            var grades = students.Select(s => s.Grade);
            var phoneNumbers = students.Select(s => s.PhoneNumbers);

            var sum = students.Sum(s => s.Grade);
            var min = students.Min(s => s.Grade);
            var max = students.Max(s => s.Grade);
            var count = students.Count;






            #endregion LINQ

            Console.ReadKey();
        }
    }

    public class Student
    {
        public Student(int id, string fullName, string document, int grade)
        {
            Id = id;
            FullName = fullName;
            Document = document;
            Grade = grade;

            PhoneNumbers = new List<string> { "1231232133", "5458844555", "2547854555588" };
        }

        public int Id { get; set; } 
        public string FullName { get; set; }    
        public string Document { get; set; }
        public int Grade { get; set; }  
        public List<string> PhoneNumbers { get; set; }
    }
}
