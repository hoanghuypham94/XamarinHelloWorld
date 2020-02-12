using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OurFirstPrismSample.Model;
using Refit;

namespace OurFirstPrismSample
{
    public interface IMakeUpApi
    {
        [Get("/api/v1/products.json?brand=mybelline")]
        Task<List<MakeUp>> GetMakeUps();
        Task GetUser();
    }
}
