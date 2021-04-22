using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv11
{
    public class LinqToSql
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public IEnumerable<Student> StudentsOfSubjects(string subject)
        {
           
            return db.Subjects.FirstOrDefault(sub => sub.Abbreviation == subject).Registrations.Select(stud => stud.Student);
        }

        public IEnumerable<Subject> SubjectsOfStudents(int studentId)
        {
            return db.Students.FirstOrDefault(stud => stud.Id == studentId).Registrations.Select(sub => sub.Subject1);
        }

        public void StudentCount(DataClasses1DataContext db)
        {
            Console.WriteLine("Subjects by number of students:");
            var line = from subject in db.StudentCountViews
                       orderby subject.Students descending
                       select subject;

            foreach (var lineActual in line)
            {
                Console.WriteLine("{0}: {1}", lineActual.Subject, lineActual.Students);
            }
            Console.WriteLine("-------------------------------------------------");
        }

        public void SubjectsByMarks(DataClasses1DataContext db)
        {
            Console.WriteLine("Subjects by average marks:");
            var line = from subject in db.Subjects
                       orderby subject.Marks.Average(mark => mark.Mark1)
                       select subject;

            foreach (var lineActual in line)
            {
                Console.WriteLine("{0}: {1}", lineActual.Name, lineActual.Marks.Average(mark => mark.Mark1));
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
