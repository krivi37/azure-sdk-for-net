// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    internal static partial class RecommendedIndexStateExtensions
    {
        public static string ToSerialString(this RecommendedIndexState value) => value switch
        {
            RecommendedIndexState.Active => "Active",
            RecommendedIndexState.Pending => "Pending",
            RecommendedIndexState.Executing => "Executing",
            RecommendedIndexState.Verifying => "Verifying",
            RecommendedIndexState.PendingRevert => "Pending Revert",
            RecommendedIndexState.Reverting => "Reverting",
            RecommendedIndexState.Reverted => "Reverted",
            RecommendedIndexState.Ignored => "Ignored",
            RecommendedIndexState.Expired => "Expired",
            RecommendedIndexState.Blocked => "Blocked",
            RecommendedIndexState.Success => "Success",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecommendedIndexState value.")
        };

        public static RecommendedIndexState ToRecommendedIndexState(this string value)
        {
            if (string.Equals(value, "Active", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Active;
            if (string.Equals(value, "Pending", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Pending;
            if (string.Equals(value, "Executing", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Executing;
            if (string.Equals(value, "Verifying", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Verifying;
            if (string.Equals(value, "Pending Revert", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.PendingRevert;
            if (string.Equals(value, "Reverting", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Reverting;
            if (string.Equals(value, "Reverted", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Reverted;
            if (string.Equals(value, "Ignored", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Ignored;
            if (string.Equals(value, "Expired", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Expired;
            if (string.Equals(value, "Blocked", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Blocked;
            if (string.Equals(value, "Success", StringComparison.InvariantCultureIgnoreCase)) return RecommendedIndexState.Success;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RecommendedIndexState value.");
        }
    }
}
