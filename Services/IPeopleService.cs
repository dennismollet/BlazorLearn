using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Blazor.Models;

namespace Blazor.Services
{
    public interface IPeopleService
    {
        Task<HttpStatusCode> Put(int id, People val);
        Task<People> Post(People value);
        Task<List<People>> GetValues();
        Task<People> GetValue(int id);
        //List<People> GetValuesSynchronous();
    }
}