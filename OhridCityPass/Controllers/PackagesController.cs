using OhridCityPassClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OhridCityPass.Controllers
{
    public class PackagesController : ApiController
    {
       public static CityPassDataService ds1 = new CityPassDataService();
        //get api/packages/najdipack
        public String getDesc(int id)
        {
            return ds1.getPackageDesc(id);
        }
        // GET api/packages
        public IEnumerable<Package> Get()
        {
            return CityPassRepository.OhridCityPassRepository.Packages.ToList();
        }



        // GET api/packages/5
        public Package Get(int id)
        {
            return CityPassRepository.OhridCityPassRepository.Packages.Where(n => n.Id == id).FirstOrDefault();
        }

        
       /* public int getNumPackages(int packID)
        {
            return ds1.getNumPack(packID);
        }*/
        public List<String> getByPack(int id)
        {
            return ds1.getByPackage(id);
        }

        // POST api/packages
        public void Post([FromBody] Package package)
        {
            //OhridCityPassEntities entities = CityPassRepository.OhridCityPassRepository;
            //if (entities.News.Where(n => n.Id == package.Id).FirstOrDefault() == null)
            //{
            //    entities.Packages.Add(package);
            //}
            //else
            //{
            //    // update
            //}
        }

        // PUT api/news/5
        public void Put(int id, [FromBody]News value)
        {

        }

        // DELETE api/news/5
        public void Delete(int id)
        {
        }

    }
}
