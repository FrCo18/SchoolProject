namespace SchoolProject
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonMarks = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonStudents.ForeColor = System.Drawing.Color.Black;
            this.buttonStudents.Location = new System.Drawing.Point(51, 145);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(100, 48);
            this.buttonStudents.TabIndex = 0;
            this.buttonStudents.Text = "Ученики";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonMarks
            // 
            this.buttonMarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonMarks.ForeColor = System.Drawing.Color.Black;
            this.buttonMarks.Location = new System.Drawing.Point(51, 323);
            this.buttonMarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMarks.Name = "buttonMarks";
            this.buttonMarks.Size = new System.Drawing.Size(100, 48);
            this.buttonMarks.TabIndex = 1;
            this.buttonMarks.Text = "Оценки";
            this.buttonMarks.UseVisualStyleBackColor = false;
            this.buttonMarks.Click += new System.EventHandler(this.buttonMarks_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonTeachers.ForeColor = System.Drawing.Color.Black;
            this.buttonTeachers.Location = new System.Drawing.Point(51, 204);
            this.buttonTeachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(100, 48);
            this.buttonTeachers.TabIndex = 2;
            this.buttonTeachers.Text = "Учителя";
            this.buttonTeachers.UseVisualStyleBackColor = false;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonSubjects.ForeColor = System.Drawing.Color.Black;
            this.buttonSubjects.Location = new System.Drawing.Point(51, 262);
            this.buttonSubjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(100, 48);
            this.buttonSubjects.TabIndex = 3;
            this.buttonSubjects.Text = "Предметы";
            this.buttonSubjects.UseVisualStyleBackColor = false;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.buttonTeachers);
            this.Controls.Add(this.buttonMarks);
            this.Controls.Add(this.buttonStudents);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonMarks;
        private System.Windows.Forms.Button buttonTeachers;
        private System.Windows.Forms.Button buttonSubjects;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

