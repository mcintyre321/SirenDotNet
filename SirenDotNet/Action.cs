using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SirenDotNet
{
    using System;
    using System.Collections.Generic;
   
    /// <summary>
    /// Actions show available behaviors an entity exposes.
    /// </summary>
    public class Action
    {
        public Action(){}
        /// <summary>
        /// Initializes a new instance of the <see cref="Action"/> class with required properties.
        /// </summary>
        /// <param name="name">Name of the action</param>
        /// <param name="href">Hypermedia reference</param>
        public Action(string name, Uri href)
        {
            this.Name = name;
            this.Class = null;
            this.Method = HttpVerbs.GET;
            this.Href = href;
            this.Title = null;
            this.Type = null;
            this.Fields = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Action"/> class with required properties.
        /// </summary>
        /// <param name="name">Name of the action</param>
        /// <param name="href">Hypermedia reference</param>
        public Action(string name, string href)
        {
            this.Name = name;
            this.Class = null;
            this.Method = HttpVerbs.GET;
            this.Href = new Uri(href, UriKind.Relative);
            this.Title = null;
            this.Type = "application/x-www-form-urlencoded";
            this.Fields = null;
        }

        /// <summary>
        /// Gets or sets the name of the action.
        /// </summary>
        /// <remarks>
        /// A string that identifies the action to be performed. Required.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a list of classes
        /// </summary>
        /// <remarks>
        /// Describes the nature of an action based on the current representation. 
        /// Possible values are implementation-dependent and should be documented. 
        /// MUST be an array of strings. Optional.
        /// </remarks>
        public IEnumerable<string> Class { get; set; }

        /// <summary>
        /// Gets or sets the method type
        /// </summary>
        /// <remarks>
        /// An enumerated attribute mapping to a protocol method. For HTTP, these values may be 
        /// GET, PUT, POST, DELETE, or PATCH. As new methods are introduced, this list can be 
        /// extended. If this attribute is omitted, GET should be assumed. Optional.
        /// </remarks>
        [JsonConverter(typeof(StringEnumConverter))]
        public HttpVerbs? Method { get; set; }

        /// <summary>
        /// Gets or sets the hypermedia reference to the action
        /// </summary>
        /// <remarks>
        /// The URI of the action. Required.
        /// </remarks>
        public Uri Href { get; set; }

        /// <summary>
        /// Gets or sets a descriptive text about the action. Optional.
        /// </summary>
        /// <remarks>
        /// Descriptive text about the action. Optional.
        /// </remarks>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the encoding type expected by the action.
        /// </summary>
        /// <remarks>
        /// The encoding type for the request. When omitted and the fields attribute exists, 
        /// the default value is application/x-www-form-urlencoded. Optional.
        /// </remarks>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the fields associated with this action.
        /// </summary>
        /// <remarks>
        /// A collection of fields, expressed as an array of objects in JSON Siren 
        /// such as { "fields" : [{ ... }] }. See Fields. Optional.
        /// </remarks>
        public IEnumerable<Field> Fields { get; set; }
    }
}
