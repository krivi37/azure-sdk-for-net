// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.Storage.Blobs.Models;

namespace Azure.Storage.Blobs
{
    internal partial class BlobQueryHeaders
    {
        private readonly Response _response;
        public BlobQueryHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Returns the date and time the container was last modified. Any operation that modifies the blob, including an update of the blob&apos;s metadata or properties, changes the last-modified time of the blob. </summary>
        public DateTimeOffset? LastModified => _response.Headers.TryGetValue("Last-Modified", out DateTimeOffset? value) ? value : null;
        public IDictionary<string, string> Metadata => _response.Headers.TryGetValue("x-ms-meta-", out IDictionary<string, string> value) ? value : null;
        /// <summary> The number of bytes present in the response body. </summary>
        public long? ContentLength => _response.Headers.TryGetValue("Content-Length", out long? value) ? value : null;
        /// <summary> The media type of the body of the response. For Download Blob this is &apos;application/octet-stream&apos;. </summary>
        public string ContentType => _response.Headers.TryGetValue("Content-Type", out string value) ? value : null;
        /// <summary> Indicates the range of bytes returned in the event that the client requested a subset of the blob by setting the &apos;Range&apos; request header. </summary>
        public string ContentRange => _response.Headers.TryGetValue("Content-Range", out string value) ? value : null;
        /// <summary> If the blob has an MD5 hash and this operation is to read the full blob, this response header is returned so that the client can check for message content integrity. </summary>
        public byte[] ContentMD5 => _response.Headers.TryGetValue("Content-MD5", out byte[] value) ? value : null;
        /// <summary> This header returns the value that was specified for the Content-Encoding request header. </summary>
        public string ContentEncoding => _response.Headers.TryGetValue("Content-Encoding", out string value) ? value : null;
        /// <summary> This header is returned if it was previously specified for the blob. </summary>
        public string CacheControl => _response.Headers.TryGetValue("Cache-Control", out string value) ? value : null;
        /// <summary> This header returns the value that was specified for the &apos;x-ms-blob-content-disposition&apos; header. The Content-Disposition response header field conveys additional information about how to process the response payload, and also can be used to attach additional metadata. For example, if set to attachment, it indicates that the user-agent should not display the response, but instead show a Save As dialog with a filename other than the blob name specified. </summary>
        public string ContentDisposition => _response.Headers.TryGetValue("Content-Disposition", out string value) ? value : null;
        /// <summary> This header returns the value that was specified for the Content-Language request header. </summary>
        public string ContentLanguage => _response.Headers.TryGetValue("Content-Language", out string value) ? value : null;
        /// <summary> The current sequence number for a page blob. This header is not returned for block blobs or append blobs. </summary>
        public long? BlobSequenceNumber => _response.Headers.TryGetValue("x-ms-blob-sequence-number", out long? value) ? value : null;
        /// <summary> The blob&apos;s type. </summary>
        public BlobType? BlobType => _response.Headers.TryGetValue("x-ms-blob-type", out string value) ? value.ToBlobType() : null;
        /// <summary> Conclusion time of the last attempted Copy Blob operation where this blob was the destination blob. This value can specify the time of a completed, aborted, or failed copy attempt. This header does not appear if a copy is pending, if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public DateTimeOffset? CopyCompletionTime => _response.Headers.TryGetValue("x-ms-copy-completion-time", out DateTimeOffset? value) ? value : null;
        /// <summary> Only appears when x-ms-copy-status is failed or pending. Describes the cause of the last fatal or non-fatal copy operation failure. This header does not appear if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public string CopyStatusDescription => _response.Headers.TryGetValue("x-ms-copy-status-description", out string value) ? value : null;
        /// <summary> String identifier for this copy operation. Use with Get Blob Properties to check the status of this copy operation, or pass to Abort Copy Blob to abort a pending copy. </summary>
        public string CopyId => _response.Headers.TryGetValue("x-ms-copy-id", out string value) ? value : null;
        /// <summary> Contains the number of bytes copied and the total bytes in the source in the last attempted Copy Blob operation where this blob was the destination blob. Can show between 0 and Content-Length bytes copied. This header does not appear if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public string CopyProgress => _response.Headers.TryGetValue("x-ms-copy-progress", out string value) ? value : null;
        /// <summary> URL up to 2 KB in length that specifies the source blob or file used in the last attempted Copy Blob operation where this blob was the destination blob. This header does not appear if this blob has never been the destination in a Copy Blob operation, or if this blob has been modified after a concluded Copy Blob operation using Set Blob Properties, Put Blob, or Put Block List. </summary>
        public string CopySource => _response.Headers.TryGetValue("x-ms-copy-source", out string value) ? value : null;
        /// <summary> State of the copy operation identified by x-ms-copy-id. </summary>
        public CopyStatus? CopyStatus => _response.Headers.TryGetValue("x-ms-copy-status", out string value) ? value.ToCopyStatus() : null;
        /// <summary> When a blob is leased, specifies whether the lease is of infinite or fixed duration. </summary>
        public LeaseDurationType? LeaseDuration => _response.Headers.TryGetValue("x-ms-lease-duration", out string value) ? value.ToLeaseDurationType() : null;
        /// <summary> Lease state of the blob. </summary>
        public LeaseState? LeaseState => _response.Headers.TryGetValue("x-ms-lease-state", out string value) ? value.ToLeaseState() : null;
        /// <summary> The current lease status of the blob. </summary>
        public LeaseStatus? LeaseStatus => _response.Headers.TryGetValue("x-ms-lease-status", out string value) ? value.ToLeaseStatus() : null;
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> Indicates that the service supports requests for partial blob content. </summary>
        public string AcceptRanges => _response.Headers.TryGetValue("Accept-Ranges", out string value) ? value : null;
        /// <summary> The number of committed blocks present in the blob. This header is returned only for append blobs. </summary>
        public int? BlobCommittedBlockCount => _response.Headers.TryGetValue("x-ms-blob-committed-block-count", out int? value) ? value : null;
        /// <summary> The value of this header is set to true if the blob data and application metadata are completely encrypted using the specified algorithm. Otherwise, the value is set to false (when the blob is unencrypted, or if only parts of the blob/application metadata are encrypted). </summary>
        public bool? IsServerEncrypted => _response.Headers.TryGetValue("x-ms-server-encrypted", out bool? value) ? value : null;
        /// <summary> The SHA-256 hash of the encryption key used to encrypt the blob. This header is only returned when the blob was encrypted with a customer-provided key. </summary>
        public string EncryptionKeySha256 => _response.Headers.TryGetValue("x-ms-encryption-key-sha256", out string value) ? value : null;
        /// <summary> Returns the name of the encryption scope used to encrypt the blob contents and application metadata.  Note that the absence of this header implies use of the default account encryption scope. </summary>
        public string EncryptionScope => _response.Headers.TryGetValue("x-ms-encryption-scope", out string value) ? value : null;
        /// <summary> If the blob has a MD5 hash, and if request contains range header (Range or x-ms-range), this response header is returned with the value of the whole blob&apos;s MD5 value. This value may or may not be equal to the value returned in Content-MD5 header, with the latter calculated from the requested range. </summary>
        public byte[] BlobContentMD5 => _response.Headers.TryGetValue("x-ms-blob-content-md5", out byte[] value) ? value : null;
        /// <summary> If the request is to read a specified range and the x-ms-range-get-content-crc64 is set to true, then the request returns a crc64 for the range, as long as the range size is less than or equal to 4 MB. If both x-ms-range-get-content-crc64 and x-ms-range-get-content-md5 is specified in the same request, it will fail with 400(Bad Request). </summary>
        public byte[] ContentCrc64 => _response.Headers.TryGetValue("x-ms-content-crc64", out byte[] value) ? value : null;
    }
}
