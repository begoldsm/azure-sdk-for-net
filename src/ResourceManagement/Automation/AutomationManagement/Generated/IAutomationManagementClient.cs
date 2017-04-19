// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public partial interface IAutomationManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the resource namespace.
        /// </summary>
        string ResourceNamespace
        {
            get; set; 
        }
        
        /// <summary>
        /// Service operation for automation activities.  (see
        /// http://aka.ms/azureautomationsdk/activityoperations for more
        /// information)
        /// </summary>
        IActivityOperations Activities
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation agent registration information.
        /// (see http://aka.ms/azureautomationsdk/agentregistrationoperations
        /// for more information)
        /// </summary>
        IAgentRegistrationOperation AgentRegistrationInformation
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation accounts.  (see
        /// http://aka.ms/azureautomationsdk/automationaccountoperations for
        /// more information)
        /// </summary>
        IAutomationAccountOperations AutomationAccounts
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation certificates.  (see
        /// http://aka.ms/azureautomationsdk/certificateoperations for more
        /// information)
        /// </summary>
        ICertificateOperations Certificates
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation connections.  (see
        /// http://aka.ms/azureautomationsdk/connectionoperations for more
        /// information)
        /// </summary>
        IConnectionOperations Connections
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation connectiontypes.  (see
        /// http://aka.ms/azureautomationsdk/connectiontypeoperations for more
        /// information)
        /// </summary>
        IConnectionTypeOperations ConnectionTypes
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        ICredentialOperations PsCredentials
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation dsc configuration compile jobs.
        /// (see
        /// http://aka.ms/azureautomationsdk/dscccompilationjoboperations for
        /// more information)
        /// </summary>
        IDscCompilationJobOperations CompilationJobs
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for configurations.  (see
        /// http://aka.ms/azureautomationsdk/configurationoperations for more
        /// information)
        /// </summary>
        IDscConfigurationOperations Configurations
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation dsc node configurations.  (see
        /// http://aka.ms/azureautomationsdk/dscnodeconfigurations for more
        /// information)
        /// </summary>
        IDscNodeConfigurationOperations NodeConfigurations
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for dsc nodes.  (see
        /// http://aka.ms/azureautomationsdk/dscnodeoperations for more
        /// information)
        /// </summary>
        IDscNodeOperations Nodes
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for node reports.  (see
        /// http://aka.ms/azureautomationsdk/dscnodereportoperations for more
        /// information)
        /// </summary>
        IDscNodeReportsOperations NodeReports
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation hybrid runbook worker group.  (see
        /// http://aka.ms/azureautomationsdk/hybridrunbookworkergroupoperations
        /// for more information)
        /// </summary>
        IHybridRunbookWorkerGroupOperations HybridRunbookWorkerGroups
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation jobs.  (see
        /// http://aka.ms/azureautomationsdk/joboperations for more
        /// information)
        /// </summary>
        IJobOperations Jobs
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation job schedules.  (see
        /// http://aka.ms/azureautomationsdk/jobscheduleoperations for more
        /// information)
        /// </summary>
        IJobScheduleOperations JobSchedules
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation job streams.  (see
        /// http://aka.ms/azureautomationsdk/jobstreamoperations for more
        /// information)
        /// </summary>
        IJobStreamOperations JobStreams
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation modules.  (see
        /// http://aka.ms/azureautomationsdk/moduleoperations for more
        /// information)
        /// </summary>
        IModuleOperations Modules
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation runbook draft.  (see
        /// http://aka.ms/azureautomationsdk/runbookdraftoperations for more
        /// information)
        /// </summary>
        IRunbookDraftOperations RunbookDraft
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation runbooks.  (see
        /// http://aka.ms/azureautomationsdk/runbookoperations for more
        /// information)
        /// </summary>
        IRunbookOperations Runbooks
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation schedules.  (see
        /// http://aka.ms/azureautomationsdk/scheduleoperations for more
        /// information)
        /// </summary>
        IScheduleOperations Schedules
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation test jobs.  (see
        /// http://aka.ms/azureautomationsdk/testjoboperations for more
        /// information)
        /// </summary>
        ITestJobOperations TestJobs
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation variables.  (see
        /// http://aka.ms/azureautomationsdk/variableoperations for more
        /// information)
        /// </summary>
        IVariableOperations Variables
        {
            get; 
        }
        
        /// <summary>
        /// Service operation for automation webhook.  (see
        /// http://aka.ms/azureautomationsdk/webhookoperations for more
        /// information)
        /// </summary>
        IWebhookOperations Webhooks
        {
            get; 
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResultResponse> GetOperationResultStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// The Get Operation Status operation returns the status of
        /// thespecified operation. After calling an asynchronous operation,
        /// you can call Get Operation Status to determine whether the
        /// operation has succeeded, failed, or is still in progress.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460783.aspx
        /// for more information)
        /// </summary>
        /// <param name='requestId'>
        /// The request ID for the request you wish to track. The request ID is
        /// returned in the x-ms-request-id response header for every request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        Task<LongRunningOperationStatusResponse> GetOperationStatusAsync(string requestId, CancellationToken cancellationToken);
    }
}
