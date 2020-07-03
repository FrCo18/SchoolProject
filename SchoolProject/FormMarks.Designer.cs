namespace SchoolProject
{
    partial class FormMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMarks));
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.listViewMarks = new System.Windows.Forms.ListView();
            this.NameSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Student = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.labelMark = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(7, 192);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(224, 27);
            this.comboBoxStudents.TabIndex = 32;
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(3, 170);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(67, 19);
            this.labelStudents.TabIndex = 31;
            this.labelStudents.Text = "Ученики";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(7, 96);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(69, 19);
            this.labelSubject.TabIndex = 29;
            this.labelSubject.Text = "Предмет";
            // 
            // listViewMarks
            // 
            this.listViewMarks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameSubject,
            this.Student,
            this.Mark});
            this.listViewMarks.GridLines = true;
            this.listViewMarks.HideSelection = false;
            this.listViewMarks.Location = new System.Drawing.Point(238, 108);
            this.listViewMarks.Margin = new System.Windows.Forms.Padding(4);
            this.listViewMarks.Name = "listViewMarks";
            this.listViewMarks.Size = new System.Drawing.Size(371, 280);
            this.listViewMarks.TabIndex = 28;
            this.listViewMarks.UseCompatibleStateImageBehavior = false;
            this.listViewMarks.View = System.Windows.Forms.View.Details;
            this.listViewMarks.SelectedIndexChanged += new System.EventHandler(this.listViewMarks_SelectedIndexChanged);
            // 
            // NameSubject
            // 
            this.NameSubject.Text = "Предмет";
            this.NameSubject.Width = 88;
            // 
            // Student
            // 
            this.Student.Text = "Ученик";
            this.Student.Width = 128;
            // 
            // Mark
            // 
            this.Mark.Text = "Оценка";
            this.Mark.Width = 91;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.ForeColor = System.Drawing.Color.Black;
            this.buttonDel.Location = new System.Drawing.Point(476, 398);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(133, 70);
            this.buttonDel.TabIndex = 27;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(332, 398);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(133, 70);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(188, 398);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 70);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(7, 118);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(224, 27);
            this.comboBoxSubjects.TabIndex = 33;
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(7, 275);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(224, 27);
            this.textBoxMark.TabIndex = 34;
            // 
            // labelMark
            // 
            this.labelMark.AutoSize = true;
            this.labelMark.Location = new System.Drawing.Point(3, 253);
            this.labelMark.Name = "labelMark";
            this.labelMark.Size = new System.Drawing.Size(61, 19);
            this.labelMark.TabIndex = 35;
            this.labelMark.Text = "Оценка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // FormMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMark);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.comboBoxStudents);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.listViewMarks);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Марки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ListView listViewMarks;
        private System.Windows.Forms.ColumnHeader NameSubject;
        private System.Windows.Forms.ColumnHeader Student;
        private System.Windows.Forms.ColumnHeader Mark;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label labelMark;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}