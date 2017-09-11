// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// The endpoint configuration for a pool.
    /// </summary>
    public partial class PoolEndpointConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the PoolEndpointConfiguration class.
        /// </summary>
        public PoolEndpointConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the PoolEndpointConfiguration class.
        /// </summary>
        /// <param name="inboundNATPools">A list of inbound NAT pools that can
        /// be used to address specific ports on an individual compute node
        /// externally.</param>
        public PoolEndpointConfiguration(System.Collections.Generic.IList<InboundNATPool> inboundNATPools)
        {
            this.InboundNATPools = inboundNATPools;
        }

        /// <summary>
        /// Gets or sets a list of inbound NAT pools that can be used to
        /// address specific ports on an individual compute node externally.
        /// </summary>
        /// <remarks>
        /// The maximum number of inbound NAT pools per Batch pool is 5. If the
        /// maximum number of inbound NAT pools is exceeded the request fails
        /// with HTTP status code 400.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "inboundNATPools")]
        public System.Collections.Generic.IList<InboundNATPool> InboundNATPools { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.InboundNATPools == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "InboundNATPools");
            }
            if (this.InboundNATPools != null)
            {
                foreach (var element in this.InboundNATPools)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}