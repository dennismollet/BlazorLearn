using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Blazor;

namespace Blazor.ViewModels
{
    public class ListViewViewModel : IBindList, INotifyPropertyChanged, IHandleDrag<ListViewItemModel>, IHandleDrop<ListViewItemModel>, IHandleDragOver<ListViewItemModel>
    {
        public ListViewViewModel(IDragEvents<ListViewItemModel> listViewDragEventHandler, IDropEvents<ListViewItemModel> listViewDropEventHandler, IDragOverEvents<ListViewItemModel> listViewDragOverEventHandler)
        {
            ListViewDragEventHandler = listViewDragEventHandler;
            ListViewDropEventHandler = listViewDropEventHandler;
            ListViewDragOverEventHandler = listViewDragOverEventHandler;
        }

        private IDragEvents<ListViewItemModel> ListViewDragEventHandler { get; }
        private IDropEvents<ListViewItemModel> ListViewDropEventHandler { get; }
        private IDragOverEvents<ListViewItemModel> ListViewDragOverEventHandler { get; }
        public IDragEvents<ListViewItemModel> GetDragEventHandler(string key) => ListViewDragEventHandler;
        public IDropEvents<ListViewItemModel> GetDropEventHandler(string key) => ListViewDropEventHandler;
        public IDragOverEvents<ListViewItemModel> GetDragOverEventHandler(string key) => ListViewDragOverEventHandler;
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

    public class ListViewItemModel : BindableBase
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
    }

    public class ListViewItemDragEventHandler : IDragEvents<ListViewItemModel>
    {
        public void OnItemDrag(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"Currently dragging {dataTransfer.Name}");
        }

        public void OnItemDragEnd(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"Finished dragging {dataTransfer.Name}");
        }

        public void OnItemDragStart(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"Started dragging {dataTransfer.Name}");
        }
    }

    public class ListViewItemDropEventHandler : IDropEvents<ListViewItemModel>
    {
        public void OnContainerDrop(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"Dropped item {dataTransfer.Name}");

            //System.Console.WriteLine($"alt pressed: {e.AltKey}");
            //System.Console.WriteLine($"mouse button pressed: {e.Button}"); //left, middle, right
            //System.Console.WriteLine($"client coords: {e.ClientX}, {e.ClientY}");
            //System.Console.WriteLine($"datatransfer count: {e?.DataTransfer?.Items?.Length ?? 0}");
            //System.Console.WriteLine($"screen coords: {e.ScreenX}, {e.ScreenY}");            
        }
    }

    public class ListViewItemDragOverEventHandler : IDragOverEvents<ListViewItemModel>
    {
        public void OnContainerDragEnter(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"DragEnter fired for {dataTransfer.Name}");
        }

        public void OnContainerDragLeave(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"DragLeave fired for {dataTransfer.Name}");
        }

        public void OnDragOver(UIDragEventArgs e, ListViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"DragOver fired for {dataTransfer.Name}");
        }
    }
}