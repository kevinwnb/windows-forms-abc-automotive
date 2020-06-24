using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    /// <summary>
    /// Represents a parameter structure
    /// </summary>
    public struct Parameter
    {
        public Parameter(string name, object value,
            int size, SqlDbType dataType, ParameterDirection direction = ParameterDirection.Input)
        {
            Name = name;
            Value = value;
            Size = size;
            DataType = dataType;
            Direction = direction;
        }

        public string Name;
        public object Value;
        public int Size;
        public SqlDbType DataType;
        public ParameterDirection Direction;

    }

    public enum ResourceType
    {
        DVD = 1,
        Manual = 2,
        Book = 3
    }

    public enum ResourceStatus
    {
        Available = 1,
        OnLoan = 2,
        NotAvailable = 3
    }

    public enum LoanStatus
    {
        OnLoan = 1,
        Returned = 2,
        ReturnedDamaged = 3,
        NotReturned = 4
    }

    public enum ReserveStatus
    {
        NotReserved,
        Reserved
    }
    
    public enum StudentStatus
    {
        Inactive,
        Active
    }
}
