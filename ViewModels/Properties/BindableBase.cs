using System.Collections.Generic;
using System.Linq;

namespace Blazor.ViewModels
{
    public abstract class BindableBase : IBind
    {
        protected Dictionary<string, IProperty> _Properties { get; }

        public BindableBase(Dictionary<string, IProperty> properties)
        {
            _Properties = properties;
        }

        public BindableBase(IEnumerable<IProperty> properties)
        {
            _Properties = properties.ToDictionary(p => p.GetPropertyName(), p => p);
        }

        public List<IProperty> GetProperties() => _Properties.Values.ToList();
        public IProperty GetProperty(string name)
        {
            _Properties.TryGetValue(name, out var property);
            return property;
        }
    }
}