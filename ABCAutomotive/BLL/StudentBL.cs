using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using Types;

namespace BLL
{
    public class StudentBL
    {
        //Check Out
        #region Check Out
        public Student _student;
        public List<ValidationError> Errors = new List<ValidationError>();

        public Student GetStudent(string id)
        {
            StudentRepository studentRepository = new StudentRepository();

            //return studentRepository.RetrieveStudentInformation(id);

            _student = studentRepository.RetrieveStudentInformation(id);
            Validate();

            return _student;

        }

        public List<Student> GetMatchingStudents(string id = null, string parttialLastName = null)
        {
            StudentRepository studentRepository = new StudentRepository();
            return studentRepository.RetrieveMatchingStudents(id, parttialLastName);
        }

        private bool IsValidEntity()
        {
            ValidationContext context = new ValidationContext(_student);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_student, context, results, true);

            foreach (ValidationResult r in results)
            {
                Errors.Add(new ValidationError(r.ErrorMessage));
            }

            return isValid;
        }

        private bool IsValidID()
        {
            string path = "[" + _student.StartDate.Year + "]" + "[0-9][0-9][0-9][0-9]";
            Regex reg = new Regex(path);

            if (!reg.IsMatch(_student.ID.ToString()))
            {
                Errors.Add(new ValidationError("The student ID must start with the student start date"));
            }
            return reg.IsMatch(_student.ID.ToString());
        }

        private bool DoesNotHaveOverdue()
        {
            if (_student.BalanceDue > 0)
            {
                Errors.Add(new ValidationError("The student has an overdue ressource."));
            }

            return _student.BalanceDue == 0;
        }

        private bool IsAvtive()
        {
            if (_student.Status == 0)
            {
                Errors.Add(new ValidationError("This student is not an active student."));

            }
            return _student.Status == StudentStatus.Active;
        }
        private void Validate()
        {
            IsValidEntity();
            IsValidID();
            IsAvtive();
            DoesNotHaveOverdue();
        }
        #endregion Check Out

        public bool Add(Student student)
        {
            StudentRepository studentRepository = new StudentRepository();
            return studentRepository.InsertStudent(student);
        }

        public bool Edit(Student student)
        {
            StudentRepository studentRepository = new StudentRepository();
            return studentRepository.Update(student);
        }

        public bool Remove(int studentId)
        {
            StudentRepository studentRepository = new StudentRepository();
            return studentRepository.Delete(studentId);
        }

        public int GetLastID()
        {
            StudentRepository studentRepository = new StudentRepository();
            return studentRepository.GetLastID();
        }
        //Check In
        #region Check In
        public Student GetStudentByResourceId(int resourceId)
        {
            StudentRepository studentRepo = new StudentRepository();
            return studentRepo.RetrieveStudentByResourceId(resourceId);
        }

        public bool UpdateStudentBalanceDue(int numDaysOverDue, decimal replacementAmount, Student student)
        {
            StudentRepository studentRepo = new StudentRepository();
            student.BalanceDue += replacementAmount + (5 * numDaysOverDue);
            return studentRepo.UpdateStudentBalanceDue(student);
        }
        #endregion Check In

        //Payment
        #region Payment
        public List<Student> PaymentGetStudents(string searchCriteria, int searchBy)
        {
            StudentRepository studentRepo = new StudentRepository();
            return studentRepo.PaymentGetStudents(searchCriteria, searchBy);
        }
        public bool MakePayment(string studentID, decimal payment)
        {
            StudentRepository studentRepo = new StudentRepository();
            return studentRepo.MakePayment(studentID, payment);
        }
        #endregion
    }
}
