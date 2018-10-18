using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityExam.DAO;
namespace EntityExam.Pages
{
    public partial class TeacherPage : Form
    {
        public TeacherPage()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher
            {
                full_name = fullNameText.Text,
                username = uernameText.Text,
                password = passwordText.Text
            };
            TeacherDAO teacherDAO = new TeacherDAO();
            teacherDAO.addTeacher(teacher);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher
            {
                id=Convert.ToInt32(idNumeric.Value),
                full_name = fullNameText.Text,
                username = uernameText.Text,
                password = passwordText.Text
            };
            TeacherDAO teacherDAO = new TeacherDAO();
            teacherDAO.updateTeacher(teacher);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idNumeric.Value);
            TeacherDAO teacherDAO = new TeacherDAO();
            teacherDAO.deleteTeacher(id);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            TeacherDAO teacherDAO = new TeacherDAO();
            var allTeacher = teacherDAO.GetTeachers();
            foreach (var item in allTeacher)
            {
                richTextBox1.Text += $"Full Name : {item.full_name} Username : { item.username}";
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
               
                full_name = fullNameText.Text,
                username = uernameText.Text,
                password = passwordText.Text
            };
            StudentDAO studentDAO = new StudentDAO();
            studentDAO.addStudent(student);
        }
    }
}
