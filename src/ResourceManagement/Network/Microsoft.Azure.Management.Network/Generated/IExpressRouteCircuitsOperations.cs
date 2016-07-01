// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ExpressRouteCircuitsOperations operations.
    /// </summary>
    public partial interface IExpressRouteCircuitsOperations
    {
        /// <summary>
        /// The delete ExpressRouteCircuit operation deletes the specified
        /// ExpressRouteCircuit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the express route Circuit.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string circuitName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The delete ExpressRouteCircuit operation deletes the specified
        /// ExpressRouteCircuit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the express route Circuit.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string circuitName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Get ExpressRouteCircuit operation retreives information about
        /// the specified ExpressRouteCircuit.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuit>> GetWithHttpMessagesAsync(string resourceGroupName, string circuitName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put ExpressRouteCircuit operation creates/updates a
        /// ExpressRouteCircuit
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create/delete ExpressRouteCircuit
        /// operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuit>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string circuitName, ExpressRouteCircuit parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Put ExpressRouteCircuit operation creates/updates a
        /// ExpressRouteCircuit
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create/delete ExpressRouteCircuit
        /// operation
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuit>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string circuitName, ExpressRouteCircuit parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The ListArpTable from ExpressRouteCircuit opertion retrieves the
        /// currently advertised arp table associated with the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='peeringName'>
        /// The name of the peering.
        /// </param>
        /// <param name='devicePath'>
        /// The path of the device.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitsArpTableListResult>> ListArpTableWithHttpMessagesAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The ListArpTable from ExpressRouteCircuit opertion retrieves the
        /// currently advertised arp table associated with the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='peeringName'>
        /// The name of the peering.
        /// </param>
        /// <param name='devicePath'>
        /// The path of the device.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitsArpTableListResult>> BeginListArpTableWithHttpMessagesAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The ListRoutesTable from ExpressRouteCircuit opertion retrieves
        /// the currently advertised routes table associated with the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='peeringName'>
        /// The name of the peering.
        /// </param>
        /// <param name='devicePath'>
        /// The path of the device.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitsRoutesTableListResult>> ListRoutesTableWithHttpMessagesAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The ListRoutesTable from ExpressRouteCircuit opertion retrieves
        /// the currently advertised routes table associated with the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='peeringName'>
        /// The name of the peering.
        /// </param>
        /// <param name='devicePath'>
        /// The path of the device.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitsRoutesTableListResult>> BeginListRoutesTableWithHttpMessagesAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The ListRoutesTable from ExpressRouteCircuit opertion retrieves
        /// the currently advertised routes table associated with the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='peeringName'>
        /// The name of the peering.
        /// </param>
        /// <param name='devicePath'>
        /// The path of the device.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitsRoutesTableSummaryListResult>> ListRoutesTableSummaryWithHttpMessagesAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The ListRoutesTable from ExpressRouteCircuit opertion retrieves
        /// the currently advertised routes table associated with the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='peeringName'>
        /// The name of the peering.
        /// </param>
        /// <param name='devicePath'>
        /// The path of the device.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitsRoutesTableSummaryListResult>> BeginListRoutesTableSummaryWithHttpMessagesAsync(string resourceGroupName, string circuitName, string peeringName, string devicePath, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Liststats ExpressRouteCircuit opertion retrieves all the stats
        /// from a ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitStats>> GetStatsWithHttpMessagesAsync(string resourceGroupName, string circuitName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The Liststats ExpressRouteCircuit opertion retrieves all the stats
        /// from a ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='circuitName'>
        /// The name of the circuit.
        /// </param>
        /// <param name='peeringName'>
        /// The name of the peering.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<ExpressRouteCircuitStats>> GetPeeringStatsWithHttpMessagesAsync(string resourceGroupName, string circuitName, string peeringName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List ExpressRouteCircuit opertion retrieves all the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ExpressRouteCircuit>>> ListWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List ExpressRouteCircuit opertion retrieves all the
        /// ExpressRouteCircuits in a subscription.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ExpressRouteCircuit>>> ListAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List ExpressRouteCircuit opertion retrieves all the
        /// ExpressRouteCircuits in a resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ExpressRouteCircuit>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The List ExpressRouteCircuit opertion retrieves all the
        /// ExpressRouteCircuits in a subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<ExpressRouteCircuit>>> ListAllNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
