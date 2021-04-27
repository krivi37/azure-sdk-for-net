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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IdentityType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IdentityType
    {
        [EnumMember(Value = "SystemAssigned")]
        SystemAssigned,
        [EnumMember(Value = "UserAssigned")]
        UserAssigned,
        [EnumMember(Value = "None")]
        None
    }
    internal static class IdentityTypeEnumExtension
    {
        internal static string ToSerializedValue(this IdentityType? value)
        {
            return value == null ? null : ((IdentityType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IdentityType value)
        {
            switch( value )
            {
                case IdentityType.SystemAssigned:
                    return "SystemAssigned";
                case IdentityType.UserAssigned:
                    return "UserAssigned";
                case IdentityType.None:
                    return "None";
            }
            return null;
        }

        internal static IdentityType? ParseIdentityType(this string value)
        {
            switch( value )
            {
                case "SystemAssigned":
                    return IdentityType.SystemAssigned;
                case "UserAssigned":
                    return IdentityType.UserAssigned;
                case "None":
                    return IdentityType.None;
            }
            return null;
        }
    }
}
