using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5
{
    public class Student
    {

        private string Name
        {
            get; set;
        }

        private string Number
        {
            get; set;
        }

        public Dictionary<Subject, int> Subjects { get; set; }


        private List<Subject> Electives
        {
            get; set;
        }

        public Student(string studentName, string facultyNumber, Dictionary<Subject, int> subjects)
        {
            Name = studentName;
            Number = facultyNumber;
            Subjects = subjects;
        }

        public int GetSubjectsCount() => Subjects.Count;

        public List<string> GetStudentSubjects() => Subjects.Keys.Select(x => x.Name).ToList();

        public float GetGrade(string subjectName) => Subjects.FirstOrDefault(x => x.Key.Name == subjectName)!.Value;

        
        public double GetAverageGrade() => Subjects.Select(x => x.Value).Sum();

        private void GetStudentInfo()
        {
            Console.WriteLine("Student name: {0}, Studen factulty number: {1}", Name, Number);
        }
    }
}
