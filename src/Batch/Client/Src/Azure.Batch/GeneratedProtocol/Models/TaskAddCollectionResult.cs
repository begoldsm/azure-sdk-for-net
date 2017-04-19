// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The result of adding a collection of tasks to a job.
    /// </summary>
    public partial class TaskAddCollectionResult
    {
        /// <summary>
        /// Initializes a new instance of the TaskAddCollectionResult class.
        /// </summary>
        public TaskAddCollectionResult() { }

        /// <summary>
        /// Initializes a new instance of the TaskAddCollectionResult class.
        /// </summary>
        /// <param name="value">The results of the add task collection
        /// operation.</param>
        public TaskAddCollectionResult(System.Collections.Generic.IList<TaskAddResult> value = default(System.Collections.Generic.IList<TaskAddResult>))
        {
            Value = value;
        }

        /// <summary>
        /// Gets or sets the results of the add task collection operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<TaskAddResult> Value { get; set; }

    }
}
