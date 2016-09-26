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
    /// Information about a task running on a compute node.
    /// </summary>
    public partial class TaskInformation
    {
        /// <summary>
        /// Initializes a new instance of the TaskInformation class.
        /// </summary>
        public TaskInformation() { }

        /// <summary>
        /// Initializes a new instance of the TaskInformation class.
        /// </summary>
        /// <param name="taskState">The current state of the task.</param>
        /// <param name="taskUrl">The URL of the task.</param>
        /// <param name="jobId">The id of the job to which the task
        /// belongs.</param>
        /// <param name="taskId">The id of the task.</param>
        /// <param name="subtaskId">The id of the subtask if the task is a
        /// multi-instance task.</param>
        /// <param name="executionInfo">Information about the execution of the
        /// task.</param>
        public TaskInformation(TaskState taskState, string taskUrl = default(string), string jobId = default(string), string taskId = default(string), int? subtaskId = default(int?), TaskExecutionInformation executionInfo = default(TaskExecutionInformation))
        {
            TaskUrl = taskUrl;
            JobId = jobId;
            TaskId = taskId;
            SubtaskId = subtaskId;
            TaskState = taskState;
            ExecutionInfo = executionInfo;
        }

        /// <summary>
        /// Gets or sets the URL of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskUrl")]
        public string TaskUrl { get; set; }

        /// <summary>
        /// Gets or sets the id of the job to which the task belongs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or sets the id of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        /// <summary>
        /// Gets or sets the id of the subtask if the task is a multi-instance
        /// task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subtaskId")]
        public int? SubtaskId { get; set; }

        /// <summary>
        /// Gets or sets the current state of the task.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskState")]
        public TaskState TaskState { get; set; }

        /// <summary>
        /// Gets or sets information about the execution of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executionInfo")]
        public TaskExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ExecutionInfo != null)
            {
                this.ExecutionInfo.Validate();
            }
        }
    }
}
