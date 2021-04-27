// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The AcrRefreshToken. </summary>
    internal partial class AcrRefreshToken
    {
        /// <summary> Initializes a new instance of AcrRefreshToken. </summary>
        internal AcrRefreshToken()
        {
        }

        /// <summary> Initializes a new instance of AcrRefreshToken. </summary>
        /// <param name="refreshToken"> The refresh token to be used for generating access tokens. </param>
        internal AcrRefreshToken(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        /// <summary> The refresh token to be used for generating access tokens. </summary>
        public string RefreshToken { get; }
    }
}
