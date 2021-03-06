﻿namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; } //zašto je ovdje "Grade?", a ne neko drugo svojstvo?//

        //također kao u students.cs//
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}