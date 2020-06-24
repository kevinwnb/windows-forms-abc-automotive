using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BorrowingBL
    {
        public List<Borrowing> GetBorrowings(int resourceID)
        {
            BorrowingRepository borrowingRepository = new BorrowingRepository();

            return borrowingRepository.RetrieveBorrowings(resourceID);
        }
      
    }
}
