namespace SirenSharp
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the Siren sub-entity wrapper.
    /// </summary>
    public class SubEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubEntity"/> class with required properties.
        /// </summary>
        /// <param name="href">Hypermedia reference</param>
        /// <param name="rel">Unique relationship</param>
        public SubEntity(Uri href, params string[] rel)
        {
            this.Class = null;
            this.Rel = rel;
            this.Href = href;
            this.Properties = null;
            this.Links = null;
        }

        /// <summary>
        /// Gets or sets the representation. 
        /// </summary>
        /// <remarks>
        /// Describes the nature of an entity's content based on the current representation. 
        /// Possible values are implementation-dependent and should be documented. 
        /// MUST be an array of strings. Optional.
        /// </remarks>
        public IEnumerable<string> Class { get; set; }

        /// <summary>
        /// Gets or sets the unique relationship for getting entities associated with this sub-entity.
        /// A client would use these to find the appropriate sub-entity href to get.
        /// </summary>
        /// <remarks>
        /// Defines the relationship of the sub-entity to its parent, per Web Linking (RFC5899).
        /// MUST be an array of strings. Required.
        /// </remarks>
        public IEnumerable<string> Rel { get; set; }

        /// <summary>
        /// Gets or sets the hypermedia reference to the entities associated with this sub-entity.
        /// </summary>
        /// <remarks>
        /// The URI of the linked sub-entity. Required.
        /// </remarks>
        public Uri Href { get; set; }

        /// <summary>
        /// Gets or sets the list of properties.
        /// </summary>
        /// <remarks>
        /// A set of key-value pairs that describe the state of an entity. Optional.
        /// </remarks>
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets a list of links associated with the entity.
        /// </summary>
        /// <remarks>
        /// A collection of items that describe navigational links, distinct from entity relationships. 
        /// Link items should contain a rel attribute to describe the relationship and an href attribute 
        /// to point to the target URI. Entities should include a link rel to self. In JSON Siren, this is 
        /// represented as "links": [{ "rel": ["self"], "href": "http://api.x.io/orders/1234" }] Optional.
        /// </remarks>
        public IEnumerable<Link> Links { get; set; }
    }
}
