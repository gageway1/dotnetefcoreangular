using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyData.Dal.Exceptions
{
    public class LegacyDataException : Exception
    {
        public LegacyDataException()
        {
        }

        public LegacyDataException(string message) : base(message)
        {
        }

        public LegacyDataException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
