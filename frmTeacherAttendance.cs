using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using TeacherAttendance.helper;
using TeacherAttendance.model;

namespace TeacherAttendance
{
    public partial class frmTeacherAttendance : Form
    {
        private AttendanceManagement _attendance;
        private Boolean _inEditMode = false;
        
        public frmTeacherAttendance()
        {
            InitializeComponent();
        }

        private void FrmTeacherAttendance_Load(object sender, EventArgs e)
        {
            _attendance = AttendanceManagement.GetInstance();
            ShowCourses();
            ShowTeachers();
            ShowRooms();

            dGV.DataSource = new List<Attendance> { new Attendance() };
        }

        /*private void CmbCourses_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }*/

        private void ShowCourses()
        {
            cmbCourses.DataSource = null;
            cmbCourses.DisplayMember = "CourseName";
            cmbCourses.ValueMember = "CourseId";
            cmbCourses.DataSource = _attendance.GetAllCourses();
            cmbCourses.SelectedIndex = -1;
        }

        private void ShowTeachers()
        {
            cmbTeacherName.DataSource = null;
            cmbTeacherName.DisplayMember = "TeacherName";
            cmbTeacherName.ValueMember = "TeacherId";
            cmbTeacherName.DataSource = _attendance.GetAllTeachers();
            cmbTeacherName.SelectedIndex = -1;
        }

        private void ShowRooms()
        {
            cmbRoom.DataSource = null;
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomId";
            cmbRoom.DataSource = _attendance.GetAllRooms();
            cmbRoom.SelectedIndex = -1;
        }

        private void CmbCourses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var value = "";
            
            var id = ((Course) ((ComboBox) sender).SelectedItem).CourseId;

            if (id != 0) return;

            if (Prompt.InputBox("New course", "New course name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    _attendance.AddNewCourse(value.Trim());
                    ShowCourses();
                }
        }

        private void CmbTeacherName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var value = "";

            var id = ((Teacher) ((ComboBox) sender).SelectedItem).TeacherId;

            if (id != 0) return;

            if (Prompt.InputBox("New teacher", "New teacher name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    _attendance.AddNewTeacher(value.Trim());
                    ShowTeachers();
                }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cmbRoom.SelectedIndex == -1 || cmbCourses.SelectedIndex == -1 || cmbTeacherName.SelectedIndex == -1) 
            {
                MessageBox.Show("Please fill all the fields.");
            } 
            else
            {
                var attendance = new Attendance(
                    (Teacher) cmbTeacherName.SelectedItem,
                    (Course) cmbCourses.SelectedItem,
                    (Room) cmbRoom.SelectedItem,
                    DTPDate.Text,
                    DTPStartTime.Text,
                    DTPLeaveTime.Text,
                    tbComment.Text);
                
                if (_inEditMode)
                {
                    if (dGV.CurrentRow != null)
                    {
                        // edit Attendance
                        var targetRow = dGV.CurrentRow.Index;
                        _attendance.GetAllAttendances()[targetRow] = attendance;
                        dGV.DataSource = null;
                        dGV.DataSource = _attendance.GetAllAttendances();
                        MessageBox.Show("Attendance Updated.");
                        this.CancelEditMode();
                    }
                }
                else
                {
                    // add new Attendance
                    _attendance.AddNewAttendance(attendance);
                    dGV.DataSource = null;
                    dGV.DataSource = _attendance.GetAllAttendances();
                    this.CancelEditMode();
                }
            }
        }

        private void CmbRoom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var value = "";

            var id = ((Room) ((ComboBox) sender).SelectedItem).RoomId;

            if (id != 0) return;

            if (Prompt.InputBox("New Room/Lab", "New Room/Lab name:", ref value) == DialogResult.OK)
                if (value.Trim().Length > 0)
                {
                    _attendance.AddNewRoom(value.Trim());
                    ShowRooms();
                }
        }

        private void dGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var allAttendances = _attendance.GetAllAttendances();
            
            if (allAttendances.Count > 0)
            {
                var targetRow = e.RowIndex;
                var targetAttendance = allAttendances[targetRow];
                this.SetFormFields(targetAttendance);
                this.ChangeToEditMode();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelEditMode();
        }
        
        private void SetFormFields(Attendance attendance)
        {
            cmbTeacherName.Text = attendance.Teacher.TeacherName;
            cmbCourses.Text = attendance.Course.CourseName;
            cmbRoom.Text = attendance.Room.RoomName;
            DTPDate.Value = DateTime.Parse(attendance.Date);
            DTPStartTime.Value = DateTime.Parse(attendance.StartTime);
            DTPLeaveTime.Value = DateTime.Parse(attendance.LeaveTime);
            tbComment.Text = attendance.Comment;
        }

        private void ClearFormFields()
        {
            cmbTeacherName.SelectedIndex = -1;
            cmbCourses.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            DTPDate.Value = DateTime.Today;
            DTPStartTime.Value = DateTime.Now;
            DTPLeaveTime.Value = DateTime.Now;
            tbComment.Clear();
        }

        private void ChangeToEditMode()
        {
            btnSave.Text = "Edit";
            this._inEditMode = true;
        }
        
        private void CancelEditMode()
        {
            btnSave.Text = "Save";
            this._inEditMode = false;
            this.ClearFormFields();
        }

        private void dGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var allAttendances = _attendance.GetAllAttendances();
            
            if (allAttendances.Count > 0)
            {
                var targetRow = e.RowIndex;
                var targetAttendance = allAttendances[targetRow];
                this.SetFormFields(targetAttendance);
                this.ChangeToEditMode();
            }
        }
    }
}