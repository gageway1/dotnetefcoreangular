using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.Exceptions
{
    public class LegacyDataConcurrencyException : LegacyDataException
    {
        public LegacyDataConcurrencyException()
        {
        }

        public LegacyDataConcurrencyException(string message) : base(message)
        {
        }

        public LegacyDataConcurrencyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
