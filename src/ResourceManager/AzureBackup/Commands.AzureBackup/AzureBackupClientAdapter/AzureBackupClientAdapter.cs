﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Common.Authentication;
using Microsoft.Azure.Management.BackupServices;
using Microsoft.Azure.Management.BackupServices.Models;
using System;
using System.Net;
using System.Threading;

namespace Microsoft.Azure.Commands.AzureBackup.ClientAdapter
{
    public partial class AzureBackupClientAdapter : ClientAdapterBase
    {
        /// <summary>
        /// Azure vault backup client to talk to IdMgmt.
        /// </summary>
        private BackupVaultServicesManagementClient azureBackupVaultClient;

        /// <summary>
        /// Azure backup client to talk to BMS.
        /// </summary>
        private BackupServicesManagementClient azureBackupClient;

        /// <summary>
        /// Get Azure backup client.
        /// </summary>
        private BackupVaultServicesManagementClient AzureBackupVaultClient
        {
            get
            {
                if (this.azureBackupVaultClient == null)
                {
                    this.azureBackupVaultClient = AzureSession.ClientFactory.CreateCustomClient<BackupVaultServicesManagementClient>(CloudCreds, BaseURI);
                }

                return this.azureBackupVaultClient;
            }
        }

        /// <summary>
        /// Get Azure backup client.
        /// </summary>
        private BackupServicesManagementClient AzureBackupClient
        {
            get
            {
                if (this.azureBackupClient == null)
                {
                    this.azureBackupClient = AzureSession.ClientFactory.CreateCustomClient<BackupServicesManagementClient>(CloudCreds, BaseURI);
                }

                return this.azureBackupClient;
            }
        }

        public AzureBackupClientAdapter(SubscriptionCloudCredentials creds, Uri baseUri)
            : base(creds, baseUri) { }

        internal CustomRequestHeaders GetCustomRequestHeaders()
        {
            var hdrs = new CustomRequestHeaders()
            {
                // ClientRequestId is a unique ID for every request to backend service.
                ClientRequestId = this.ClientRequestId,
            };

            return hdrs;
        }
    }
}

