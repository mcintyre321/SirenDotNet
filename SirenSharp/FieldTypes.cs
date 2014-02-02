namespace SirenSharp
{
    /// <summary>
    /// Represents field types for actions.
    /// </summary>
    public enum FieldTypes
    {
        Text,
        Hidden,
        Search,
        Tel,
        Url,
        Email,
        Password,
        Datetime,
        Date,
        Month,
        Week,
        Time,
        ////Datetime-local, // Will require custom JSON serializer
        Number,
        Range,
        Color,
        Checkbox,
        Radio,
        File,
        Submit,
        Image,
        Reset
    }
}