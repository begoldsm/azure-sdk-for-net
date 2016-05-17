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
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Contains information about the execution of a Job Preparation task on
    /// a compute node.
    /// </summary>
    public partial class JobPreparationTaskExecutionInformation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// JobPreparationTaskExecutionInformation class.
        /// </summary>
        public JobPreparationTaskExecutionInformation() { }

        /// <summary>
        /// Initializes a new instance of the
        /// JobPreparationTaskExecutionInformation class.
        /// </summary>
        public JobPreparationTaskExecutionInformation(DateTime startTime, JobPreparationTaskState state, int retryCount, DateTime? endTime = default(DateTime?), string taskRootDirectory = default(string), string taskRootDirectoryUrl = default(string), int? exitCode = default(int?), TaskSchedulingError schedulingError = default(TaskSchedulingError), DateTime? lastRetryTime = default(DateTime?))
        {
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            TaskRootDirectory = taskRootDirectory;
            TaskRootDirectoryUrl = taskRootDirectoryUrl;
            ExitCode = exitCode;
            SchedulingError = schedulingError;
            RetryCount = retryCount;
            LastRetryTime = lastRetryTime;
        }

        /// <summary>
        /// Gets or sets the time at which the Job Preparation task started
        /// running.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the Job Preparation task completed.
        /// This property is set only if the task is in the Completed state.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the current running state of the Job Preparation task
        /// on the compute node. Possible values include: 'running',
        /// 'completed'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public JobPreparationTaskState State { get; set; }

        /// <summary>
        /// Gets or sets the root directory of the Job Preparation task on the
        /// compute node.
        /// </summary>
        [JsonProperty(PropertyName = "taskRootDirectory")]
        public string TaskRootDirectory { get; set; }

        /// <summary>
        /// Gets or sets the URL to the root directory of the Job Preparation
        /// task on the compute node.
        /// </summary>
        [JsonProperty(PropertyName = "taskRootDirectoryUrl")]
        public string TaskRootDirectoryUrl { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the Job Preparation task. This
        /// property is set only if the task is in the Completed state.
        /// </summary>
        [JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets any error starting the Job Preparation task.
        /// </summary>
        [JsonProperty(PropertyName = "schedulingError")]
        public TaskSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets the number of times the Job Preparation task has been
        /// retried by the Batch service.
        /// </summary>
        [JsonProperty(PropertyName = "retryCount")]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent time at which a retry of the Job
        /// Preparation task started running. This property is set only if
        /// the task was retried (i.e. retryCount is nonzero).
        /// </summary>
        [JsonProperty(PropertyName = "lastRetryTime")]
        public DateTime? LastRetryTime { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.SchedulingError != null)
            {
                this.SchedulingError.Validate();
            }
        }
    }
}
