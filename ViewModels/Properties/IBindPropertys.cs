namespace Blazor.ViewModels
{
    public class IBindProperty : IProperty, IProperty<IBind>
    {
        private string _Name { get; }
        private IBind _Value { get; }
        public IBindProperty(string name, IBind value)
        {
            _Name = name;
            _Value = value;
        }

        public string GetPropertyName() => _Name;
        public IBind GetPropertyValue() => _Value;
        public string GetPropertyValueString() => string.Empty;
    }
}