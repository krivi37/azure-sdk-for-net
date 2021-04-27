// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The TransparentDataEncryptions service client. </summary>
    public partial class TransparentDataEncryptionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal TransparentDataEncryptionsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of TransparentDataEncryptionsOperations for mocking. </summary>
        protected TransparentDataEncryptionsOperations()
        {
        }

        /// <summary> Initializes a new instance of TransparentDataEncryptionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal TransparentDataEncryptionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new TransparentDataEncryptionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Creates or updates a database&apos;s transparent data encryption configuration. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database for which setting the transparent data encryption applies. </param>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="parameters"> The required parameters for creating or updating transparent data encryption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TransparentDataEncryption>> CreateOrUpdateAsync(string resourceGroupName, string serverName, string databaseName, TransparentDataEncryptionName transparentDataEncryptionName, TransparentDataEncryption parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TransparentDataEncryptionsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return await RestClient.CreateOrUpdateAsync(resourceGroupName, serverName, databaseName, transparentDataEncryptionName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a database&apos;s transparent data encryption configuration. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database for which setting the transparent data encryption applies. </param>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="parameters"> The required parameters for creating or updating transparent data encryption. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TransparentDataEncryption> CreateOrUpdate(string resourceGroupName, string serverName, string databaseName, TransparentDataEncryptionName transparentDataEncryptionName, TransparentDataEncryption parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TransparentDataEncryptionsOperations.CreateOrUpdate");
            scope.Start();
            try
            {
                return RestClient.CreateOrUpdate(resourceGroupName, serverName, databaseName, transparentDataEncryptionName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a database&apos;s transparent data encryption configuration. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database for which the transparent data encryption applies. </param>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TransparentDataEncryption>> GetAsync(string resourceGroupName, string serverName, string databaseName, TransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TransparentDataEncryptionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, databaseName, transparentDataEncryptionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a database&apos;s transparent data encryption configuration. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="databaseName"> The name of the database for which the transparent data encryption applies. </param>
        /// <param name="transparentDataEncryptionName"> The name of the transparent data encryption configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TransparentDataEncryption> Get(string resourceGroupName, string serverName, string databaseName, TransparentDataEncryptionName transparentDataEncryptionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TransparentDataEncryptionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, databaseName, transparentDataEncryptionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
