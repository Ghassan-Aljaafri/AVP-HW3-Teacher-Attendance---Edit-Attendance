using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace TeacherAttendance.model
{
    public class AttendanceManagement
    {
        private static AttendanceManagement _attendanceManagement = null;
        
        private readonly List<Course> _courses = new List<Course>();
        private readonly List<Teacher> _teachers = new List<Teacher>();
        private readonly List<Room> _rooms = new List<Room>();
        private readonly List<Attendance> _attendances = new List<Attendance>();

        private AttendanceManagement()
        {

        }

        public static AttendanceManagement GetInstance()
        {
            if (_attendanceManagement == null)
            {
                _attendanceManagement = new AttendanceManagement();
            }
            return _attendanceManagement;
        }
        
        public void AddNewCourse(string courseName)
        {
            _courses.Add(new Course(_courses.Count + 1, courseName));
        }

        public List<Course> GetAllCourses()
        {
            var temp = _courses.GetRange(0, _courses.Count);
            temp.Add(new Course(0, "Add new course..."));
            return temp;
        }

        public void AddNewTeacher(string teacherName)
        {
            _teachers.Add(new Teacher(_teachers.Count + 1, teacherName));
        }

        public List<Teacher> GetAllTeachers()
        {
            var temp = _teachers.GetRange(0, _teachers.Count);
            temp.Add(new Teacher(0, "Add new course..."));
            return temp;
        }

        public void AddNewRoom(string roomName)
        {
            _rooms.Add(new Room(_rooms.Count + 1, roomName));
        }

        public List<Room> GetAllRooms()
        {
            var temp = _rooms.GetRange(0, _rooms.Count);
            temp.Add(new Room(0, "Add new room/lab..."));
            return temp;
        }

        public void AddNewAttendance(Attendance attendance)
        {
            this._attendances.Add(attendance);
        }

        public List<Attendance> GetAllAttendances()
        {
            return this._attendances;
        }
    }
}