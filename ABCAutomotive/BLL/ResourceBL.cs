using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace BLL
{
    public class ResourceBL
    {
        //Check Out
        #region CheckOut
        Resource _ressource;
        public List<ValidationError> Errors = new List<ValidationError>();

        public Resource GetRessourceDetails(int id)
        {
            ResourceRepository ressourceRepository = new ResourceRepository();
            return ressourceRepository.RetrieveRessourceDetails(id);
        }

        public string GetReservingStudentID(int ressourceID)
        {
            ResourceRepository ressourceRepository = new ResourceRepository();
            return ressourceRepository.RetrieveReservingStudentID(ressourceID);
        }

        public bool ModifyRessource(Resource ressource, string studentID)
        {
            _ressource = ressource;

            ResourceRepository ressourceRepository = new ResourceRepository();

            Validate(studentID);

            if (Errors.Count == 0)
            {
                return ressourceRepository.Update(_ressource, studentID);
            }

            return false;
        }

        public bool ModifyReserveStatus(int resourceID, string studentID)
        {
            //_ressource = this.GetResourceToUpDate(resourceID);

            //StudentRepository studentRepository = new StudentRepository();
            //Student student = studentRepository.RetrieveStudentInformation(studentID);

            //if (_ressource.Status == Types.ResourceStatus.NotAvailable)
            //{
            //    Errors.Add(new ValidationError("This  resource is no longer available"));
            //}
            //else if (_ressource.ReserveStatus == Types.ReserveStatus.Reserved)
            //{
            //    if(_ressource.ReservingStudentID == studentID)
            //    {
            //        Errors.Add(new ValidationError("This student already reserved it."));

            //    }
            //    else
            //    {
            //        Errors.Add(new ValidationError("This  resource has already been reserved by another student"));
            //    }
            //}

            //if (student.Status == 0)
            //{
            //    Errors.Add(new ValidationError("Student Inactive. Unable to borrow any resources"));
            //}

            //else if (student.BalanceDue > 0)
            //{
            //    Errors.Add(new ValidationError("Unable to reserve any resources until the balance is paid in full"));
            //}

            //if (Errors.Count() == 0)
            //{
            //    ResourceRepository resourceRepository = new ResourceRepository();

            //    return resourceRepository.UpdateReserveStatus(resourceID, studentID);
            //}

            return false;
        }


        private bool IsReservingStudent(string studentID)
        {
            //if (_ressource.Status == 2)
            //{
                if (GetReservingStudentID(_ressource.ID) != string.Empty)
                {
                    if (GetReservingStudentID(_ressource.ID) != studentID)
                    {
                        Errors.Add(new ValidationError("This student is not the one who reserve the ressource. He/She cannot borrow it for now."));
                        return false;
                    }

                }
            //}
            return true;
        }

        private bool IsValidEntity()
        {
            ValidationContext context = new ValidationContext(_ressource);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(_ressource, context, results, true); // false ? true?

            foreach (ValidationResult r in results)
            {
                Errors.Add(new ValidationError(r.ErrorMessage));
            }

            return isValid;
        }

        private bool IsNotAvailable()
        {
            if (_ressource.Status == Types.ResourceStatus.NotAvailable)
            {
                Errors.Add(new ValidationError("This ressource is no longer available."));
                return false;
            }
            return true;
        }
        private void Validate(string studentID)
        {
            IsValidEntity();
            IsNotAvailable();
            IsReservingStudent(studentID);
        }


        #endregion CheckOut



        //Check In
        #region Check In

        public Resource GetResourceToUpDate(int resourceID)
        {
            ResourceRepository resourceRepository = new ResourceRepository();

            return resourceRepository.RetrieveResourceToUpdate(resourceID);

        }
        public DataTable GetResource(int id)
        {
            ResourceRepository repo = new ResourceRepository();
            return repo.RetrieveResourceById(id);
        }

        public DataTable GetResourcePrice(int id)
        {
            ResourceRepository repo = new ResourceRepository();
            return repo.RetrieveResourcePriceById(id);
        }

        public bool UpdateResourceStatus(List<Resource> resources)
        {
            ResourceRepository resourceRepo = new ResourceRepository();
            return resourceRepo.UpdateResourceStatusForEach(resources);
        }
        #endregion Check In
    }
}
