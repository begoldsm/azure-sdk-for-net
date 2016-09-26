// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System.Linq;

    /// <summary>
    /// Data Lake Analytics catalog credential creation parameters.
    /// </summary>
    public partial class DataLakeAnalyticsCatalogCredentialCreateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogCredentialCreateParameters class.
        /// </summary>
        public DataLakeAnalyticsCatalogCredentialCreateParameters() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsCatalogCredentialCreateParameters class.
        /// </summary>
        /// <param name="password">the password for the credential and user
        /// with access to the data source.</param>
        /// <param name="uri">the URI identifier for the data source this
        /// credential can connect to in the format <hostname>:<port></param>
        /// <param name="userId">the object identifier for the user associated
        /// with this credential with access to the data source.</param>
        public DataLakeAnalyticsCatalogCredentialCreateParameters(string password, string uri, string userId)
        {
            Password = password;
            Uri = uri;
            UserId = userId;
        }

        /// <summary>
        /// Gets or sets the password for the credential and user with access
        /// to the data source.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the URI identifier for the data source this
        /// credential can connect to in the format
        /// &lt;hostname&gt;:&lt;port&gt;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the object identifier for the user associated with
        /// this credential with access to the data source.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Password == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Password");
            }
            if (Uri == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Uri");
            }
            if (UserId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "UserId");
            }
        }
    }
}
