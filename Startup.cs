using Blazor.Services;
using Blazor.Services.Implementations;
using Blazor.ViewModels;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Blazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPeopleService, PeopleService>();
            services.AddSingleton<TestViewModel>();
            services.AddSingleton<GridViewModel>();
            services.AddSingleton<ListViewViewModel>();
            services.AddSingleton<CardViewViewModel>();
            services.AddSingleton<IDragEvents<ListViewItemModel>, ListViewItemDragEventHandler>();
            services.AddSingleton<IDropEvents<ListViewItemModel>, ListViewItemDropper>();
            services.AddSingleton<IDragOverEvents<ListViewItemModel>, ListViewItemDragOverer>();
            services.AddSingleton<IDragEvents<CardViewItemModel>, CardViewItemDragger>();
        }

        public void Configure(IBlazorApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
