// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.IdentityGovernance.EntitlementManagement.AccessPackages.Item.GetApplicablePolicyRequirements {
    [Obsolete("This class is obsolete. Use getApplicablePolicyRequirementsPostResponse instead.")]
    public class GetApplicablePolicyRequirementsResponse : GetApplicablePolicyRequirementsPostResponse, IParsable {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GetApplicablePolicyRequirementsResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetApplicablePolicyRequirementsResponse();
        }
    }
}
