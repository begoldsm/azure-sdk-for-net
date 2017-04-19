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
    /// Metadata for the metrics.
    /// </summary>
    [JsonTransformation]
    public partial class ResourceMetricDefinition : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ResourceMetricDefinition class.
        /// </summary>
        public ResourceMetricDefinition() { }

        /// <summary>
        /// Initializes a new instance of the ResourceMetricDefinition class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="resourceMetricDefinitionName">Name of the
        /// metric.</param>
        /// <param name="unit">Unit of the metric.</param>
        /// <param name="primaryAggregationType">Primary aggregation
        /// type.</param>
        /// <param name="metricAvailabilities">List of time grains supported
        /// for the metric together with retention period.</param>
        /// <param name="resourceUri">Resource URI.</param>
        /// <param name="resourceMetricDefinitionId">Resource ID.</param>
        /// <param name="properties">Properties.</param>
        public ResourceMetricDefinition(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceMetricName resourceMetricDefinitionName = default(ResourceMetricName), string unit = default(string), string primaryAggregationType = default(string), IList<ResourceMetricAvailability> metricAvailabilities = default(IList<ResourceMetricAvailability>), string resourceUri = default(string), string resourceMetricDefinitionId = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>))
            : base(location, id, name, kind, type, tags)
        {
            ResourceMetricDefinitionName = resourceMetricDefinitionName;
            Unit = unit;
            PrimaryAggregationType = primaryAggregationType;
            MetricAvailabilities = metricAvailabilities;
            ResourceUri = resourceUri;
            ResourceMetricDefinitionId = resourceMetricDefinitionId;
            Properties = properties;
        }

        /// <summary>
        /// Gets name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "properties.name")]
        public ResourceMetricName ResourceMetricDefinitionName { get; protected set; }

        /// <summary>
        /// Gets unit of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unit")]
        public string Unit { get; protected set; }

        /// <summary>
        /// Gets primary aggregation type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryAggregationType")]
        public string PrimaryAggregationType { get; protected set; }

        /// <summary>
        /// Gets list of time grains supported for the metric together with
        /// retention period.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metricAvailabilities")]
        public IList<ResourceMetricAvailability> MetricAvailabilities { get; protected set; }

        /// <summary>
        /// Gets resource URI.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceUri")]
        public string ResourceUri { get; protected set; }

        /// <summary>
        /// Gets resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.id")]
        public string ResourceMetricDefinitionId { get; protected set; }

        /// <summary>
        /// Gets properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.properties")]
        public IDictionary<string, string> Properties { get; protected set; }

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

