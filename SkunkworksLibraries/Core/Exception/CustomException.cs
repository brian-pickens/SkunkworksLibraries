using System;
using System.Collections.Generic;
using System.Text;
using Core.Extensions;

namespace Core.Exception
{
    public class CustomException : System.Exception
    {
        /// <summary>
        /// Any custom values that the developer requires.
        /// </summary>
        private IDictionary<string, string> _customValues = new Dictionary<string, string>();

        #region Constructors

        /// <summary>
        /// Custom exception with error description.
        /// </summary>
        /// <param name="errorDescription"></param>
        public CustomException(string errorDescription)
            : base(errorDescription)
        {

        }

        /// <summary>
        /// Custom exception with error description and caught exception.
        /// </summary>
        /// <param name="errorDescription"></param>
        /// <param name="caughtException"></param>
        public CustomException(string errorDescription, System.Exception caughtException)
            : base(errorDescription, caughtException)
        {

        }

        /// <summary>
        /// Custom exception with error description and custom values.
        /// </summary>
        /// <param name="errorDescription"></param>
        /// <param name="customValues"></param>
        public CustomException(string errorDescription, params CustomExceptionValue[] customValues)
            : base(errorDescription)
        {
            AddCustomValues(customValues);
        }

        /// <summary>
        /// Custom exception with error description, caught exception and custom values.
        /// </summary>
        /// <param name="errorDescription"></param>
        /// <param name="caughtException"></param>
        /// <param name="customValues"></param>
        public CustomException(string errorDescription, System.Exception caughtException, params CustomExceptionValue[] customValues)
            : base(errorDescription, caughtException)
        {
            AddCustomValues(customValues);
        }

        #endregion Constructors

        protected void AddCustomValues(CustomExceptionValue[] customValues)
        {
            if (customValues != null)
            {
                foreach (var cv in customValues)
                {
                    AddCustomValue(cv.Name, cv.Value);
                }
            }
        }

        /// <summary>
        /// Add a custom value given its name.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AddCustomValue(string name, string value)
        {
            _customValues.Add(name, value);
        }

        /// <summary>
        /// Get a custom value given the name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetCustomValue(string name)
        {
            if (_customValues != null && _customValues.ContainsKey(name))
                return _customValues[name];

            return null;
        }

        /// <summary>
        /// Override to display custom values.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var msg = new StringBuilder();

            if (_customValues.Count > 0)
            {
                msg.AppendFormat("{0}Custom values:", Environment.NewLine);

                foreach (var kvp in _customValues)
                {
                    msg.AppendFormat("{0} ++++ Custom value: Name={1}, Value={2}", Environment.NewLine, kvp.Key, kvp.Value);
                }

                msg.AppendLine();
            }

            msg.Append(base.ToString());

            return msg.ToString();
        }
    }
}
