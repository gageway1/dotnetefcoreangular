using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.Exceptions
{
    public class LegacyDataRetryLimitException : LegacyDataException
    {
        public LegacyDataRetryLimitException()
        {
        }

        public LegacyDataRetryLimitException(string message) : base(message)
        {
        }

        public LegacyDataRetryLimitException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
