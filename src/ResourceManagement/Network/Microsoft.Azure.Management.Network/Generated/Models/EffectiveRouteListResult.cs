// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Response for list effective route api servive call
    /// </summary>
    public partial class EffectiveRouteListResult
    {
        /// <summary>
        /// Initializes a new instance of the EffectiveRouteListResult class.
        /// </summary>
        public EffectiveRouteListResult() { }

        /// <summary>
        /// Initializes a new instance of the EffectiveRouteListResult class.
        /// </summary>
        public EffectiveRouteListResult(IList<EffectiveRoute> value = default(IList<EffectiveRoute>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets list of effective routes
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<EffectiveRoute> Value { get; set; }

        /// <summary>
        /// Gets the URL to get the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
