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

namespace EntityExam
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                Student student = new Student
                {

                    full_name = nameText.Text,
                    username = usernameText.Text,
                    password = PasswordText.Text
                };
                StudentDAO studentDAO = new StudentDAO();
                studentDAO.addStudent(student);
            }
            if (comboBox1.SelectedIndex==1)
            {
                Teacher teacher = new Teacher
                {
                    full_name = nameText.Text,
                    username = usernameText.Text,
                    password = PasswordText.Text
                };
                TeacherDAO teacherDAO = new TeacherDAO();
                teacherDAO.addTeacher(teacher);
            }
        }
    }
}
