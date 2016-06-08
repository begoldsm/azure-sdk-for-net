// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL distribution information object.
    /// </summary>
    public partial class USqlDistributionInfo
    {
        /// <summary>
        /// Initializes a new instance of the USqlDistributionInfo class.
        /// </summary>
        public USqlDistributionInfo() { }

        /// <summary>
        /// Initializes a new instance of the USqlDistributionInfo class.
        /// </summary>
        public USqlDistributionInfo(int? type = default(int?), IList<USqlDirectedColumn> keys = default(IList<USqlDirectedColumn>), int? count = default(int?), int? dynamicCount = default(int?))
        {
            Type = type;
            Keys = keys;
            Count = count;
            DynamicCount = dynamicCount;
        }

        /// <summary>
        /// Gets or sets gets or sets the type of this distribution.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the list of directed columns in the
        /// distribution
        /// </summary>
        [JsonProperty(PropertyName = "keys")]
        public IList<USqlDirectedColumn> Keys { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the count of indices using this
        /// distribution.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets gets or sets the dynamic count of indices using this
        /// distribution.
        /// </summary>
        [JsonProperty(PropertyName = "dynamicCount")]
        public int? DynamicCount { get; set; }

    }
}
