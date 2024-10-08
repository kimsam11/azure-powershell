// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the compute profile.
    /// </summary>
    public partial class ComputeProfile
    {
        /// <summary>
        /// Initializes a new instance of the ComputeProfile class.
        /// </summary>
        public ComputeProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ComputeProfile class.
        /// </summary>

        /// <param name="roles">The list of roles in the cluster.
        /// </param>
        public ComputeProfile(System.Collections.Generic.IList<Role> roles = default(System.Collections.Generic.IList<Role>))

        {
            this.Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the list of roles in the cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "roles")]
        public System.Collections.Generic.IList<Role> Roles {get; set; }
    }
}