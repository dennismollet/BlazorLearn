using System.Collections.Generic;

namespace Blazor.ViewModels
{
    public interface IBindList
    {
        List<IBind> GetData();
    }

    public interface IBind
    {
        List<IProperty> GetProperties();
        IProperty GetProperty(string name);
    }

    public interface IProperty
    {
        string GetPropertyName();
        string GetPropertyValueString();
    }

    public interface IProperty<T>
    {
        T GetPropertyValue();
    }
}