using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string FathersName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int TeacherId { get; set; }

        public Student(int id, string firstName, string lastName, DateTime dateOfBirth, string gender,
            string fathersName, string email, string phone, int teacherId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            FathersName = fathersName;
            Email = email;
            Phone = phone;
            TeacherId = teacherId;
        }
    }
}