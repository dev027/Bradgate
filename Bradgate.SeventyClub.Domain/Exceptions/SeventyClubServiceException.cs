using System;

namespace Bradgate.SeventyClub.Domain.Exceptions
{
    public class SeventyClubServiceException: Exception
    {
        public SeventyClubServiceException()
        {
        }

        public SeventyClubServiceException(string message)
            : base(message)
        {
        }

        public SeventyClubServiceException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public SeventyClubServiceException(Exception inner)
            : base("An error occurred. See InnerException for details", inner)
        {
        }
    }
}