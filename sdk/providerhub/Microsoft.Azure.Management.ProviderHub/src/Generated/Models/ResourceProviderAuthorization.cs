// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ResourceProviderAuthorization
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderAuthorization
        /// class.
        /// </summary>
        public ResourceProviderAuthorization()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceProviderAuthorization
        /// class.
        /// </summary>
        public ResourceProviderAuthorization(string applicationId = default(string), string roleDefinitionId = default(string), string managedByRoleDefinitionId = default(string))
        {
            ApplicationId = applicationId;
            RoleDefinitionId = roleDefinitionId;
            ManagedByRoleDefinitionId = managedByRoleDefinitionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "roleDefinitionId")]
        public string RoleDefinitionId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "managedByRoleDefinitionId")]
        public string ManagedByRoleDefinitionId { get; set; }

    }
}
