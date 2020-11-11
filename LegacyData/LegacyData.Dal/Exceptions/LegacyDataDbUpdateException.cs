using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.Exceptions
{
    public class LegacyDataDbUpdateException : LegacyDataException
    {
        public LegacyDataDbUpdateException()
        {
        }

        public LegacyDataDbUpdateException(string message) : base(message)
        {
        }

        public LegacyDataDbUpdateException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
