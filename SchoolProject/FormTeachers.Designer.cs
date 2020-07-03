namespace SchoolProject
{
    partial class FormTeachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeachers));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MidleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(35, 322);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(143, 27);
            this.textBoxEmail.TabIndex = 24;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(31, 300);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(139, 19);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Электронная почта";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(35, 253);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(143, 27);
            this.textBoxMiddleName.TabIndex = 22;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(31, 231);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(71, 19);
            this.labelMiddleName.TabIndex = 21;
            this.labelMiddleName.Text = "Отчество";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(35, 189);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(143, 27);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(31, 167);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(38, 19);
            this.labelFirstName.TabIndex = 19;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(35, 124);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(143, 27);
            this.textBoxLastName.TabIndex = 18;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(31, 102);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(73, 19);
            this.labelLastName.TabIndex = 17;
            this.labelLastName.Text = "Фамилия";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LastName,
            this.FirstName,
            this.MidleName,
            this.Email});
            this.listViewTeachers.GridLines = true;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(211, 114);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(405, 280);
            this.listViewTeachers.TabIndex = 16;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            this.listViewTeachers.SelectedIndexChanged += new System.EventHandler(this.listViewTeachers_SelectedIndexChanged);
            // 
            // LastName
            // 
            this.LastName.Text = "Фамилия";
            this.LastName.Width = 88;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Имя";
            // 
            // MidleName
            // 
            this.MidleName.Text = "Отчество";
            this.MidleName.Width = 84;
            // 
            // Email
            // 
            this.Email.Text = "Почта";
            this.Email.Width = 128;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.ForeColor = System.Drawing.Color.Black;
            this.buttonDel.Location = new System.Drawing.Point(483, 404);
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
            this.buttonEdit.Location = new System.Drawing.Point(339, 404);
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
            this.buttonAdd.Location = new System.Drawing.Point(195, 404);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 70);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.listViewTeachers);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTeachers";
            this.Text = "Учителя";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader MidleName;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}