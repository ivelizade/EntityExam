using EntityExam.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityExam.Pages
{
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown1.Value);
            StudentDAO studentDAO = new StudentDAO();
            studentDAO.deleteStudent(id);
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Student student= new Student
            {
                full_name = fullNameText.Text,
                username = uernameText.Text,
                password = passwordText.Text
            };
            StudentDAO studentDAO = new StudentDAO();
            studentDAO.addStudent(student);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                id=Convert.ToInt32(numericUpDown1.Value),
                full_name = fullNameText.Text,
                username = uernameText.Text,
                password = passwordText.Text
            };
            StudentDAO studentDAO = new StudentDAO();
            studentDAO.updateStudent(student);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            StudentDAO studenDAO = new StudentDAO();
            var allStudents = studenDAO.GetStudents();
            foreach (var item in allStudents)
            {
                richTextBox1.Text += $"Full Name : {item.full_name} Username : { item.username}";
            }
        }
    }
}
