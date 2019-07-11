// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using System.Linq;

    /// <summary>
    /// A Synchronization Setting data transfer object.
    /// </summary>
    public partial class SynchronizationSetting : ProxyDto
    {
        /// <summary>
        /// Initializes a new instance of the SynchronizationSetting class.
        /// </summary>
        public SynchronizationSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SynchronizationSetting class.
        /// </summary>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        public SynchronizationSetting(string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}