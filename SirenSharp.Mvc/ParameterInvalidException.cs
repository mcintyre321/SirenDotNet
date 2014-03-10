namespace SirenSharp.Mvc
{
    public class ParameterInvalidException : System.Exception
    {
        public ParameterInvalidException(string parameterName, FieldTypes expectedType)
            : base("Parameter \"" + parameterName + "\" is missing or is invalid. Expected type was: " + expectedType)
        {
            ParameterName = parameterName;
        }

        public string ParameterName { get; set; }
    }
}
