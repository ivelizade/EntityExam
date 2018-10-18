using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExam.DAO
{
    class StudentDAO
    {
        public void addStudent(Student student)
        {
            using (ExamCourseEntityEntities db=new ExamCourseEntityEntities())
            {
                db.Student.Add(student);
                db.SaveChanges();
            }
        }
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (ExamCourseEntityEntities db=new ExamCourseEntityEntities())
            {
                students = db.Student.ToList();
            }
            return students;
        }
        public void updateStudent(Student Student)
        {
            using (ExamCourseEntityEntities db = new ExamCourseEntityEntities())
            {
                var updatedStudent = db.Student.Where(x => x.id == Student.id).First();
                updatedStudent.password = Student.password;
                updatedStudent.full_name = Student.full_name;
                updatedStudent.username = Student.username;
                db.SaveChanges();
            }
        }
        public void deleteStudent(int id)
        {
            using (ExamCourseEntityEntities db = new ExamCourseEntityEntities())
            {
                Student Student = db.Student.Where(x => x.id == id).First();

                db.Student.Remove(Student);
                db.SaveChanges();
            }
        }
    }
}
