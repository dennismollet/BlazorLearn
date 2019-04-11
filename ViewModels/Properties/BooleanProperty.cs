namespace Blazor.ViewModels
{
    public class BooleanProperty : IProperty, IProperty<bool>
    {
        private string _Name { get; }
        private bool _Value { get; }
        public BooleanProperty(string name, bool value)
        {
            _Name = name;
            _Value = value;
        }

        public string GetPropertyName() => _Name;
        public bool GetPropertyValue() => _Value;
        public string GetPropertyValueString() => _Value ? "Y" : "N";
    }
}