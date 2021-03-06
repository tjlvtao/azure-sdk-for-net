// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// SharedAccessAuthorizationRule properties.
    /// </summary>
    public partial class SharedAccessAuthorizationRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        public SharedAccessAuthorizationRuleProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// SharedAccessAuthorizationRuleProperties class.
        /// </summary>
        /// <param name="rights">The rights associated with the rule.</param>
        public SharedAccessAuthorizationRuleProperties(System.Collections.Generic.IList<AccessRights?> rights = default(System.Collections.Generic.IList<AccessRights?>))
        {
            Rights = rights;
        }

        /// <summary>
        /// Gets or sets the rights associated with the rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "rights")]
        public System.Collections.Generic.IList<AccessRights?> Rights { get; set; }

    }
}
