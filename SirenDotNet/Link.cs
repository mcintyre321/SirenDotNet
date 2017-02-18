using Newtonsoft.Json;

namespace SirenDotNet
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Links represent navigational transitions.
    /// </summary>
    public class Link
    {
        public Link () {}
        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class with required properties.
        /// </summary>
        /// <param name="href">Hypermedia reference</param>
        /// <param name="rel">Unique relationship</param>
        public Link(Uri href, params string[] rel)
        {
            this.Rel = rel;
            this.Href = href;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Link"/> class with required properties.
        /// </summary>
        /// <param name="href">Hypermedia reference</param>
        /// <param name="rel">Unique relationship</param>
        public Link(string href, params string[] rel)
        {
            this.Rel = rel;
            this.Href = new Uri(href, UriKind.Relative);
        }

        /// <summary>
        /// Gets or sets the unique relationship for a client to find this link.
        /// </summary>
        /// <remarks>
        /// Defines the relationship of the link to its entity, per Web Linking (RFC5899). MUST be an array of strings. Required.
        /// </remarks>
        public IEnumerable<string> Rel { get; set; }

        public IEnumerable<string> Class { get; set; }

        /// <summary>
        /// Gets or sets the hypermedia reference for a client to get.
        /// </summary>
        /// <remarks>
        /// The URI of the linked resource. Required.
        /// </remarks>
        /// 
        public Uri Href { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        [JsonExtensionData]
        public IDictionary<string, object> ExtensionData { get; } = new Dictionary<string, object>();
    }
}
