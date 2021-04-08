using System;
using System.ComponentModel;

namespace TeacherAttendance.model
{
    public class Attendance
    {
        [DisplayName("Teacher Name")]
        public Teacher Teacher { get; set; }
        [DisplayName("Course Name")]
        public Course Course { get; set; }
        [DisplayName("Room Name")]
        public Room Room { get; set; }
        [DisplayName("Date")]
        public string Date { get; set; }
        [DisplayName("Start Time")]
        public string StartTime { get; set; }
        [DisplayName("Leave Time")]
        public string LeaveTime { get; set; }
        [DisplayName("Comment")]
        public string Comment { get; set; }

        public Attendance()
        {
            Teacher = null;
            Course = null;
            Room = null;
            Date = "";
            LeaveTime = "";
            StartTime = "";
            Comment = "";
        }
        
        public Attendance(Teacher teacher, Course course, Room room, string date, string startTime, string leaveTime, string comment)
        {
            Teacher = teacher;
            Course = course;
            Room = room;
            Date = date;
            StartTime = startTime;
            LeaveTime = leaveTime;
            Comment = comment;
        }

    }
}