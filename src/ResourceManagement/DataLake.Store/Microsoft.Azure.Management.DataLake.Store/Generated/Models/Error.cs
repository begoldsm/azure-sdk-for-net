// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System.Linq;

    /// <summary>
    /// Data Lake Store error information
    /// </summary>
    public partial class Error
    {
        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        public Error() { }

        /// <summary>
        /// Initializes a new instance of the Error class.
        /// </summary>
        /// <param name="code">the HTTP status code or error code associated
        /// with this error</param>
        /// <param name="message">the error message to display.</param>
        /// <param name="target">the target of the error.</param>
        /// <param name="details">the list of error details</param>
        /// <param name="innerError">the inner exceptions or errors, if
        /// any</param>
        public Error(string code = default(string), string message = default(string), string target = default(string), System.Collections.Generic.IList<ErrorDetails> details = default(System.Collections.Generic.IList<ErrorDetails>), InnerError innerError = default(InnerError))
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
            InnerError = innerError;
        }

        /// <summary>
        /// Gets the HTTP status code or error code associated with this error
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the error message to display.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the target of the error.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "target")]
        public string Target { get; private set; }

        /// <summary>
        /// Gets the list of error details
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "details")]
        public System.Collections.Generic.IList<ErrorDetails> Details { get; private set; }

        /// <summary>
        /// Gets the inner exceptions or errors, if any
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "innerError")]
        public InnerError InnerError { get; private set; }

    }
}
