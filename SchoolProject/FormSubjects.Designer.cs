namespace SchoolProject
{
    partial class FormSubjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubjects));
            this.labelTeachers = new System.Windows.Forms.Label();
            this.textBoxNameSubject = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.listViewSubjects = new System.Windows.Forms.ListView();
            this.NameSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTeachers
            // 
            this.labelTeachers.AutoSize = true;
            this.labelTeachers.Location = new System.Drawing.Point(8, 189);
            this.labelTeachers.Name = "labelTeachers";
            this.labelTeachers.Size = new System.Drawing.Size(64, 19);
            this.labelTeachers.TabIndex = 23;
            this.labelTeachers.Text = "Учителя";
            // 
            // textBoxNameSubject
            // 
            this.textBoxNameSubject.Location = new System.Drawing.Point(16, 137);
            this.textBoxNameSubject.Name = "textBoxNameSubject";
            this.textBoxNameSubject.Size = new System.Drawing.Size(220, 27);
            this.textBoxNameSubject.TabIndex = 18;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 115);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 19);
            this.labelLastName.TabIndex = 17;
            this.labelLastName.Text = "Название";
            // 
            // listViewSubjects
            // 
            this.listViewSubjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameSubject,
            this.Teacher});
            this.listViewSubjects.GridLines = true;
            this.listViewSubjects.HideSelection = false;
            this.listViewSubjects.Location = new System.Drawing.Point(243, 127);
            this.listViewSubjects.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSubjects.Name = "listViewSubjects";
            this.listViewSubjects.Size = new System.Drawing.Size(371, 280);
            this.listViewSubjects.TabIndex = 16;
            this.listViewSubjects.UseCompatibleStateImageBehavior = false;
            this.listViewSubjects.View = System.Windows.Forms.View.Details;
            this.listViewSubjects.SelectedIndexChanged += new System.EventHandler(this.listViewSubjects_SelectedIndexChanged);
            // 
            // NameSubject
            // 
            this.NameSubject.Text = "Предмет";
            this.NameSubject.Width = 88;
            // 
            // Teacher
            // 
            this.Teacher.Text = "Учитель";
            this.Teacher.Width = 128;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.ForeColor = System.Drawing.Color.Black;
            this.buttonDel.Location = new System.Drawing.Point(481, 417);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(133, 70);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonEdit.Location = new System.Drawing.Point(337, 417);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(133, 70);
            this.buttonEdit.TabIndex = 14;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(193, 417);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 70);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(12, 211);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(224, 27);
            this.comboBoxTeachers.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(413, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FormSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.labelTeachers);
            this.Controls.Add(this.textBoxNameSubject);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.listViewSubjects);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSubjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предметы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTeachers;
        private System.Windows.Forms.TextBox textBoxNameSubject;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ListView listViewSubjects;
        private System.Windows.Forms.ColumnHeader NameSubject;
        private System.Windows.Forms.ColumnHeader Teacher;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}