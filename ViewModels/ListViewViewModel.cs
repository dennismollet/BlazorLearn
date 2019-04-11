using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Blazor.ViewModels
{
    public class ListViewViewModel : IBindList, INotifyPropertyChanged
    {
        public ListViewViewModel()
        {
        }

        public List<IBind> GetData() => GetLocalData();

        public event PropertyChangedEventHandler PropertyChanged;

        private List<IBind> GetLocalData() => new List<IBind>  {
                                                        new ListViewItemModel(GetProperties1()),
                                                        new ListViewItemModel(GetProperties2()),
                                                        new ListViewItemModel(GetProperties3())
                                                    };

        private List<IProperty> GetProperties1() => new List<IProperty> 
                                                        { 
                                                            new BooleanProperty("Selected", false), 
                                                            new StringProperty("Name", "Dennis"), 
                                                            new StringProperty("src", "/images/selector.jpg")
                                                        };
                                                        
        private List<IProperty> GetProperties2() => new List<IProperty> 
                                                        { 
                                                            new BooleanProperty("Selected", false), 
                                                            new StringProperty("Name", "Dave"), 
                                                            new StringProperty("src", "/images/selector.jpg")
                                                        };
                                                        
        private List<IProperty> GetProperties3() => new List<IProperty> 
                                                        { 
                                                            new BooleanProperty("Selected", false), 
                                                            new StringProperty("Name", "Aaron"), 
                                                            new StringProperty("src", "/images/selector.jpg")
                                                        };
    }

    internal class ListViewItemModel : IBind
    {
        List<IProperty> _Properties {get;}        
        public ListViewItemModel(List<IProperty> properties)
        {
            _Properties = properties;
        }

        public List<IProperty> GetProperties() => _Properties;
        public IProperty GetProperty(string name) => _Properties.FirstOrDefault(p => p.GetPropertyName() == name);
    }
}