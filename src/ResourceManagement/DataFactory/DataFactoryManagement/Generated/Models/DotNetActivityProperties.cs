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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// .NET activity properties.
    /// </summary>
    public partial class DotNetActivityProperties
    {
        private string _assemblyName;
        
        /// <summary>
        /// Required. Assembly name.
        /// </summary>
        public string AssemblyName
        {
            get { return this._assemblyName; }
            set { this._assemblyName = value; }
        }
        
        private string _entryPoint;
        
        /// <summary>
        /// Required. Entry point.
        /// </summary>
        public string EntryPoint
        {
            get { return this._entryPoint; }
            set { this._entryPoint = value; }
        }
        
        private IDictionary<string, string> _extendedProperties;
        
        /// <summary>
        /// Optional. User defined property bag. There is no restriction on the
        /// keys or values that can be used. The user specified .NET activity
        /// has the full responsibility to consume and interpret the content
        /// defined.
        /// </summary>
        public IDictionary<string, string> ExtendedProperties
        {
            get { return this._extendedProperties; }
            set { this._extendedProperties = value; }
        }
        
        private string _packageFile;
        
        /// <summary>
        /// Required. PackageFile.
        /// </summary>
        public string PackageFile
        {
            get { return this._packageFile; }
            set { this._packageFile = value; }
        }
        
        private string _packageLinkedService;
        
        /// <summary>
        /// Optional. Package linkedService.
        /// </summary>
        public string PackageLinkedService
        {
            get { return this._packageLinkedService; }
            set { this._packageLinkedService = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DotNetActivityProperties class.
        /// </summary>
        public DotNetActivityProperties()
        {
            this.ExtendedProperties = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the DotNetActivityProperties class
        /// with required arguments.
        /// </summary>
        public DotNetActivityProperties(string assemblyName, string entryPoint, string packageFile)
            : this()
        {
            if (assemblyName == null)
            {
                throw new ArgumentNullException("assemblyName");
            }
            if (entryPoint == null)
            {
                throw new ArgumentNullException("entryPoint");
            }
            if (packageFile == null)
            {
                throw new ArgumentNullException("packageFile");
            }
            this.AssemblyName = assemblyName;
            this.EntryPoint = entryPoint;
            this.PackageFile = packageFile;
        }
    }
}