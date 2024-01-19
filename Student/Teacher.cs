using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string Subject { get; set; }
        public Teacher(int teacherId, string teacherName, string subject)
        {
            TeacherId = teacherId;
            TeacherName = teacherName;
            Subject = subject;
        }
    }
}