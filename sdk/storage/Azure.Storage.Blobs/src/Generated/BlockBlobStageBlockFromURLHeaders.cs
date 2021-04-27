// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.Storage.Blobs
{
    internal partial class BlockBlobStageBlockFromURLHeaders
    {
        private readonly Response _response;
        public BlockBlobStageBlockFromURLHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> This header is returned so that the client can check for message content integrity. The value of this header is computed by the Blob service; it is not necessarily the same value specified in the request headers. </summary>
        public byte[] ContentMD5 => _response.Headers.TryGetValue("Content-MD5", out byte[] value) ? value : null;
        /// <summary> This header is returned so that the client can check for message content integrity. The value of this header is computed by the Blob service; it is not necessarily the same value specified in the request headers. </summary>
        public byte[] XMsContentCrc64 => _response.Headers.TryGetValue("x-ms-content-crc64", out byte[] value) ? value : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> The value of this header is set to true if the contents of the request are successfully encrypted using the specified algorithm, and false otherwise. </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-request-server-encrypted", out bool? value) ? value : null;
        /// <summary> The SHA-256 hash of the encryption key used to encrypt the block. This header is only returned when the block was encrypted with a customer-provided key. </summary>
        public string EncryptionKeySha256 => _response.Headers.TryGetValue("x-ms-encryption-key-sha256", out string value) ? value : null;
        /// <summary> Returns the name of the encryption scope used to encrypt the blob contents and application metadata.  Note that the absence of this header implies use of the default account encryption scope. </summary>
        public string EncryptionScope => _response.Headers.TryGetValue("x-ms-encryption-scope", out string value) ? value : null;
    }
}
