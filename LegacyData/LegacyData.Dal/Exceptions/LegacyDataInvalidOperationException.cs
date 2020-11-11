using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.Exceptions
{
    public class LegacyDataInvalidOperationException : LegacyDataException
    {
        public LegacyDataInvalidOperationException()
        {
        }

        public LegacyDataInvalidOperationException(string message) : base(message)
        {
        }

        public LegacyDataInvalidOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
