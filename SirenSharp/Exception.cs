namespace SirenSharp
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents possible error codes for envelope error messages
    /// </summary>
    public enum ErrorCode
    {
        Success = 0,
        InternalAccessOnly = 1000,
        HashInvalid = 1001,
        CredentialsInvalid = 1002,
        RequestNotValidAnymore = 1003,
        ParameterInvalid = 1004
    }

    /// <summary>
    /// This class is used for error messages returned in the JSON part of the API
    /// </summary>
    public class Exception : IHypermediaEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Exception"/> class.
        /// </summary>
        /// <param name="code">The error code associated with the error</param>
        /// <param name="message">A readable error message</param>
        public Exception(int code, string message)
        {
            this.Code = code;
            this.Message = message;
            this.Timestamp = DateTime.Now;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exception"/> class.
        /// </summary>
        /// <param name="code">The error code associated with the error</param>
        /// <param name="message">A readable error message</param>
        /// <param name="args">Arguments to replace in the message string</param>
        public Exception(int code, string message, params object[] args)
        {
            this.Code = code;
            this.Message = string.Format(message, args);
            this.Timestamp = DateTime.Now;
        }

        /// <summary>
        /// Gets or sets the error message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the error code associated with the error
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// Gets or sets the timestamp the error occurred at
        /// </summary>
        public DateTime Timestamp { get; set; }

        public IEnumerable<string> GetSirenRels()
        {
            yield break;
        }

        public IEnumerable<string> GetSirenClasses()
        {
            return new [] { "error" };
        }

        public IEnumerable<Entity> GetSirenSubEntities()
        {
            return new List<Entity>();
        }

        public IEnumerable<Link> GetSirenLinks()
        {
            return new List<Link>();
        }

        public IEnumerable<Action> GetSirenActions()
        {
            return new List<Action>();
        }
    }
}
