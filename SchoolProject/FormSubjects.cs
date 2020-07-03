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
    public partial class FormSubjects : Form
    {
        public FormSubjects()
        {
            InitializeComponent();
            ShowComboBoxTeachers();
            ShowSubjects();
        }
        void ShowComboBoxTeachers()
        {
            comboBoxTeachers.Items.Clear();
            foreach (Teachers teachers in Program.DB.Teachers)
            {
                string[] item = { teachers.id_teacher+": "+ teachers.lastname+" "+teachers.firstname+" "+teachers.middlename};
                comboBoxTeachers.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSubjects()
        {
            listViewSubjects.Items.Clear();
            foreach (Subjects subjects in Program.DB.Subjects)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   subjects.name_subject, subjects.Teachers.lastname+" "+subjects.Teachers.firstname+" "+subjects.Teachers.middlename
                });
                item.Tag = subjects;
                listViewSubjects.Items.Add(item);
                listViewSubjects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameSubject.Text!=""&&comboBoxTeachers.SelectedItem!=null)
            {
                Subjects subjects = new Subjects();
                subjects.id_teacher = Convert.ToInt32(comboBoxTeachers.SelectedItem.ToString().Split(':')[0]);
                subjects.name_subject = textBoxNameSubject.Text;
                Program.DB.Subjects.Add(subjects);
                Program.DB.SaveChanges();
                ShowSubjects();
            }
        }

        private void listViewSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                Subjects subjects = listViewSubjects.SelectedItems[0].Tag as Subjects;
                textBoxNameSubject.Text = subjects.name_subject;
                comboBoxTeachers.SelectedIndex = comboBoxTeachers.FindString(subjects.Teachers.id_teacher.ToString());
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                if (textBoxNameSubject.Text != "" && comboBoxTeachers.SelectedItem != null)
                {
                    Subjects subjects = listViewSubjects.SelectedItems[0].Tag as Subjects;
                    subjects.id_teacher = Convert.ToInt32(comboBoxTeachers.SelectedItem.ToString().Split(':')[0]);
                    subjects.name_subject = textBoxNameSubject.Text;
                    Program.DB.SaveChanges();
                    ShowSubjects();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSubjects.SelectedItems.Count == 1)
                {
                    Subjects subjects = listViewSubjects.SelectedItems[0].Tag as Subjects;
                    Program.DB.Subjects.Remove(subjects);
                    Program.DB.SaveChanges();
                    ShowSubjects();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
