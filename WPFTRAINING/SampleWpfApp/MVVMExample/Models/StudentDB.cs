using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExample.Models
{
    public class Student : INotifyPropertyChanged
    {
       
        private int _id;private string _name;
        private int _fee;private string _course;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        public int StudentID
         {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("StudentID");
            }
            }
        public string StudentName
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("StudentName");
            }

        }
        public int Fees
        {
            get { return _fee; }
            set
            {
                _fee = value;
                OnPropertyChanged("Fees");
            }

        }
        public string StudentCourse
        {
            get { return _course; }
            set
            {
                _course = value;
                OnPropertyChanged("StudentCourse");
            }

        }
    }
    public class StudentDatabase
    {
        private List<Student> _students = new List<Student>();
        public StudentDatabase()
        {

        }
        public void AddNewStudent(Student student)
        {
            _students.Add(student);
        }
        public void DeleteStudent(int id)
        {
            var student = _students.Find(s => s.StudentID == id);
            if (student == null)
                throw new Exception("Student not found to delete");
            else
                _students.Remove(student);
        }
        public void UpdateStudent(Student modifiedStudent)
        {
            var student = _students.Find(s => s.StudentID == modifiedStudent.StudentID);
            if (student == null)
                throw new Exception("Student not found to update");
            else
            {
                student.StudentCourse = modifiedStudent.StudentCourse;
                student.StudentID = modifiedStudent.StudentID;
                student.Fees = modifiedStudent.Fees;
            }
        }
        public List<Student> GetAllStudents() => _students; 
    }
}
