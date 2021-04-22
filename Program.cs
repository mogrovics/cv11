using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            LinqToSql queries = new LinqToSql();

            Console.WriteLine("-------------------------------------------------");
            queries.SubjectsByMarks(db);
            queries.StudentCount(db);

            IEnumerable<Student> students = queries.StudentsOfSubjects("BPC-TIN   ");
            IEnumerable<Subject> subjects = queries.SubjectsOfStudents(1);

            foreach (var value in subjects)
            {
                Console.WriteLine(value.Abbreviation);
            }

            foreach (var value in students)
            {
                Console.WriteLine(value.Name + " " + value.Surname);
            }

            Console.ReadLine();
        }

        
    }
}
