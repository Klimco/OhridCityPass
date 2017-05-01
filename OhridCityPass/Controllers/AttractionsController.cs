using OhridCityPassClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OhridCityPass.Controllers
{
    public class AttractionsController : ApiController
    {


        public static CityPassDataService  db = new CityPassDataService();

        public List<String> getTour(int TourId)
        {
            return db.getTourGuide(TourId);
        }

        public IEnumerable<Attraction> Get()
        {
            return db.getAttractions();
        }

        public Attraction Get(int id)
        {
            return db.getAttractions(id);
        }
       
        public List<String> getNames()
        {
            return db.getNames();
        }

        public List<String> getInfo(int id)
        {
            return db.getInfo(id);
        }

        public void Post([FromBody]News news)
        {
            
        }

        public List<String> getMostExpensive()
        {
            return db.getExpensive();
        }

        // PUT api/news/5
        public void Put(int id, [FromBody]News value)
        {

        }

        // DELETE api/news/5
        public void Delete(int id)
        {
        }

        [System.Web.Http.HttpGet]
        public String zemiopis(int id)
        {
            return db.getDescription(id);
        }


        //This is for Tour Operators

       
            }
}
