namespace TeacherAttendance
{
    partial class frmTeacherAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.DTPStartTime = new System.Windows.Forms.DateTimePicker();
            this.DTPLeaveTime = new System.Windows.Forms.DateTimePicker();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbTeacherName = new System.Windows.Forms.ComboBox();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(673, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(335, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room/Lab";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(335, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(682, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Leave Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(12, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comment";
            // 
            // DTPDate
            // 
            this.DTPDate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DTPDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPDate.Location = new System.Drawing.Point(113, 64);
            this.DTPDate.Name = "DTPDate";
            this.DTPDate.Size = new System.Drawing.Size(205, 30);
            this.DTPDate.TabIndex = 7;
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(463, 12);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(200, 31);
            this.cmbCourses.TabIndex = 9;
            this.cmbCourses.SelectionChangeCommitted += new System.EventHandler(this.CmbCourses_SelectionChangeCommitted);
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(113, 12);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(205, 31);
            this.cmbRoom.TabIndex = 10;
            this.cmbRoom.SelectionChangeCommitted += new System.EventHandler(this.CmbRoom_SelectionChangeCommitted);
            // 
            // DTPStartTime
            // 
            this.DTPStartTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DTPStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPStartTime.Location = new System.Drawing.Point(463, 64);
            this.DTPStartTime.Name = "DTPStartTime";
            this.DTPStartTime.Size = new System.Drawing.Size(200, 30);
            this.DTPStartTime.TabIndex = 11;
            // 
            // DTPLeaveTime
            // 
            this.DTPLeaveTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.DTPLeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPLeaveTime.Location = new System.Drawing.Point(814, 64);
            this.DTPLeaveTime.Name = "DTPLeaveTime";
            this.DTPLeaveTime.Size = new System.Drawing.Size(270, 30);
            this.DTPLeaveTime.TabIndex = 12;
            // 
            // tbComment
            // 
            this.tbComment.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbComment.Location = new System.Drawing.Point(113, 122);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(971, 30);
            this.tbComment.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSave.Location = new System.Drawing.Point(1009, 174);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbTeacherName
            // 
            this.cmbTeacherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbTeacherName.FormattingEnabled = true;
            this.cmbTeacherName.Location = new System.Drawing.Point(814, 12);
            this.cmbTeacherName.Name = "cmbTeacherName";
            this.cmbTeacherName.Size = new System.Drawing.Size(270, 31);
            this.cmbTeacherName.TabIndex = 17;
            this.cmbTeacherName.SelectionChangeCommitted += new System.EventHandler(this.CmbTeacherName_SelectionChangeCommitted);
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.Location = new System.Drawing.Point(16, 220);
            this.dGV.Name = "dGV";
            this.dGV.Size = new System.Drawing.Size(1068, 168);
            this.dGV.TabIndex = 16;
            this.dGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellDoubleClick);
            this.dGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_RowHeaderMouseClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnCancel.Location = new System.Drawing.Point(928, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmTeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbTeacherName);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.DTPLeaveTime);
            this.Controls.Add(this.DTPStartTime);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.DTPDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTeacherAttendance";
            this.Text = "Teacher Attendance Tracker";
            this.Load += new System.EventHandler(this.FrmTeacherAttendance_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnCancel;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTPDate;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DateTimePicker DTPStartTime;
        private System.Windows.Forms.DateTimePicker DTPLeaveTime;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTeacherName;
        private System.Windows.Forms.DataGridView dGV;
    }
}

