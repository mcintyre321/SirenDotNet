namespace SirenSharp
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Fields represent controls inside of actions.
    /// </summary>
    public class Field
    {
        public Field() { }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class with required properties.
        /// </summary>
        /// <param name="name">Name of the field</param>
        public Field(string name)
        {
            this.Name = name;
            this.Type = FieldTypes.Text;
            this.Value = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Field"/> class with required properties.
        /// </summary>
        /// <param name="name">Name of the field</param>
        /// <param name="@type">Type of the field</param>
        public Field(string name, FieldTypes @type)
        {
            this.Name = name;
            this.Type = @type;
            this.Value = null;
        }

        /// <summary>
        /// Gets or sets the name of the field
        /// </summary>
        /// <remarks>
        /// A name describing the control. Required
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the field type.
        /// </summary>
        /// <remarks>
        /// The field type. This may include any of the input types specified in HTML5.
        /// When missing, the default value is text. Serialization of these fields will 
        /// depend on the value of the action's type attribute. See type under Actions, 
        /// above. Optional.
        /// </remarks>
        [JsonConverter(typeof(FieldTypes.FieldTypesJsonConverter))]
        public FieldTypes Type { get; set; }

        /// <summary>
        /// Gets or sets the default value of the field.
        /// </summary>
        /// <remarks>
        /// A value assigned to the field. Optional.
        /// </remarks>
        public object Value { get; set; }
    }
}
