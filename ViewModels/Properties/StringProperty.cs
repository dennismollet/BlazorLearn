namespace Blazor.ViewModels
{
    public class StringProperty : IProperty, IProperty<string>
    {
        private string _Name { get; }
        private string _Value { get; }
        public StringProperty(string name, string value)
        {
            _Name = name;
            _Value = value;
        }

        public string GetPropertyName() => _Name;
        public string GetPropertyValue() => _Value;
        public string GetPropertyValueString() => _Value;
    }
}