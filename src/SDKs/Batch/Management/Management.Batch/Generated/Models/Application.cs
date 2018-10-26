// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Batch.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about an application in a Batch account.
    /// </summary>
    public partial class Application
    {
        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        public Application()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Application class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the application
        /// within the account.</param>
        /// <param name="displayName">The display name for the
        /// application.</param>
        /// <param name="packages">The list of packages under this
        /// application.</param>
        /// <param name="allowUpdates">A value indicating whether packages
        /// within the application may be overwritten using the same version
        /// string.</param>
        /// <param name="defaultVersion">The package to use if a client
        /// requests the application but does not specify a version.</param>
        public Application(string id = default(string), string displayName = default(string), IList<ApplicationPackage> packages = default(IList<ApplicationPackage>), bool? allowUpdates = default(bool?), string defaultVersion = default(string))
        {
            Id = id;
            DisplayName = displayName;
            Packages = packages;
            AllowUpdates = allowUpdates;
            DefaultVersion = defaultVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the application
        /// within the account.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the application.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the list of packages under this application.
        /// </summary>
        [JsonProperty(PropertyName = "packages")]
        public IList<ApplicationPackage> Packages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether packages within the
        /// application may be overwritten using the same version string.
        /// </summary>
        [JsonProperty(PropertyName = "allowUpdates")]
        public bool? AllowUpdates { get; set; }

        /// <summary>
        /// Gets or sets the package to use if a client requests the
        /// application but does not specify a version.
        /// </summary>
        [JsonProperty(PropertyName = "defaultVersion")]
        public string DefaultVersion { get; set; }

    }
}