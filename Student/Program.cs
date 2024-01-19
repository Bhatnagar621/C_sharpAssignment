using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher(1234, "John Smith", "Mathematics"));
            teachers.Add(new Teacher(5678, "Maria Garcia", "English"));
            teachers.Add(new Teacher(9012, "Peter Lee", "Science"));
            teachers.Add(new Teacher(3456, "Susan Jones", "History"));
            teachers.Add(new Teacher(7890, "Emily Brown", "Art"));
            teachers.Add(new Teacher(1011, "David Miller", "Music"));
            teachers.Add(new Teacher(2324, "Lisa Jackson", "Physical Education"));

            List<Student> students = new List<Student>();
            students.Add(new Student(48271, "Isabella", "Kapoor", new DateTime(2009, 11, 22),
                "Female", "Raj Kapoor", "isabella.kapoor@email.com", "555 - 123 - 4567", 9012));
            students.Add(new Student(29103, "Aaron", "Diaz", new DateTime(2007, 08, 05),
                "Male", "Miguel Diaz", "aaron.diaz@email.com", "555-765-4321", 3456));
            students.Add(new Student(61530, "Maya", "Sato", new DateTime(2008, 06, 17),
                "Female", "Kenji Sato", "maya.sato@email.com", "555-987-6543", 1234));
            students.Add(new Student(17049, "Oliver", "Chen", new DateTime(2009, 09, 28),
                "Male", "David Chen", "oliver.chen@email.com", "555-321-9876", 2324));
            students.Add(new Student(55926, "Aisha", "Jones", new DateTime(2011, 05, 02),
                "Female", "Malik Jones", "aisha.jones@email.com", "555-654-3210", 7890));
            students.Add(new Student(38420, "Mohammed", "Hassan", new DateTime(2006, 01, 15),
                "Male", "Omar Hassan", "mohammed.hassan@email.com", "555-135-7924", 5678));
            students.Add(new Student(70191, "Elena", "Petrova", new DateTime(2006, 04, 29),
                "Female", "Sergei Petrov", "elena.petrova@email.com", "555-852-4693", 1011));
            students.Add(new Student(21357, "Liam", "O'Connor", new DateTime(2009, 03, 10),
                "Male", "Patrick O'Connor", "liam.oconnor@email.com", "555-246-8537", 1234));
            students.Add(new Student(43862, "Sophie", "Nguyen", new DateTime(2008, 07, 30),
                "Female", "Minh Nguyen", "sophie.nguyen@email.com", "555-963-1472", 2324));
            students.Add(new Student(85916, "Noah", "Garcia", new DateTime(2010, 10, 12),
                "Male", "Antonio Garcia", "noah.garcia@email.com", "555-478-9635", 9012));

            var query = from student in students
                        join teacher in teachers on student.TeacherId equals teacher.TeacherId
                        where (DateTime.Compare(DateTime.Today.AddYears(-10), student.DateOfBirth) > 0)
                        select new
                        {
                            student.FirstName,
                            student.LastName,
                            student.DateOfBirth,
                            teacher.TeacherName,
                            teacher.Subject
                        };
            var query2 =
                students.Select(s =>s.TeacherId);

            foreach ( var item in query2)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Students and their teachers:");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.DateOfBirth} - {item.TeacherName} ({item.Subject})");
            }
            Console.WriteLine(students.Count());
        }
    }
}

