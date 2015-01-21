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
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    /// <summary>
    /// The properties of Blob data source as output.
    /// </summary>
    public partial class BlobOutputDataSourceProperties
    {
        private string _blobPathPrefix;
        
        /// <summary>
        /// Optional. Gets or sets the prefix for the desired blob output path,
        /// Includes terminating ‘/’.
        /// </summary>
        public string BlobPathPrefix
        {
            get { return this._blobPathPrefix; }
            set { this._blobPathPrefix = value; }
        }
        
        private string _container;
        
        /// <summary>
        /// Required. Gets or sets the container of the blob.
        /// </summary>
        public string Container
        {
            get { return this._container; }
            set { this._container = value; }
        }
        
        private IList<StorageAccount> _storageAccounts;
        
        /// <summary>
        /// Optional. Gets or sets a list of one or more storage accounts.
        /// </summary>
        public IList<StorageAccount> StorageAccounts
        {
            get { return this._storageAccounts; }
            set { this._storageAccounts = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BlobOutputDataSourceProperties
        /// class.
        /// </summary>
        public BlobOutputDataSourceProperties()
        {
            this.StorageAccounts = new LazyList<StorageAccount>();
        }
        
        /// <summary>
        /// Initializes a new instance of the BlobOutputDataSourceProperties
        /// class with required arguments.
        /// </summary>
        public BlobOutputDataSourceProperties(string container)
            : this()
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.Container = container;
        }
    }
}