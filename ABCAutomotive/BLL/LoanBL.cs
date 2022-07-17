using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Types;
using DAL;

namespace BLL
{
    public class LoanBL
    {
        LoanDAL loanDAL = new LoanDAL();

        public List<Student> GetStudents(string lastName)
        {
            return loanDAL.GetStudents(lastName);
        }

        public Student GetStudent(int studentId)
        {
            return loanDAL.GetStudent(studentId);
        }

        public List<Loan> GetStudentLoans(int studentId)
        {
            return loanDAL.GetStudentLoans(studentId);
        }

        public Resource GetResourceById(int id)
        {
            return loanDAL.GetResourceById(id);
        }

        ////Check Out
        //#region CheckOut
        ///// <summary>
        ///// 
        ///// </summary>
        //Loan _loan;

        //public List<Loan> _loans = new List<Loan>();

        //public List<ValidationError> Errors = new List<ValidationError>();



        //public List<Loan> GetStudentLoans(string studentID)
        //{
        //    LoanRepository loanRepository = new LoanRepository();

        //    return loanRepository.RetriveStudentLoans(studentID);


        //}

        //public bool AddLoan(Loan loan)
        //{
        //    _loan = loan;
        //    LoanRepository loanRepository = new LoanRepository();
        //    Validate(loan.RessourceID);
            
        //    if (Errors.Count == 0)
        //    {
        //        return loanRepository.Insert(_loan);
        //    }
        //    return false;
        //}

        //private bool ResourceDoesNotExistInLoan(int ressourceId)
        //{
        //    LoanRepository loanRepository = new LoanRepository();

        //    List<Loan> loans = loanRepository.RetriveAllLoans();

        //    if (loans.Exists(l => l.RessourceID == ressourceId && l.Status == LoanStatus.OnLoan))
        //    {
        //        Errors.Add(new ValidationError("This ressource has been loaned by an other student."));
        //        return false;
        //    }
        //    return true;

        //}

        //private bool DoesNotContainTheSameRessourceID()
        //{
        //    LoanRepository loanRepository = new LoanRepository();

        //    List<int> ressourceIds = new List<int>();

        //    foreach (Loan loan in _loans)
        //    {
        //        ressourceIds.Add(loan.RessourceID);

        //    }

        //    if (ressourceIds.Exists(id => id == _loan.RessourceID))
        //    {
        //        ResourceBL resourceBL = new ResourceBL();

        //        Resource resource = resourceBL.GetRessourceDetails(_loan.RessourceID);

        //        if (resource.Status == ResourceStatus.OnLoan && _loan.Status == LoanStatus.OnLoan)
        //        {
        //            Errors.Add(new ValidationError("This ressource is already one of the student loans."));
        //            return false;
        //        }

        //    }


        //    return true;
        //}

        //private bool DoesNotContainTheSameRessourceType()
        //{
        //    LoanRepository loanRepository = new LoanRepository();

        //    List<string> TypesBorrowed = new List<string>();
            
        //    if(_loans.Exists(l=> loanRepository.RessourceType(l.RessourceID) == loanRepository.RessourceType(_loan.RessourceID) && l.Status == LoanStatus.OnLoan))
        //    {
        //        Errors.Add(new ValidationError("The student currently has borrowed a ressource from the same type."));
        //        return false;
        //    }

        //    return true;
        //}

        //private bool IsReservingStudent()
        //{
            
        //    ResourceBL resourceBL = new ResourceBL();
        //    Resource resource = resourceBL.GetRessourceDetails(_loan.RessourceID);
        //    if(resource.ReservingStudentID != null && resource.ReserveStatus == ReserveStatus.Reserved)
        //    {
        //        if (resource.ReservingStudentID != _loan.StudentID)
        //        {
        //            Errors.Add(new ValidationError("This student is not the one who reserve the ressource. He/She cannot borrow it for now."));
        //            return false;
        //        }
        //    }         
        //    return true;
        //}

        //private bool HasLessThanThreeRessources()
        //{
        //    LoanRepository loanRepository = new LoanRepository();

        //    int numberOfLoans = loanRepository.NumberOfLoansByStudent(_loan.StudentID);

        //    if (numberOfLoans >= 3)
        //    {
        //        Errors.Add(new ValidationError("The student already borrowed a ressource for each type."));
        //        return false;
        //    }
        //    return true;

        //}

        //private bool IsValidEntity()
        //{
        //    ValidationContext context = new ValidationContext(_loan);
        //    List<ValidationResult> results = new List<ValidationResult>();
        //    bool isValid = Validator.TryValidateObject(_loan, context, results, true);

        //    foreach (ValidationResult r in results)
        //    {
        //        Errors.Add(new ValidationError(r.ErrorMessage));
        //    }

        //    return isValid;
        //}

        //private void Validate(int ressourceId)
        //{
        //    IsValidEntity();

        //    DoesNotContainTheSameRessourceID();

        //    if(Errors.Count == 0)
        //    {
        //        DoesNotContainTheSameRessourceType();
        //    }

        //    if(Errors.Count == 0)
        //    {
        //        ResourceDoesNotExistInLoan(ressourceId);
        //    }

        //    IsReservingStudent();





        //    //HasLessThanThreeRessources();
        //}
        //#endregion CheckOut



        ////Check In
        //#region Check In

        //public Loan GetLoanByID(int loanID)
        //{

        //    LoanRepository loanRepository = new LoanRepository();


        //    return loanRepository.RetrieveLoanByID(loanID);
        //}
        //public bool UpdateLoanStatus(List<Loan> loans)
        //{
        //    LoanRepository loanRepo = new LoanRepository();
        //    return loanRepo.UpdateLoanStatusForEach(loans);
        //}
        //#endregion Check In
    }
}
