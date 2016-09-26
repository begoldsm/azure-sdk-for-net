// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    public partial class SubResource : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the SubResource class.
        /// </summary>
        public SubResource() { }

        /// <summary>
        /// Initializes a new instance of the SubResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        public SubResource(string id = default(string))
        {
            Id = id;
        }

        /// <summary>
        /// Gets or sets resource Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
