// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> A class representing collection of MhsmPrivateEndpointConnection and their operations over a ManagedHsm. </summary>
    public partial class MhsmPrivateEndpointConnectionContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="MhsmPrivateEndpointConnectionContainer"/> class for mocking. </summary>
        protected MhsmPrivateEndpointConnectionContainer()
        {
        }

        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal MhsmPrivateEndpointConnectionContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private MhsmPrivateEndpointConnectionsRestOperations _restClient => new MhsmPrivateEndpointConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedHsmOperations.ResourceType;

        // Container level operations.

        /// <summary> Updates the specified private endpoint connection associated with the managed hsm pool. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public virtual Response<MhsmPrivateEndpointConnection> CreateOrUpdate(string privateEndpointConnectionName, MhsmPrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(privateEndpointConnectionName, properties, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified private endpoint connection associated with the managed hsm pool. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<Response<MhsmPrivateEndpointConnection>> CreateOrUpdateAsync(string privateEndpointConnectionName, MhsmPrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(privateEndpointConnectionName, properties, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified private endpoint connection associated with the managed hsm pool. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public virtual MhsmPrivateEndpointConnectionsPutOperation StartCreateOrUpdate(string privateEndpointConnectionName, MhsmPrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.Put(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken);
                return new MhsmPrivateEndpointConnectionsPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates the specified private endpoint connection associated with the managed hsm pool. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="properties"> The intended state of private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="properties"/> is null. </exception>
        public async virtual Task<MhsmPrivateEndpointConnectionsPutOperation> StartCreateOrUpdateAsync(string privateEndpointConnectionName, MhsmPrivateEndpointConnectionData properties, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.PutAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, properties, cancellationToken).ConfigureAwait(false);
                return new MhsmPrivateEndpointConnectionsPutOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<MhsmPrivateEndpointConnection> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.Get");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MhsmPrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<MhsmPrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.Get");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MhsmPrivateEndpointConnection(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<MhsmPrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<MhsmPrivateEndpointConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new MhsmPrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<MhsmPrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<MhsmPrivateEndpointConnection>(null, response.GetRawResponse())
                    : Response.FromValue(new MhsmPrivateEndpointConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = GetIfExists(privateEndpointConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionName"> Name of the private endpoint connection associated with the managed hsm pool. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (privateEndpointConnectionName == null)
                {
                    throw new ArgumentNullException(nameof(privateEndpointConnectionName));
                }

                var response = await GetIfExistsAsync(privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The List operation gets information about the private endpoint connections associated with the managed HSM Pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MhsmPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<MhsmPrivateEndpointConnection> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MhsmPrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResource(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MhsmPrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetByResourceNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the private endpoint connections associated with the managed HSM Pool. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MhsmPrivateEndpointConnection" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<MhsmPrivateEndpointConnection> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MhsmPrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MhsmPrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetByResourceNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MhsmPrivateEndpointConnection(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="MhsmPrivateEndpointConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(MhsmPrivateEndpointConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="MhsmPrivateEndpointConnection" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("MhsmPrivateEndpointConnectionContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(MhsmPrivateEndpointConnectionOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, MhsmPrivateEndpointConnection, MhsmPrivateEndpointConnectionData> Construct() { }
    }
}
