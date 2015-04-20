namespace Core.Extensions
{
    /// <summary>
    /// Used in constructor of custom exceptions to simplify adding a value.
    /// </summary>
    public class CustomExceptionValue
    {
        public CustomExceptionValue(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}
