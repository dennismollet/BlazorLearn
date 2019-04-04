using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Components;
using Blazor.Models;
using Blazor.Services;
using Newtonsoft.Json;

namespace Blazor.ViewModels
{
    public class GridViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<People> People { get; set; } = new ObservableCollection<People>();

        private IPeopleService PeopleService { get; }

        public GridViewModel(IPeopleService getValuesService)
        {
            PeopleService = getValuesService;
        }

        private SynergyGrid _GridDefinition { get; set; } = new SynergyGrid();
        public SynergyGrid GridDefinition
        {
            get => _GridDefinition;
            set
            {
                _GridDefinition = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GridDefinition)));
            }
        }


        protected List<SimpleGridHeaderColumn> GridHeaderColumns => new List<SimpleGridHeaderColumn>
            {
                new SimpleGridHeaderColumn("Id", new TableHeaderElement("1", new List<string>() {"table-danger"})),
                new SimpleGridHeaderColumn("Name", new TableHeaderElement("1", new List<string>()))
            };
        protected List<GridHeader> GridHeaders => new List<GridHeader> { new SimpleGridHeader(GridHeaderColumns) };
        protected List<GridRow> BuildGridRows(IEnumerable<People> people)
        {
            return people.Select(s => new SimpleGridRow(new List<string> { s.Id.ToString(), s.Name })).OfType<GridRow>().ToList();
        }
        protected List<GridFooter> GridFooters => new List<GridFooter> { new SimpleGridFooter(new List<string> { "Footer1", "Footer2"/*, "Footer3", "Footer4"*/}) };

        public async Task Load()
        {
            Console.WriteLine("Load Called");
            People.Clear();

            foreach (var value in await PeopleService.GetValues())
            {
                People.Add(value);
            }
            Console.WriteLine(People.Count);

            GridDefinition = new SynergyGrid(GridHeaders, BuildGridRows(People), GridFooters);
        }

        public async Task Post()
        {
            People val = new People() { Name = "Fooey", Id = 6 };
            People.Add(await PeopleService.Post(val));
            await Load(); //probably not load on a post...
        }

        public async Task Put()
        {
            People val = new People() { Name = "Fooey", Id = 6 };
            var status = await PeopleService.Put(6, val);
            await Load();
        }
    }
}