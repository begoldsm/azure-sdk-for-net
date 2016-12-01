// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Description of a Sku Capability
    /// </summary>
    public partial class Capability
    {
        /// <summary>
        /// Initializes a new instance of the Capability class.
        /// </summary>
        public Capability() { }

        /// <summary>
        /// Initializes a new instance of the Capability class.
        /// </summary>
        public Capability(string name = default(string), string value = default(string), string reason = default(string))
        {
            Name = name;
            Value = value;
            Reason = reason;
        }

        /// <summary>
        /// Name of the sku capability
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Value of the sku capability
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Reason of the sku capability
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}
