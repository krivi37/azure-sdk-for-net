// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// StorageTargets operations.
    /// </summary>
    public partial interface IStorageTargets
    {
        /// <summary>
        /// Tells a storage target to refresh its DNS information.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Target resource group.
        /// </param>
        /// <param name='cacheName'>
        /// Name of Cache. Length of name must not be greater than 80 and chars
        /// must be from the [-0-9a-zA-Z_] char class.
        /// </param>
        /// <param name='storageTargetName'>
        /// Name of Storage Target.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DnsRefreshWithHttpMessagesAsync(string resourceGroupName, string cacheName, string storageTargetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a list of Storage Targets for the specified Cache.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Target resource group.
        /// </param>
        /// <param name='cacheName'>
        /// Name of Cache. Length of name must not be greater than 80 and chars
        /// must be from the [-0-9a-zA-Z_] char class.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<StorageTargetsResult>> ListByCacheWithHttpMessagesAsync(string resourceGroupName, string cacheName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Removes a Storage Target from a Cache. This operation is allowed at
        /// any time, but if the Cache is down or unhealthy, the actual removal
        /// of the Storage Target may be delayed until the Cache is healthy
        /// again. Note that if the Cache has data to flush to the Storage
        /// Target, the data will be flushed before the Storage Target will be
        /// deleted.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Target resource group.
        /// </param>
        /// <param name='cacheName'>
        /// Name of Cache. Length of name must not be greater than 80 and chars
        /// must be from the [-0-9a-zA-Z_] char class.
        /// </param>
        /// <param name='storageTargetName'>
        /// Name of Storage Target.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string cacheName, string storageTargetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns a Storage Target from a Cache.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Target resource group.
        /// </param>
        /// <param name='cacheName'>
        /// Name of Cache. Length of name must not be greater than 80 and chars
        /// must be from the [-0-9a-zA-Z_] char class.
        /// </param>
        /// <param name='storageTargetName'>
        /// Name of Storage Target.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<StorageTarget>> GetWithHttpMessagesAsync(string resourceGroupName, string cacheName, string storageTargetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a Storage Target. This operation is allowed at any
        /// time, but if the Cache is down or unhealthy, the actual
        /// creation/modification of the Storage Target may be delayed until
        /// the Cache is healthy again.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Target resource group.
        /// </param>
        /// <param name='cacheName'>
        /// Name of Cache. Length of name must not be greater than 80 and chars
        /// must be from the [-0-9a-zA-Z_] char class.
        /// </param>
        /// <param name='storageTargetName'>
        /// Name of Storage Target.
        /// </param>
        /// <param name='storagetarget'>
        /// Object containing the definition of a Storage Target.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="CloudErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<StorageTarget>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string cacheName, string storageTargetName, StorageTarget storagetarget = default(StorageTarget), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
