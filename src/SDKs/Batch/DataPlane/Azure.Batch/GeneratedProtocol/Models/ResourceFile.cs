// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A file to be downloaded from Azure blob storage to a compute node.
    /// </summary>
    public partial class ResourceFile
    {
        /// <summary>
        /// Initializes a new instance of the ResourceFile class.
        /// </summary>
        public ResourceFile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceFile class.
        /// </summary>
        /// <param name="blobSource">The URL of the file within Azure Blob
        /// Storage.</param>
        /// <param name="filePath">The location on the compute node to which to
        /// download the file, relative to the task's working
        /// directory.</param>
        /// <param name="fileMode">The file permission mode attribute in octal
        /// format.</param>
        public ResourceFile(string blobSource, string filePath, string fileMode = default(string))
        {
            BlobSource = blobSource;
            FilePath = filePath;
            FileMode = fileMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the file within Azure Blob Storage.
        /// </summary>
        /// <remarks>
        /// This URL must be readable using anonymous access; that is, the
        /// Batch service does not present any credentials when downloading the
        /// blob. There are two ways to get such a URL for a blob in Azure
        /// storage: include a Shared Access Signature (SAS) granting read
        /// permissions on the blob, or set the ACL for the blob or its
        /// container to allow public access.
        /// </remarks>
        [JsonProperty(PropertyName = "blobSource")]
        public string BlobSource { get; set; }

        /// <summary>
        /// Gets or sets the location on the compute node to which to download
        /// the file, relative to the task's working directory.
        /// </summary>
        [JsonProperty(PropertyName = "filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file permission mode attribute in octal format.
        /// </summary>
        /// <remarks>
        /// This property applies only to files being downloaded to Linux
        /// compute nodes. It will be ignored if it is specified for a
        /// resourceFile which will be downloaded to a Windows node. If this
        /// property is not specified for a Linux node, then a default value of
        /// 0770 is applied to the file.
        /// </remarks>
        [JsonProperty(PropertyName = "fileMode")]
        public string FileMode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (BlobSource == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BlobSource");
            }
            if (FilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilePath");
            }
        }
    }
}