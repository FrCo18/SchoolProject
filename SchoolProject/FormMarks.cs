using System;
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
    public partial class FormMarks : Form
    {
        public FormMarks()
        {
            InitializeComponent();
            ShowComboBoxStudents();
            ShowComboBoxSubject();
            ShowMarks();
        }
        void ShowComboBoxStudents()
        {
            comboBoxStudents.Items.Clear();
            foreach (Students students in Program.DB.Students)
            {
                string[] item = { students.id_student + ": " + students.lastname + " " + students.firstname + " " + students.middlename };
                comboBoxStudents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowComboBoxSubject()
        {
            comboBoxSubjects.Items.Clear();
            foreach (Subjects subjects in Program.DB.Subjects)
            {
                string[] item = { subjects.id_subject + ": " + subjects.name_subject + " " + subjects.Teachers.lastname + " " + subjects.Teachers.firstname + " " + subjects.Teachers.middlename };
                comboBoxSubjects.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMarks.SelectedItems.Count == 1)
            {
                Marks marks = listViewMarks.SelectedItems[0].Tag as Marks;
                comboBoxStudents.SelectedIndex = comboBoxStudents.FindString(marks.id_student.ToString());
                comboBoxSubjects.SelectedIndex = comboBoxSubjects.FindString(marks.id_subject.ToString());
                textBoxMark.Text = marks.mark.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedItem != null && comboBoxSubjects.SelectedItem != null && textBoxMark.Text != "")
            {
                Marks marks = new Marks();
                marks.id_student = Convert.ToInt32(comboBoxStudents.SelectedItem.ToString().Split(':')[0]);
                marks.id_subject = Convert.ToInt32(comboBoxSubjects.SelectedItem.ToString().Split(':')[0]);
                marks.mark = Convert.ToInt32(textBoxMark.Text);
                Program.DB.Marks.Add(marks);
                Program.DB.SaveChanges();
                ShowMarks();
            }
        }
        void ShowMarks()
        {
            listViewMarks.Items.Clear();
            foreach (Marks marks in Program.DB.Marks)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   marks.Subjects.name_subject, marks.Students.lastname+" "+marks.Students.firstname+" "+marks.Students.middlename, marks.mark.ToString()
                });
                item.Tag = marks;
                listViewMarks.Items.Add(item);
                listViewMarks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMarks.SelectedItems.Count == 1)
            {
                if (comboBoxStudents.SelectedItem != null && comboBoxSubjects.SelectedItem != null && textBoxMark.Text != "")
                {
                    Marks marks = listViewMarks.SelectedItems[0].Tag as Marks;
                    marks.id_student = Convert.ToInt32(comboBoxStudents.SelectedItem.ToString().Split(':')[0]);
                    marks.id_subject = Convert.ToInt32(comboBoxSubjects.SelectedItem.ToString().Split(':')[0]);
                    marks.mark = Convert.ToInt32(textBoxMark.Text);
                    Program.DB.SaveChanges();
                    ShowMarks();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMarks.SelectedItems.Count == 1)
                {
                    Marks marks = listViewMarks.SelectedItems[0].Tag as Marks;
                    Program.DB.Marks.Remove(marks);
                    Program.DB.SaveChanges();
                    ShowMarks();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
