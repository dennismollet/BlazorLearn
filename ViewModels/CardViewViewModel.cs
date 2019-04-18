using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.AspNetCore.Blazor;

namespace Blazor.ViewModels
{
    public class CardViewViewModel : IBindList, INotifyPropertyChanged, IHandleDrag<CardViewItemModel>
    {
        public CardViewViewModel(IDragEvents<CardViewItemModel> dragger)
        {
            Dragger = dragger;
            LocalData = CreateLocalData();
        }

        public List<IBind> GetData() => LocalData;

        public event PropertyChangedEventHandler PropertyChanged;


        //fakes a call to the web server
        private List<IBind> CreateLocalData() => new List<IBind>()
        {
            //new CardViewItem(),
            //new CardViewItem(),
        };

        private IDragEvents<CardViewItemModel> Dragger { get; }
        public IDragEvents<CardViewItemModel> GetDragEventHandler(string key) => Dragger;

        private List<IBind> LocalData { get; }
    }

    public class CardViewItemModel : BindableBase
    {
        public CardViewItemModel(Dictionary<string, IProperty> properties)
            : base(properties)
        {

        }

        public CardViewItemModel(IEnumerable<IProperty> properties)
            : base(properties)
        {

        }

        public string Text => "text";
    }


    public class CardViewItemDragger : IDragEvents<CardViewItemModel>
    {
        public void OnItemDrag(UIDragEventArgs e, CardViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"Currently dragging {dataTransfer.Text}");
        }

        public void OnItemDragEnd(UIDragEventArgs e, CardViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"Finished dragging {dataTransfer.Text}");
        }

        public void OnItemDragStart(UIDragEventArgs e, CardViewItemModel dataTransfer)
        {
            System.Console.WriteLine($"Started dragging {dataTransfer.Text}");
        }
    }
}