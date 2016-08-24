// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.KeyVault.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Secret consisting of a value, id and its attributes.
    /// </summary>
    public partial class SecretBundle
    {
        /// <summary>
        /// Initializes a new instance of the SecretBundle class.
        /// </summary>
        public SecretBundle() { }

        /// <summary>
        /// Initializes a new instance of the SecretBundle class.
        /// </summary>
        /// <param name="value">The secret value </param>
        /// <param name="id">The secret id</param>
        /// <param name="contentType">The content type of the secret</param>
        /// <param name="attributes">The secret management attributes</param>
        /// <param name="tags">Application-specific metadata in the form of
        /// key-value pairs</param>
        /// <param name="kid">The key id for certificate.</param>
        public SecretBundle(string value = default(string), string id = default(string), string contentType = default(string), SecretAttributes attributes = default(SecretAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>), string kid = default(string))
        {
            Value = value;
            Id = id;
            ContentType = contentType;
            Attributes = attributes;
            Tags = tags;
            Kid = kid;
        }

        /// <summary>
        /// Gets or sets the secret value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the secret id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the content type of the secret
        /// </summary>
        [JsonProperty(PropertyName = "contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or sets the secret management attributes
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public SecretAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of
        /// key-value pairs
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the key id for certificate.
        /// </summary>
        [JsonProperty(PropertyName = "kid")]
        public string Kid { get; set; }

    }
}
