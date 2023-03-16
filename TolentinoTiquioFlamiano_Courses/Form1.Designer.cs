namespace TolentinoTiquioFlamiano_Courses
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_courses = new System.Windows.Forms.DataGridView();
            this.courseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.units = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeOffered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // data_courses
            // 
            this.data_courses.AllowUserToAddRows = false;
            this.data_courses.AllowUserToDeleteRows = false;
            this.data_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_courses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseTitle,
            this.courseDescription,
            this.units,
            this.collegeOffered});
            this.data_courses.Location = new System.Drawing.Point(12, 2);
            this.data_courses.Name = "data_courses";
            this.data_courses.ReadOnly = true;
            this.data_courses.RowHeadersWidth = 51;
            this.data_courses.RowTemplate.Height = 29;
            this.data_courses.Size = new System.Drawing.Size(866, 213);
            this.data_courses.TabIndex = 0;
            // 
            // courseTitle
            // 
            this.courseTitle.HeaderText = "Course Title";
            this.courseTitle.MinimumWidth = 6;
            this.courseTitle.Name = "courseTitle";
            this.courseTitle.ReadOnly = true;
            this.courseTitle.Width = 176;
            // 
            // courseDescription
            // 
            this.courseDescription.HeaderText = "Course Description";
            this.courseDescription.MinimumWidth = 6;
            this.courseDescription.Name = "courseDescription";
            this.courseDescription.ReadOnly = true;
            this.courseDescription.Width = 175;
            // 
            // units
            // 
            this.units.HeaderText = "Units";
            this.units.MinimumWidth = 6;
            this.units.Name = "units";
            this.units.ReadOnly = true;
            this.units.Width = 175;
            // 
            // collegeOffered
            // 
            this.collegeOffered.HeaderText = "College Offered";
            this.collegeOffered.MinimumWidth = 6;
            this.collegeOffered.Name = "collegeOffered";
            this.collegeOffered.ReadOnly = true;
            this.collegeOffered.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tolentino, Jaime Nicolas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiquio, Melody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Flamiano, Rotsen Joseph";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_courses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data_courses;
        private DataGridViewTextBoxColumn courseTitle;
        private DataGridViewTextBoxColumn courseDescription;
        private DataGridViewTextBoxColumn units;
        private DataGridViewTextBoxColumn collegeOffered;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}