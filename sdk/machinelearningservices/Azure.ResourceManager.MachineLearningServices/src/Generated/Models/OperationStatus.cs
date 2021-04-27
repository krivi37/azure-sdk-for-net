// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Operation status. </summary>
    public readonly partial struct OperationStatus : IEquatable<OperationStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="OperationStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string CreateFailedValue = "CreateFailed";
        private const string StartFailedValue = "StartFailed";
        private const string StopFailedValue = "StopFailed";
        private const string RestartFailedValue = "RestartFailed";
        private const string ReimageFailedValue = "ReimageFailed";
        private const string DeleteFailedValue = "DeleteFailed";

        /// <summary> InProgress. </summary>
        public static OperationStatus InProgress { get; } = new OperationStatus(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static OperationStatus Succeeded { get; } = new OperationStatus(SucceededValue);
        /// <summary> CreateFailed. </summary>
        public static OperationStatus CreateFailed { get; } = new OperationStatus(CreateFailedValue);
        /// <summary> StartFailed. </summary>
        public static OperationStatus StartFailed { get; } = new OperationStatus(StartFailedValue);
        /// <summary> StopFailed. </summary>
        public static OperationStatus StopFailed { get; } = new OperationStatus(StopFailedValue);
        /// <summary> RestartFailed. </summary>
        public static OperationStatus RestartFailed { get; } = new OperationStatus(RestartFailedValue);
        /// <summary> ReimageFailed. </summary>
        public static OperationStatus ReimageFailed { get; } = new OperationStatus(ReimageFailedValue);
        /// <summary> DeleteFailed. </summary>
        public static OperationStatus DeleteFailed { get; } = new OperationStatus(DeleteFailedValue);
        /// <summary> Determines if two <see cref="OperationStatus"/> values are the same. </summary>
        public static bool operator ==(OperationStatus left, OperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OperationStatus"/> values are not the same. </summary>
        public static bool operator !=(OperationStatus left, OperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OperationStatus"/>. </summary>
        public static implicit operator OperationStatus(string value) => new OperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
