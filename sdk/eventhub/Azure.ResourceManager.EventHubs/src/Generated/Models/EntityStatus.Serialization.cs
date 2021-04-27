// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal static partial class EntityStatusExtensions
    {
        public static string ToSerialString(this EntityStatus value) => value switch
        {
            EntityStatus.Active => "Active",
            EntityStatus.Disabled => "Disabled",
            EntityStatus.Restoring => "Restoring",
            EntityStatus.SendDisabled => "SendDisabled",
            EntityStatus.ReceiveDisabled => "ReceiveDisabled",
            EntityStatus.Creating => "Creating",
            EntityStatus.Deleting => "Deleting",
            EntityStatus.Renaming => "Renaming",
            EntityStatus.Unknown => "Unknown",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EntityStatus value.")
        };

        public static EntityStatus ToEntityStatus(this string value)
        {
            if (string.Equals(value, "Active", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.Active;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.Disabled;
            if (string.Equals(value, "Restoring", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.Restoring;
            if (string.Equals(value, "SendDisabled", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.SendDisabled;
            if (string.Equals(value, "ReceiveDisabled", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.ReceiveDisabled;
            if (string.Equals(value, "Creating", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.Creating;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.Deleting;
            if (string.Equals(value, "Renaming", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.Renaming;
            if (string.Equals(value, "Unknown", StringComparison.InvariantCultureIgnoreCase)) return EntityStatus.Unknown;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EntityStatus value.");
        }
    }
}
