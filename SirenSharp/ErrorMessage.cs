namespace SirenSharp
{
    /// <summary>
    /// Represents possible error codes for envelope error messages
    /// </summary>
    public enum ErrorCode
    {
        Success = 0,
        InternalAccessOnly = 1000,
        HashInvalid = 1001,
        CredentialsInvalid = 1002,
        RequestNotValidAnymore = 1003
    }

    /// <summary>
    /// This class is used for error messages returned in the JSON part of the API
    /// </summary>
    public class ErrorMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorMessage"/> class.
        /// </summary>
        /// <param name="code">The error code associated with the error</param>
        /// <param name="message">A readable error message</param>
        public ErrorMessage(int code, string message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorMessage"/> class.
        /// </summary>
        /// <param name="code">The error code associated with the error</param>
        /// <param name="message">A readable error message</param>
        /// <param name="args">Arguments to replace in the message string</param>
        public ErrorMessage(int code, string message, params object[] args)
        {
            this.Code = code;
            this.Message = string.Format(message, args);
        }

        /// <summary>
        /// Gets or sets the error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the error code associated with the error
        /// </summary>
        public int Code { get; set; }
    }
}
