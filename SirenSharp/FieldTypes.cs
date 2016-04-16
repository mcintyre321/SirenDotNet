using System;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SirenSharp
{
    /// <summary>
    /// Represents field types for actions.
    /// </summary>
    public class FieldTypes
    {
        public static FieldTypes Text = new FieldTypes("Text");
        public static FieldTypes Hidden = new FieldTypes("Hidden");
        public static FieldTypes Search = new FieldTypes("Search");
        public static FieldTypes Tel = new FieldTypes("Tel");
        public static FieldTypes Url = new FieldTypes("Url");
        public static FieldTypes Email = new FieldTypes("Email");
        public static FieldTypes Password = new FieldTypes("Password");
        public static FieldTypes Datetime = new FieldTypes("Datetime");
        public static FieldTypes Date = new FieldTypes("Date");
        public static FieldTypes Month = new FieldTypes("Month");
        public static FieldTypes Week = new FieldTypes("Week");
        public static FieldTypes Time = new FieldTypes("Time");
        //public static FieldTypes ////Datetinew FieldTypes("s ////Dae-");ocal // Will require custom JSON serializer
        public static FieldTypes Number = new FieldTypes("Number");
        public static FieldTypes Range = new FieldTypes("Range");
        public static FieldTypes Color = new FieldTypes("Color");
        public static FieldTypes Checkbox = new FieldTypes("Checkbox");
        public static FieldTypes Radio = new FieldTypes("Radio");
        public static FieldTypes File = new FieldTypes("File");
        public static FieldTypes Submit = new FieldTypes("Submit");
        public static FieldTypes Image = new FieldTypes("Image");
        public static FieldTypes Reset = new FieldTypes("Reset");
        private string v;

        public FieldTypes(string v)
        {
            this.v = v.ToLower();
        }

        public override string ToString()
        {
            return this.v;
        }

        public class FieldTypesJsonConverter : JsonConverter 
        {
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                if (value == null)
                {
                    writer.WriteNull();
                }
                else
                {
                    JToken.FromObject(value.ToString()).WriteTo(writer);
                }
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                return new FieldTypes(JToken.Load(reader).ToString());
            }

            public override bool CanConvert(Type objectType)
            {
                return (typeof(FieldTypes).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo()));
            }
        }

        protected bool Equals(FieldTypes other)
        {
            return string.Equals(v, other.v, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var other = obj as FieldTypes;
            return other != null && Equals(other);
        }

        public override int GetHashCode()
        {
            return (v != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(v) : 0);
        }

        public static bool operator ==(FieldTypes left, FieldTypes right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FieldTypes left, FieldTypes right)
        {
            return !Equals(left, right);
        }
    }
}