using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.EntitiesRepository;

namespace BLL
{
    public class PaymentBL
    {
        public bool AddPayment(int studentID, decimal payment, string type)
        {
            PaymentRepository paymentRepo = new PaymentRepository();
            return paymentRepo.AddPayment(studentID, payment, type);
        }
    }
}
