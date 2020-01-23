// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Attestation.Models
{

    /// <summary>
    /// Defines values for TeeKind.
    /// </summary>
    public static class TeeKind
    {
        /// <summary>
        /// Intel Software Guard eXtensions
        /// </summary>
        public const string SgxEnclave = "SgxEnclave";
        /// <summary>
        /// OpenEnclave extensions to SGX
        /// </summary>
        public const string OpenEnclave = "OpenEnclave";
        /// <summary>
        /// IoT Edge validation
        /// </summary>
        public const string CyResComponent = "CyResComponent";
        /// <summary>
        /// Azure Guest Attestation
        /// </summary>
        public const string AzureGuest = "AzureGuest";
    }
}
