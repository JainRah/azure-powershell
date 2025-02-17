// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties required to create an endpoint.</summary>
    public partial class EndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParameters"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParameters __endpointPropertiesUpdateParameters = new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.EndpointPropertiesUpdateParameters();

        /// <summary>
        /// List of content types on which compression applies. The value should be a valid MIME type.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string[] ContentTypesToCompress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).ContentTypesToCompress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).ContentTypesToCompress = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="CustomDomain" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedCustomDomain[] _customDomain;

        /// <summary>The custom domains under the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedCustomDomain[] CustomDomain { get => this._customDomain; }

        /// <summary>A reference to the origin group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IResourceReference DefaultOriginGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DefaultOriginGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DefaultOriginGroup = value ?? null /* model class */; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string DefaultOriginGroupId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DefaultOriginGroupId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DefaultOriginGroupId = value ?? null; }

        /// <summary>A policy that specifies the delivery rules to be used for an endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersDeliveryPolicy DeliveryPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DeliveryPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DeliveryPolicy = value ?? null /* model class */; }

        /// <summary>User-friendly description of the policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string DeliveryPolicyDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DeliveryPolicyDescription; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DeliveryPolicyDescription = value ?? null; }

        /// <summary>A list of the delivery rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeliveryRule[] DeliveryPolicyRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DeliveryPolicyRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).DeliveryPolicyRule = value ?? null /* arrayOf */; }

        /// <summary>
        /// List of rules defining the user's geo access within a CDN endpoint. Each geo filter defines an access rule to a specified
        /// path or content, e.g. block APAC for path /pictures/
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IGeoFilter[] GeoFilter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).GeoFilter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).GeoFilter = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="HostName" /> property.</summary>
        private string _hostName;

        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string HostName { get => this._hostName; }

        /// <summary>
        /// Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will
        /// be served as compressed if user requests for a compressed version. Content won't be compressed on CDN when requested content
        /// is smaller than 1 byte or larger than 1 MB.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public bool? IsCompressionEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).IsCompressionEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).IsCompressionEnabled = value ?? default(bool); }

        /// <summary>
        /// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS)
        /// must be allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public bool? IsHttpAllowed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).IsHttpAllowed; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).IsHttpAllowed = value ?? default(bool); }

        /// <summary>
        /// Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS)
        /// must be allowed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public bool? IsHttpsAllowed { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).IsHttpsAllowed; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).IsHttpsAllowed = value ?? default(bool); }

        /// <summary>Internal Acessors for CustomDomain</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedCustomDomain[] Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesInternal.CustomDomain { get => this._customDomain; set { {_customDomain = value;} } }

        /// <summary>Internal Acessors for HostName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesInternal.HostName { get => this._hostName; set { {_hostName = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointResourceState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesInternal.ResourceState { get => this._resourceState; set { {_resourceState = value;} } }

        /// <summary>
        /// Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media services. With this
        /// information, CDN can apply scenario driven optimization.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OptimizationType? OptimizationType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).OptimizationType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).OptimizationType = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.OptimizationType)""); }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOrigin[] _origin;

        /// <summary>The source of the content being delivered via CDN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOrigin[] Origin { get => this._origin; set => this._origin = value; }

        /// <summary>Backing field for <see cref="OriginGroup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOriginGroup[] _originGroup;

        /// <summary>
        /// The origin groups comprising of origins that are used for load balancing the traffic based on availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOriginGroup[] OriginGroup { get => this._originGroup; set => this._originGroup = value; }

        /// <summary>
        /// The host header value sent to the origin with each request. This property at Endpoint is only allowed when endpoint uses
        /// single origin and can be overridden by the same property specified at origin.If you leave this blank, the request hostname
        /// determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header
        /// value to match the origin hostname by default.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string OriginHostHeader { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).OriginHostHeader; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).OriginHostHeader = value ?? null; }

        /// <summary>
        /// A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string OriginPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).OriginPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).OriginPath = value ?? null; }

        /// <summary>
        /// Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal
        /// routes for the CDN. This is relative to the origin path. This property is only relevant when using a single origin.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string ProbePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).ProbePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).ProbePath = value ?? null; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointProvisioningState? _provisioningState;

        /// <summary>Provisioning status of the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching
        /// to prevent requests that contain query strings from being cached, or cache every request with a unique URL.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringCachingBehavior? QueryStringCachingBehavior { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).QueryStringCachingBehavior; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).QueryStringCachingBehavior = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.QueryStringCachingBehavior)""); }

        /// <summary>Backing field for <see cref="ResourceState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointResourceState? _resourceState;

        /// <summary>Resource status of the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointResourceState? ResourceState { get => this._resourceState; }

        /// <summary>List of keys used to validate the signed URL hashes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IUrlSigningKey[] UrlSigningKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).UrlSigningKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).UrlSigningKey = value ?? null /* arrayOf */; }

        /// <summary>Defines the Web Application Firewall policy for the endpoint (if applicable)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink WebApplicationFirewallPolicyLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).WebApplicationFirewallPolicyLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).WebApplicationFirewallPolicyLink = value ?? null /* model class */; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inherited)]
        public string WebApplicationFirewallPolicyLinkId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).WebApplicationFirewallPolicyLinkId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal)__endpointPropertiesUpdateParameters).WebApplicationFirewallPolicyLinkId = value ?? null; }

        /// <summary>Creates an new <see cref="EndpointProperties" /> instance.</summary>
        public EndpointProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__endpointPropertiesUpdateParameters), __endpointPropertiesUpdateParameters);
            await eventListener.AssertObjectIsValid(nameof(__endpointPropertiesUpdateParameters), __endpointPropertiesUpdateParameters);
        }
    }
    /// The JSON object that contains the properties required to create an endpoint.
    public partial interface IEndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParameters
    {
        /// <summary>The custom domains under the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The custom domains under the endpoint.",
        SerializedName = @"customDomains",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedCustomDomain) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedCustomDomain[] CustomDomain { get;  }
        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get;  }
        /// <summary>The source of the content being delivered via CDN.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The source of the content being delivered via CDN.",
        SerializedName = @"origins",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOrigin) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOrigin[] Origin { get; set; }
        /// <summary>
        /// The origin groups comprising of origins that are used for load balancing the traffic based on availability.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The origin groups comprising of origins that are used for load balancing the traffic based on availability.",
        SerializedName = @"originGroups",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOriginGroup) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOriginGroup[] OriginGroup { get; set; }
        /// <summary>Provisioning status of the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning status of the endpoint.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointProvisioningState? ProvisioningState { get;  }
        /// <summary>Resource status of the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource status of the endpoint.",
        SerializedName = @"resourceState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointResourceState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointResourceState? ResourceState { get;  }

    }
    /// The JSON object that contains the properties required to create an endpoint.
    internal partial interface IEndpointPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IEndpointPropertiesUpdateParametersInternal
    {
        /// <summary>The custom domains under the endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedCustomDomain[] CustomDomain { get; set; }
        /// <summary>
        /// The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net
        /// </summary>
        string HostName { get; set; }
        /// <summary>The source of the content being delivered via CDN.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOrigin[] Origin { get; set; }
        /// <summary>
        /// The origin groups comprising of origins that are used for load balancing the traffic based on availability.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20230501.IDeepCreatedOriginGroup[] OriginGroup { get; set; }
        /// <summary>Provisioning status of the endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointProvisioningState? ProvisioningState { get; set; }
        /// <summary>Resource status of the endpoint.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.EndpointResourceState? ResourceState { get; set; }

    }
}