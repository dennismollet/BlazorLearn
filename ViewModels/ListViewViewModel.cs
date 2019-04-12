using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Blazor;

namespace Blazor.ViewModels
{
    public class ListViewViewModel : IBindList, INotifyPropertyChanged, IDragDrop<ListViewItemModel>
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
                                                            new StringProperty("src", "/images/selector.jpg"),
                                                            new StringProperty("dragdropkey", "1")
                                                        };

        private List<IProperty> GetProperties2() => new List<IProperty>
                                                        {
                                                            new BooleanProperty("Selected", false),
                                                            new StringProperty("Name", "Dave"),
                                                            new StringProperty("src", "/images/selector.jpg"),
                                                            new StringProperty("dragdropkey", "2")
                                                        };

        private List<IProperty> GetProperties3() => new List<IProperty>
                                                        {
                                                            new BooleanProperty("Selected", false),
                                                            new StringProperty("Name", "Aaron"),
                                                            new StringProperty("src", "/images/selector.jpg"),
                                                            new StringProperty("dragdropkey", "3")
                                                        };

        public ListViewItemModel GetDataTransferItem(string transferItemKey)
        {
            return GetLocalData().FirstOrDefault(ld => ld.GetProperty("dragdropkey").GetPropertyValueString() == transferItemKey) as ListViewItemModel;
        }
    }

    public class ListViewItemModel : BindableBase, IDrag<ListViewItemModel>
    {
        public ListViewItemModel(Dictionary<string, IProperty> properties)
            : base(properties)
        {

        }

        public ListViewItemModel(IEnumerable<IProperty> properties)
            : base(properties)
        {

        }

        public bool Selected => ((BooleanProperty)_Properties["Selected"]).GetPropertyValue();
        public string Name => _Properties["Name"].GetPropertyValueString();
        public string src => _Properties["src"].GetPropertyValueString();
        public string dragdropkey => _Properties["dragdropkey"].GetPropertyValueString();

        public string GetDragKey() => dragdropkey;
        public void OnItemDrag(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            throw new System.NotImplementedException();
        }

        public void OnItemDragEnd(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            throw new System.NotImplementedException();
        }

        public void OnItemDragStart(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            throw new System.NotImplementedException();
        }
    }
}