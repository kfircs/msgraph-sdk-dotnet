// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PrivilegedAccessRoot : Entity, IParsable {
        /// <summary>A group that&apos;s governed through Privileged Identity Management (PIM).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedAccessGroup? Group {
            get { return BackingStore?.Get<PrivilegedAccessGroup?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public PrivilegedAccessGroup Group {
            get { return BackingStore?.Get<PrivilegedAccessGroup>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"group", n => { Group = n.GetObjectValue<PrivilegedAccessGroup>(PrivilegedAccessGroup.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrivilegedAccessGroup>("group", Group);
        }
    }
}
