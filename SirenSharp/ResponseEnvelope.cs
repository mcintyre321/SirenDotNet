namespace SirenSharp
{
    using System.Collections.Generic;

    /// <summary>
    /// This class is used to standardize the result from the JSON part of the API
    /// </summary>
    /// <typeparam name="T">Data object type</typeparam>
    public class ResponseEnvelope<T> where T : IHypermediaEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEnvelope{T}"/> class.
        /// </summary>
        public ResponseEnvelope()
        {
            this.IsSuccess = false;
            this.Data = default(T);
            this.ErrorMessages = new List<Exception>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether the request was successful or not
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets the data result from the request
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets a list of error messages if the request failed
        /// </summary>
        public IList<Exception> ErrorMessages { get; set; }
    }
}
