// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for NetworkVirtualAppliancesOperations.
    /// </summary>
    public static partial class NetworkVirtualAppliancesOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            public static NetworkVirtualAppliancesDeleteHeaders Delete(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName)
            {
                return operations.DeleteAsync(resourceGroupName, networkVirtualApplianceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkVirtualAppliancesDeleteHeaders> DeleteAsync(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Gets the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            public static NetworkVirtualAppliance Get(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, string expand = default(string))
            {
                return operations.GetAsync(resourceGroupName, networkVirtualApplianceName, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='expand'>
            /// Expands referenced resources.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkVirtualAppliance> GetAsync(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of Network Virtual Appliance.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance being updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to Update Network Virtual Appliance Tags.
            /// </param>
            public static NetworkVirtualAppliance UpdateTags(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, TagsObject parameters)
            {
                return operations.UpdateTagsAsync(resourceGroupName, networkVirtualApplianceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name of Network Virtual Appliance.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance being updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to Update Network Virtual Appliance Tags.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkVirtualAppliance> UpdateTagsAsync(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, TagsObject parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateTagsWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance.
            /// </param>
            public static NetworkVirtualAppliance CreateOrUpdate(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, networkVirtualApplianceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkVirtualAppliance> CreateOrUpdateAsync(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Network Virtual Appliances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<NetworkVirtualAppliance> ListByResourceGroup(this INetworkVirtualAppliancesOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Network Virtual Appliances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkVirtualAppliance>> ListByResourceGroupAsync(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all Network Virtual Appliances in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<NetworkVirtualAppliance> List(this INetworkVirtualAppliancesOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all Network Virtual Appliances in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetworkVirtualAppliance>> ListAsync(this INetworkVirtualAppliancesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            public static NetworkVirtualAppliancesDeleteHeaders BeginDelete(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, networkVirtualApplianceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkVirtualAppliancesDeleteHeaders> BeginDeleteAsync(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance.
            /// </param>
            public static NetworkVirtualAppliance BeginCreateOrUpdate(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, networkVirtualApplianceName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates the specified Network Virtual Appliance.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='networkVirtualApplianceName'>
            /// The name of Network Virtual Appliance.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update Network Virtual Appliance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetworkVirtualAppliance> BeginCreateOrUpdateAsync(this INetworkVirtualAppliancesOperations operations, string resourceGroupName, string networkVirtualApplianceName, NetworkVirtualAppliance parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, networkVirtualApplianceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all Network Virtual Appliances in a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkVirtualAppliance> ListByResourceGroupNext(this INetworkVirtualAppliancesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all Network Virtual Appliances in a resource group.
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
            public static async Task<IPage<NetworkVirtualAppliance>> ListByResourceGroupNextAsync(this INetworkVirtualAppliancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets all Network Virtual Appliances in a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetworkVirtualAppliance> ListNext(this INetworkVirtualAppliancesOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all Network Virtual Appliances in a subscription.
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
            public static async Task<IPage<NetworkVirtualAppliance>> ListNextAsync(this INetworkVirtualAppliancesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
