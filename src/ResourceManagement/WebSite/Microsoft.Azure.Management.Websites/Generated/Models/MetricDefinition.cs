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
    /// Class repesenting metadata for the metrics
    /// </summary>
    [JsonTransformation]
    public partial class MetricDefinition : Resource
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition() { }

        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition(string name, string location, string id = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string metricDefinitionName = default(string), string unit = default(string), string primaryAggregationType = default(string), IList<MetricAvailabilily> metricAvailabilities = default(IList<MetricAvailabilily>), string displayName = default(string))
            : base(name, location, id, kind, type, tags)
        {
            MetricDefinitionName = metricDefinitionName;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            MetricAvailabilities = metricAvailabilities;
            DisplayName = displayName;
        }

        /// <summary>
        /// Name of the metric
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public string MetricDefinitionName { get; set; }

        /// <summary>
        /// Unit of the metric
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Primary aggregation type
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAggregationType")]
        public string PrimaryAggregationType { get; set; }

        /// <summary>
        /// List of time grains supported for the metric together with
        /// retention period
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricAvailabilities")]
        public IList<MetricAvailabilily> MetricAvailabilities { get; set; }

        /// <summary>
        /// Friendly name shown in the UI
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
