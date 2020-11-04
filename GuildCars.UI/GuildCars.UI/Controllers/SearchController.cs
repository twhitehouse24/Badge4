using GuildCars.Data;
using GuildCars.Data.Factories;
using GuildCars.UI.Models.Ajax;
using System;
using System.Web.Http;

namespace GuildCars.UI.Controllers
{
    public class SearchController : ApiController
    {
        [Route("search/cars/")] 
        [AcceptVerbs("GET")]
        public IHttpActionResult GetAllNew(string searchTerm, int minPrice, int maxPrice, int minYear, int maxYear, int Type)
        {
            var repo = RepoFactory.GetRepo();
            return Ok(repo.SearchAllCars(searchTerm, minPrice, maxPrice, minYear, maxYear, Type));
            //Sales/Index uses this
        }

        [Route("search/sales/")]
        [AcceptVerbs("GET")]
        public IHttpActionResult Sales(string searchUser, DateTime fromDate, DateTime toDate)
        {
            var repomain = RepoFactory.GetRepo();
            return Ok(repomain.GetSalesResults(searchUser, fromDate, toDate));
        }
        [Route("search/model/{id}")]
        [AcceptVerbs("GET")]
        public IHttpActionResult ModelFilter(string id)
        {
            var repo = ModelRepoFactory.GetRepo();
            return Ok(repo.GetFilteredModels(id));
        }
    }
}
