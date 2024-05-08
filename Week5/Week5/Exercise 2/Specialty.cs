using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5.Exercise_2
{
    public class Specialty
    {
        public string Name
        {
            get; set;
        }

        public int CourseYear
        {
            get; set;
        }

        public List<Subject> CommonSubjects
        {
            get; set;
        }

        public List<Subject> Electives
        {
            get; set;
        }

        public List<Student> Students
        {
            get; set;
        }

        Specialty(string name, int courseYear, List<Subject> commonSubjects, List<Subject> electives, List<Student> students)
        {
            Name = name;
            CourseYear = courseYear;
            CommonSubjects = commonSubjects;
            Electives = electives;
            Students = students;
        }

        public void AddStudent(string name, string number, Dictionary<Subject, int> electives, Dictionary<Subject, int> commonSubjects)
        {
            Students.Add(new Student(name, number, commonSubjects.Union(electives).ToDictionary(x => x.Key, x=> x.Value)));
        }

        public void GetSpecialtyInfo()
        {
            Console.WriteLine("Course common subjects: {0}, Course electives: {1}, Course students amount: {2}", CommonSubjects, Electives, Students.Count);
        }

        public List<Student> GetStudentsBySubject(Subject subject)
        {
            return Students.Where(x => x.Subjects.Keys.Contains(subject)).ToList();
        }

        public double GetAverageGradeForSubject(Subject subject)
        {
            var subjectGrades = Students.Select(x => x.Subjects.FirstOrDefault(x=>x.Key.Name == subject.Name)).Select(x =>x.Value).ToList();
            return subjectGrades.Sum();
        }

        public double GetAverageGradeForSpecialty(Specialty specialty)
        {
            var avgGrades = new List<double>();
            foreach(var student in Students)
            {
                avgGrades.Add(student.GetAverageGrade());

            }
            return avgGrades.Sum();
        }

        public List<StudentAvgScore> GetTopStudents(int n)
        {
            var result = new List<StudentAvgScore>();
            foreach(var student in Students)
            {
                result.Add(new StudentAvgScore
                {
                    Student = student,
                    AvgScore = Math.Round(student.GetAverageGrade(), 2)
                });

            }
            return result.OrderBy(x => x.AvgScore).Take(n).ToList();
        }

        public struct StudentAvgScore
        {
            public Student Student;
            public double AvgScore;
        }
    }
}
