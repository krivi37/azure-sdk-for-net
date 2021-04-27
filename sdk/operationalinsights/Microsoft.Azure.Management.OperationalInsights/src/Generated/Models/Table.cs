// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Workspace data table definition.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Table : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        public Table()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Table class.
        /// </summary>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="retentionInDays">The data table data retention in
        /// days, between 7 and 730. Setting this property to null will default
        /// to the workspace retention.</param>
        /// <param name="isTroubleshootingAllowed">Specifies if
        /// IsTroubleshootingEnabled property can be set for this
        /// table.</param>
        /// <param name="isTroubleshootEnabled">Enable or disable troubleshoot
        /// for this table.</param>
        /// <param name="lastTroubleshootDate">Last time when troubleshooting
        /// was set for this table.</param>
        public Table(string id = default(string), string name = default(string), string type = default(string), int? retentionInDays = default(int?), bool? isTroubleshootingAllowed = default(bool?), bool? isTroubleshootEnabled = default(bool?), string lastTroubleshootDate = default(string))
            : base(id, name, type)
        {
            RetentionInDays = retentionInDays;
            IsTroubleshootingAllowed = isTroubleshootingAllowed;
            IsTroubleshootEnabled = isTroubleshootEnabled;
            LastTroubleshootDate = lastTroubleshootDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the data table data retention in days, between 7 and
        /// 730. Setting this property to null will default to the workspace
        /// retention.
        /// </summary>
        [JsonProperty(PropertyName = "properties.retentionInDays")]
        public int? RetentionInDays { get; set; }

        /// <summary>
        /// Gets specifies if IsTroubleshootingEnabled property can be set for
        /// this table.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isTroubleshootingAllowed")]
        public bool? IsTroubleshootingAllowed { get; private set; }

        /// <summary>
        /// Gets or sets enable or disable troubleshoot for this table.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isTroubleshootEnabled")]
        public bool? IsTroubleshootEnabled { get; set; }

        /// <summary>
        /// Gets last time when troubleshooting was set for this table.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastTroubleshootDate")]
        public string LastTroubleshootDate { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RetentionInDays > 730)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "RetentionInDays", 730);
            }
            if (RetentionInDays < 7)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "RetentionInDays", 7);
            }
        }
    }
}
