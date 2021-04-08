namespace TeacherAttendance.model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        
        public Course()
        {
        }

        public Course(int courseId, string courseName)
        {
            this.CourseId = courseId;
            this.CourseName = courseName;
        }


        public override string ToString()
        {
            return CourseName;
        }
    }
}