// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System.Linq;

    /// <summary>
    /// The List Usages operation response.
    /// </summary>
    public partial class ListUsagesResultInner
    {
        /// <summary>
        /// Initializes a new instance of the ListUsagesResultInner class.
        /// </summary>
        public ListUsagesResultInner() { }

        /// <summary>
        /// Initializes a new instance of the ListUsagesResultInner class.
        /// </summary>
        /// <param name="value">the list Compute Resource Usages.</param>
        /// <param name="nextLink">the uri to fetch the next page of Compute
        /// Resource Usages. Call ListNext() with this to fetch the next page
        /// of Compute Resource Usages.</param>
        public ListUsagesResultInner(System.Collections.Generic.IList<Usage> value = default(System.Collections.Generic.IList<Usage>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets the list Compute Resource Usages.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<Usage> Value { get; set; }

        /// <summary>
        /// Gets or sets the uri to fetch the next page of Compute Resource
        /// Usages. Call ListNext() with this to fetch the next page of
        /// Compute Resource Usages.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}