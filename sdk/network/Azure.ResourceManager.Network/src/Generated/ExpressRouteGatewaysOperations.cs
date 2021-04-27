// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> The ExpressRouteGateways service client. </summary>
    public partial class ExpressRouteGatewaysOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ExpressRouteGatewaysRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of ExpressRouteGatewaysOperations for mocking. </summary>
        protected ExpressRouteGatewaysOperations()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteGatewaysOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ExpressRouteGatewaysOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ExpressRouteGatewaysRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Lists ExpressRoute gateways under a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteGatewayList>> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.ListBySubscription");
            scope.Start();
            try
            {
                return await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRoute gateways under a given subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteGatewayList> ListBySubscription(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.ListBySubscription");
            scope.Start();
            try
            {
                return RestClient.ListBySubscription(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRoute gateways in a given resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteGatewayList>> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.ListByResourceGroup");
            scope.Start();
            try
            {
                return await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists ExpressRoute gateways in a given resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteGatewayList> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.ListByResourceGroup");
            scope.Start();
            try
            {
                return RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Fetches the details of a ExpressRoute gateway in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRouteGateway>> GetAsync(string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, expressRouteGatewayName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Fetches the details of a ExpressRoute gateway in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRouteGateway> Get(string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, expressRouteGatewayName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a ExpressRoute gateway in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="putExpressRouteGatewayParameters"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRouteGatewayName"/>, or <paramref name="putExpressRouteGatewayParameters"/> is null. </exception>
        public virtual async Task<ExpressRouteGatewaysCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string expressRouteGatewayName, ExpressRouteGateway putExpressRouteGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (putExpressRouteGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteGatewaysCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a ExpressRoute gateway in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="putExpressRouteGatewayParameters"> Parameters required in an ExpressRoute gateway PUT operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="expressRouteGatewayName"/>, or <paramref name="putExpressRouteGatewayParameters"/> is null. </exception>
        public virtual ExpressRouteGatewaysCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string expressRouteGatewayName, ExpressRouteGateway putExpressRouteGatewayParameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }
            if (putExpressRouteGatewayParameters == null)
            {
                throw new ArgumentNullException(nameof(putExpressRouteGatewayParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters, cancellationToken);
                return new ExpressRouteGatewaysCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, expressRouteGatewayName, putExpressRouteGatewayParameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ExpressRoute gateway in a resource group. An ExpressRoute gateway resource can only be deleted when there are no connection subresources. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="expressRouteGatewayName"/> is null. </exception>
        public virtual async Task<ExpressRouteGatewaysDeleteOperation> StartDeleteAsync(string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, expressRouteGatewayName, cancellationToken).ConfigureAwait(false);
                return new ExpressRouteGatewaysDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, expressRouteGatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified ExpressRoute gateway in a resource group. An ExpressRoute gateway resource can only be deleted when there are no connection subresources. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="expressRouteGatewayName"> The name of the ExpressRoute gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="expressRouteGatewayName"/> is null. </exception>
        public virtual ExpressRouteGatewaysDeleteOperation StartDelete(string resourceGroupName, string expressRouteGatewayName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (expressRouteGatewayName == null)
            {
                throw new ArgumentNullException(nameof(expressRouteGatewayName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteGatewaysOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, expressRouteGatewayName, cancellationToken);
                return new ExpressRouteGatewaysDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, expressRouteGatewayName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
