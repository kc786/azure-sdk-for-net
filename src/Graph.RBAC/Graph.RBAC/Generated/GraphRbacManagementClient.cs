// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Graph.RBAC;

namespace Microsoft.Azure.Graph.RBAC
{
    public partial class GraphRbacManagementClient : ServiceClient<GraphRbacManagementClient>, IGraphRbacManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private string _tenantID;
        
        /// <summary>
        /// Gets or sets the tenant Id.
        /// </summary>
        public string TenantID
        {
            get { return this._tenantID; }
            set { this._tenantID = value; }
        }
        
        private IApplicationOperations _application;
        
        /// <summary>
        /// Operations for working with applications in Azure Active Directory
        /// Graph API.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx for
        /// more information)
        /// </summary>
        public virtual IApplicationOperations Application
        {
            get { return this._application; }
        }
        
        private IGroupOperations _group;
        
        /// <summary>
        /// Operations for working with Groups in Azure Active Directory Graph
        /// API.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx for
        /// more information)
        /// </summary>
        public virtual IGroupOperations Group
        {
            get { return this._group; }
        }
        
        private IObjectOperations _objects;
        
        /// <summary>
        /// Operations for working with Objects in Azure AD Graph API.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx for
        /// more information)
        /// </summary>
        public virtual IObjectOperations Objects
        {
            get { return this._objects; }
        }
        
        private IServicePrincipalOperations _servicePrincipal;
        
        /// <summary>
        /// Operations for working with service principal in Azure Active
        /// Directory Graph API.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx for
        /// more information)
        /// </summary>
        public virtual IServicePrincipalOperations ServicePrincipal
        {
            get { return this._servicePrincipal; }
        }
        
        private IUserOperations _user;
        
        /// <summary>
        /// Operations for working with Users in Azure Active Directory Graph
        /// API.  (see
        /// http://msdn.microsoft.com/en-us/library/azure/hh974476.aspx for
        /// more information)
        /// </summary>
        public virtual IUserOperations User
        {
            get { return this._user; }
        }
        
        /// <summary>
        /// Initializes a new instance of the GraphRbacManagementClient class.
        /// </summary>
        public GraphRbacManagementClient()
            : base()
        {
            this._application = new ApplicationOperations(this);
            this._group = new GroupOperations(this);
            this._objects = new ObjectOperations(this);
            this._servicePrincipal = new ServicePrincipalOperations(this);
            this._user = new UserOperations(this);
            this._apiVersion = "1.6-internal";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the GraphRbacManagementClient class.
        /// </summary>
        /// <param name='tenantID'>
        /// Required. Gets or sets the tenant Id.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public GraphRbacManagementClient(string tenantID, SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (tenantID == null)
            {
                throw new ArgumentNullException("tenantID");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._tenantID = tenantID;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the GraphRbacManagementClient class.
        /// </summary>
        /// <param name='tenantID'>
        /// Required. Gets or sets the tenant Id.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public GraphRbacManagementClient(string tenantID, SubscriptionCloudCredentials credentials)
            : this()
        {
            if (tenantID == null)
            {
                throw new ArgumentNullException("tenantID");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._tenantID = tenantID;
            this._credentials = credentials;
            this._baseUri = new Uri("https://graph.windows.net/");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the GraphRbacManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public GraphRbacManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._application = new ApplicationOperations(this);
            this._group = new GroupOperations(this);
            this._objects = new ObjectOperations(this);
            this._servicePrincipal = new ServicePrincipalOperations(this);
            this._user = new UserOperations(this);
            this._apiVersion = "1.6-internal";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the GraphRbacManagementClient class.
        /// </summary>
        /// <param name='tenantID'>
        /// Required. Gets or sets the tenant Id.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public GraphRbacManagementClient(string tenantID, SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (tenantID == null)
            {
                throw new ArgumentNullException("tenantID");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._tenantID = tenantID;
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the GraphRbacManagementClient class.
        /// </summary>
        /// <param name='tenantID'>
        /// Required. Gets or sets the tenant Id.
        /// </param>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public GraphRbacManagementClient(string tenantID, SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (tenantID == null)
            {
                throw new ArgumentNullException("tenantID");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._tenantID = tenantID;
            this._credentials = credentials;
            this._baseUri = new Uri("https://graph.windows.net/");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// GraphRbacManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of GraphRbacManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<GraphRbacManagementClient> client)
        {
            base.Clone(client);
            
            if (client is GraphRbacManagementClient)
            {
                GraphRbacManagementClient clonedClient = ((GraphRbacManagementClient)client);
                
                clonedClient._tenantID = this._tenantID;
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
