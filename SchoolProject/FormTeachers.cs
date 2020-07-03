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
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
            ShowTeachers();
        }

        private void listViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                Teachers teachers = listViewTeachers.SelectedItems[0].Tag as Teachers;
                textBoxLastName.Text = teachers.lastname;
                textBoxFirstName.Text = teachers.firstname;
                textBoxMiddleName.Text = teachers.middlename;
                textBoxEmail.Text = teachers.email;
            }
        }
        void ShowTeachers()
        {
            listViewTeachers.Items.Clear();
            foreach (Teachers teachers in Program.DB.Teachers)
            {
                ListViewItem item = new ListViewItem(new string[] {
                   teachers.lastname, teachers.firstname, teachers.middlename, teachers.email
                });
                item.Tag = teachers;
                listViewTeachers.Items.Add(item);
                listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxMiddleName.Text != "" && textBoxEmail.Text != "")
            {
                Teachers teachers = new Teachers();
                teachers.firstname = textBoxFirstName.Text;
                teachers.lastname = textBoxLastName.Text;
                teachers.middlename = textBoxMiddleName.Text;
                teachers.email = textBoxEmail.Text;
                Program.DB.Teachers.Add(teachers);
                Program.DB.SaveChanges();
                ShowTeachers();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                if (textBoxLastName.Text != "" && textBoxFirstName.Text != "" && textBoxMiddleName.Text != "" && textBoxEmail.Text != "")
                {
                    Teachers teachers = listViewTeachers.SelectedItems[0].Tag as Teachers;
                    teachers.firstname = textBoxFirstName.Text;
                    teachers.lastname = textBoxLastName.Text;
                    teachers.middlename = textBoxMiddleName.Text;
                    teachers.email = textBoxEmail.Text;
                    Program.DB.SaveChanges();
                    ShowTeachers();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTeachers.SelectedItems.Count == 1)
                {
                    Teachers teachers = listViewTeachers.SelectedItems[0].Tag as Teachers;
                    Program.DB.Teachers.Remove(teachers);
                    Program.DB.SaveChanges();
                    ShowTeachers();
                }
            }
            catch
            {
                MessageBox.Show("Поле используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
