// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Operation supported by ServiceFabric resource provider
    /// </summary>
    public partial class AvailableOperationDisplay
    {
        /// <summary>
        /// Initializes a new instance of the AvailableOperationDisplay class.
        /// </summary>
        public AvailableOperationDisplay()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableOperationDisplay class.
        /// </summary>
        /// <param name="provider">Provider name</param>
        /// <param name="resource">Resource name</param>
        /// <param name="operation">Operation name</param>
        /// <param name="description">Operation description</param>
        public AvailableOperationDisplay(string provider = default(string), string resource = default(string), string operation = default(string), string description = default(string))
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets provider name
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets or sets resource name
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Gets or sets operation name
        /// </summary>
        [JsonProperty(PropertyName = "operation")]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or sets operation description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
