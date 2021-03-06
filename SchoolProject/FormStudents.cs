﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
            ShowStudents();
        }
        void ShowStudents()
        {
            listViewStudents.Items.Clear();
            foreach (Students students in Program.DB.Students)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   students.lastname, students.firstname, students.middlename, students.date_of_birth
                });
                item.Tag = students;
                listViewStudents.Items.Add(item);
                listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxMiddleName.Text != "" && textBoxYear.Text != "")
            {
                Students students = new Students();
                students.firstname = textBoxFirstName.Text;
                students.lastname = textBoxLastName.Text;
                students.middlename = textBoxMiddleName.Text;
                students.date_of_birth = textBoxYear.Text+"."+textBoxNumber.Text+"."+textBoxMonth.Text;
                Program.DB.Students.Add(students);
                Program.DB.SaveChanges();
                ShowStudents();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxMiddleName.Text != "" && textBoxYear.Text != "")
                {
                    Students students = listViewStudents.SelectedItems[0].Tag as Students;
                    students.firstname = textBoxFirstName.Text;
                    students.lastname = textBoxLastName.Text;
                    students.middlename = textBoxMiddleName.Text;
                    students.date_of_birth = textBoxYear.Text;
                    Program.DB.SaveChanges();
                    ShowStudents();
                }
            }
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                Students students = listViewStudents.SelectedItems[0].Tag as Students;
                textBoxLastName.Text = students.lastname;
                textBoxFirstName.Text = students.firstname;
                textBoxMiddleName.Text = students.middlename;
                textBoxYear.Text = students.date_of_birth.ToString().Split('.')[0];
                textBoxNumber.Text = students.date_of_birth.ToString().Split('.')[1];
                textBoxMonth.Text = students.date_of_birth.ToString().Split('.')[2];

                int i=0;
                int sum = 0;
                listViewMarks.Items.Clear();
                foreach (Marks marks in Program.DB.Marks)
                {
                    if (students.id_student == marks.id_student)
                    {
                            ListViewItem item = new ListViewItem(new string[] {
                       marks.Subjects.name_subject, marks.mark.ToString()
                        });
                            item.Tag = marks;
                            listViewMarks.Items.Add(item);
                            listViewMarks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        i++;
                        sum += marks.mark;
                    }
                }
                textBoxAverageMark.Text = (sum / i).ToString();
            }
        }
        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            char sym = e.KeyChar;
            if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
            {
                e.Handled = true;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStudents.SelectedItems.Count == 1)
                {
                    Students students = listViewStudents.SelectedItems[0].Tag as Students;
                    Program.DB.Students.Remove(students);
                    Program.DB.SaveChanges();
                    ShowStudents();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется!","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
