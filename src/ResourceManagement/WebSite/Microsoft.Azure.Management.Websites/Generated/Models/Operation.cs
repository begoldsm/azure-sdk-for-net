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
    /// Class that represents an operation.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation() { }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation(OperationStatus status, string id = default(string), string name = default(string), IList<ErrorEntity> errors = default(IList<ErrorEntity>), DateTime? createdTime = default(DateTime?), DateTime? modifiedTime = default(DateTime?), DateTime? expirationTime = default(DateTime?), string geoMasterOperationId = default(string))
        {
            Id = id;
            Name = name;
            Status = status;
            Errors = errors;
            CreatedTime = createdTime;
            ModifiedTime = modifiedTime;
            ExpirationTime = expirationTime;
            GeoMasterOperationId = geoMasterOperationId;
        }

        /// <summary>
        /// Operation Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Operation Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The current status of the operation. Possible values include:
        /// 'InProgress', 'Failed', 'Succeeded', 'TimedOut', 'Created'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public OperationStatus Status { get; set; }

        /// <summary>
        /// Any errors associate with the operation
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<ErrorEntity> Errors { get; set; }

        /// <summary>
        /// Time when operation has started
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Time when operation has been updated
        /// </summary>
        [JsonProperty(PropertyName = "modifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// Time when operation will expire
        /// </summary>
        [JsonProperty(PropertyName = "expirationTime")]
        public DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Applicable only for stamp operation ids.
        /// </summary>
        [JsonProperty(PropertyName = "geoMasterOperationId")]
        public string GeoMasterOperationId { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
        }
    }
}
