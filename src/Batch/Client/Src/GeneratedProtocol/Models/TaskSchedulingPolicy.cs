// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies how tasks should be distributed across compute nodes.
    /// </summary>
    public partial class TaskSchedulingPolicy
    {
        /// <summary>
        /// Initializes a new instance of the TaskSchedulingPolicy class.
        /// </summary>
        public TaskSchedulingPolicy() { }

        /// <summary>
        /// Initializes a new instance of the TaskSchedulingPolicy class.
        /// </summary>
        /// <param name="nodeFillType">How tasks should be distributed across
        /// compute nodes</param>
        public TaskSchedulingPolicy(ComputeNodeFillType nodeFillType)
        {
            NodeFillType = nodeFillType;
        }

        /// <summary>
        /// Gets or sets how tasks should be distributed across compute nodes
        /// </summary>
        /// <remarks>
        /// Possible values include: 'spread', 'pack', 'unmapped'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeFillType")]
        public ComputeNodeFillType NodeFillType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
