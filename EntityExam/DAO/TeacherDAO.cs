using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityExam.DAO
{
    class TeacherDAO
    {
        public void addTeacher(Teacher teacher)
        {
            using (ExamCourseEntityEntities db=new ExamCourseEntityEntities())
            {
                db.Teacher.Add(teacher);
                db.SaveChanges();
            }
        }
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            using (ExamCourseEntityEntities db=new ExamCourseEntityEntities())
            {
                teachers = db.Teacher.ToList();
            }
            return teachers;
        }
        public void updateTeacher(Teacher teacher)
        {
            using (ExamCourseEntityEntities db=new ExamCourseEntityEntities())
            {
                var updatedTeacher = db.Teacher.Where(x => x.id == teacher.id).First();
                updatedTeacher.password = teacher.password;
                updatedTeacher.full_name = teacher.full_name;
                updatedTeacher.username = teacher.username;
                db.SaveChanges();
            }
        }
        public void deleteTeacher(int id)
        {
            using (ExamCourseEntityEntities db=new ExamCourseEntityEntities())
            {
                Teacher teacher = db.Teacher.Where(x => x.id == id).First();

                db.Teacher.Remove(teacher);
                db.SaveChanges();
            }
        }
    }
}
