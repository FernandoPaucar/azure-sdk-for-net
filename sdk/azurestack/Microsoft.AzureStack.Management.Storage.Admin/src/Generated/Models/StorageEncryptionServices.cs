// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Services for which encryption setting is mentioned.
    /// </summary>
    public partial class StorageEncryptionServices
    {
        /// <summary>
        /// Initializes a new instance of the StorageEncryptionServices class.
        /// </summary>
        public StorageEncryptionServices()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageEncryptionServices class.
        /// </summary>
        /// <param name="blob">Blob service.</param>
        /// <param name="table">Table service.</param>
        /// <param name="queue">Queue service</param>
        public StorageEncryptionServices(StorageEncryptionSetting blob = default(StorageEncryptionSetting), StorageEncryptionSetting table = default(StorageEncryptionSetting), StorageEncryptionSetting queue = default(StorageEncryptionSetting))
        {
            Blob = blob;
            Table = table;
            Queue = queue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets blob service.
        /// </summary>
        [JsonProperty(PropertyName = "blob")]
        public StorageEncryptionSetting Blob { get; private set; }

        /// <summary>
        /// Gets table service.
        /// </summary>
        [JsonProperty(PropertyName = "table")]
        public StorageEncryptionSetting Table { get; private set; }

        /// <summary>
        /// Gets queue service
        /// </summary>
        [JsonProperty(PropertyName = "queue")]
        public StorageEncryptionSetting Queue { get; private set; }

    }
}