using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Blazor.Models;
using Blazor.Services;
using Newtonsoft.Json;

namespace Blazor.ViewModels
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _counter = 0;

        public ObservableCollection<People> People { get; set; }
            = new ObservableCollection<People>();

        public int Counter
        {
            get => _counter;
            set
            {
                if (_counter == value)
                    return;

                _counter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
            }
        }

        private IPeopleService PeopleService { get; }

        public TestViewModel(IPeopleService getValuesService)
        {
            PeopleService = getValuesService;
        }

        public void Increment()
        {
            Counter++;
        }

        public async Task Load()
        {
            People.Clear();

            foreach (var value in await PeopleService.GetValues())
            {
                People.Add(value);
            }
        }

        public async Task Post()
        {
            People val = new People() { Name = "Fooey", Id = 6 };
            People.Add(await PeopleService.Post(val));
        }

        public async Task Put()
        {
            People val = new People() { Name = "Fooey", Id = 6 };
            var status = await PeopleService.Put(6, val);
            await Load();
        }
    }
}