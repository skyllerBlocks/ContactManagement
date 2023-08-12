using ExternalServices.ExternalInterface.Restcountries.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalServices.ExternalInterface
{
    public interface IRestcountriesService
    {
        public interface IPersonApiService
        {
            [Get("/All")]
            Task<List<RestcointriesModel>> GetAll();

            [Get("/alpha/{code}")]
            Task<RestcointriesModel> GetByCode(int code);
        }
    }
}
