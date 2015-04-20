using Core.Exception;
using Core.Extensions;

namespace DataAccess
{
    public class DataException : CustomException
    {
        #region Constructors

        /// <summary>
        /// Custom exception with error description.
        /// </summary>
        /// <param name="errorDescription"></param>
        public DataException(string errorDescription)
            : base(errorDescription)
        {
        }

        /// <summary>
        /// Custom exception with error description and caught exception.
        /// </summary>
        /// <param name="errorDescription"></param>
        /// <param name="caughtException"></param>
        public DataException(string errorDescription, System.Exception caughtException)
            : base(errorDescription, caughtException)
        {
        }

        /// <summary>
        /// Custom exception with error description and custom values.
        /// </summary>
        /// <param name="errorDescription"></param>
        /// <param name="customValues"></param>
        public DataException(string errorDescription, params CustomExceptionValue[] customValues)
            : base(errorDescription, customValues)
        {
        }

        /// <summary>
        /// Custom exception with error description, caught exception and custom values.
        /// </summary>
        /// <param name="errorDescription"></param>
        /// <param name="caughtException"></param>
        /// <param name="customValues"></param>
        public DataException(string errorDescription, System.Exception caughtException, params CustomExceptionValue[] customValues)
            : base(errorDescription, caughtException, customValues)
        {
        }

        #endregion
    }
}
