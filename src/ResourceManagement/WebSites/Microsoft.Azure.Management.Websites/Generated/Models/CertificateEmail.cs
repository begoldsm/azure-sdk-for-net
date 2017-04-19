// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Azure;
    using Management;
    using WebSites;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// SSL certificate email.
    /// </summary>
    [JsonTransformation]
    public partial class CertificateEmail : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateEmail class.
        /// </summary>
        public CertificateEmail() { }

        /// <summary>
        /// Initializes a new instance of the CertificateEmail class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="emailId">Email id.</param>
        /// <param name="timeStamp">Time stamp.</param>
        public CertificateEmail(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string emailId = default(string), System.DateTime? timeStamp = default(System.DateTime?))
            : base(location, id, name, kind, type, tags)
        {
            EmailId = emailId;
            TimeStamp = timeStamp;
        }

        /// <summary>
        /// Gets or sets email id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.emailId")]
        public string EmailId { get; set; }

        /// <summary>
        /// Gets or sets time stamp.
        /// </summary>
        [JsonProperty(PropertyName = "properties.timeStamp")]
        public System.DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

