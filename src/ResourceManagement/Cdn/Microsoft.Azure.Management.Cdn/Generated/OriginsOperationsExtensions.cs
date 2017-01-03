// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using Azure;
    using Management;
    using Rest;
    using Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for OriginsOperations.
    /// </summary>
    public static partial class OriginsOperationsExtensions
    {
            /// <summary>
            /// Lists all of the existing origins within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            public static IPage<Origin> ListByEndpoint(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName)
            {
                return operations.ListByEndpointAsync(resourceGroupName, profileName, endpointName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the existing origins within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Origin>> ListByEndpointAsync(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEndpointWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets an existing origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin which is unique within the endpoint.
            /// </param>
            public static Origin Get(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName, string originName)
            {
                return operations.GetAsync(resourceGroupName, profileName, endpointName, originName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an existing origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin which is unique within the endpoint.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> GetAsync(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName, string originName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin which is unique within the endpoint.
            /// </param>
            /// <param name='originUpdateProperties'>
            /// Origin properties
            /// </param>
            public static Origin Update(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName, string originName, OriginUpdateParameters originUpdateProperties)
            {
                return operations.UpdateAsync(resourceGroupName, profileName, endpointName, originName, originUpdateProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin which is unique within the endpoint.
            /// </param>
            /// <param name='originUpdateProperties'>
            /// Origin properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> UpdateAsync(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName, string originName, OriginUpdateParameters originUpdateProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originName, originUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin which is unique within the endpoint.
            /// </param>
            /// <param name='originUpdateProperties'>
            /// Origin properties
            /// </param>
            public static Origin BeginUpdate(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName, string originName, OriginUpdateParameters originUpdateProperties)
            {
                return operations.BeginUpdateAsync(resourceGroupName, profileName, endpointName, originName, originUpdateProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing origin within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile which is unique within the resource group.
            /// </param>
            /// <param name='endpointName'>
            /// Name of the endpoint under the profile which is unique globally.
            /// </param>
            /// <param name='originName'>
            /// Name of the origin which is unique within the endpoint.
            /// </param>
            /// <param name='originUpdateProperties'>
            /// Origin properties
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Origin> BeginUpdateAsync(this IOriginsOperations operations, string resourceGroupName, string profileName, string endpointName, string originName, OriginUpdateParameters originUpdateProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, profileName, endpointName, originName, originUpdateProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the existing origins within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Origin> ListByEndpointNext(this IOriginsOperations operations, string nextPageLink)
            {
                return operations.ListByEndpointNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the existing origins within an endpoint.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Origin>> ListByEndpointNextAsync(this IOriginsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByEndpointNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

