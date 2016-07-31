using System;
using System.Collections.Generic;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //s ovime imam problema koje se veže s kojim//

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}