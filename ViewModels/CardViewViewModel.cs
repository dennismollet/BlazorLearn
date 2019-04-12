using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Blazor.ViewModels
{
    public class CardViewViewModel : IBindList, INotifyPropertyChanged
    {
        public CardViewViewModel()
        {
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

        private List<IBind> LocalData { get; }
    }

    internal class CardViewItem : BindableBase
    {
        public CardViewItem(Dictionary<string, IProperty> properties)
            : base(properties)
        {

        }

        public CardViewItem(IEnumerable<IProperty> properties)
            : base(properties)
        {

        }
    }
}