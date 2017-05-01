using OhridCityPassClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OhridCityPass.Controllers
{
    public class CustomersController : ApiController
    {
        public static CityPassDataService citypassDatabaseService = new CityPassDataService();
    
        // GET api/customers

        [EnableCors(origins: "http://testdomain.com", headers: "*", methods: "*")]
        public IEnumerable<Customer> Get()
        {
             //return CityPassRepository.OhridCityPassRepository.Customers.ToList();
            return citypassDatabaseService.getCustomers();
        }

        // GET api/customers/5
        [EnableCors(origins: "http://testdomain.com", headers: "*", methods: "*")]
        [HttpGet ]
        public Customer Get(int id)
        {
            Customer tempcustomer = citypassDatabaseService.getCustomer(id);
            return tempcustomer;
           // return CityPassRepository.OhridCityPassRepository.Customers.Where(n => n.ID == id).FirstOrDefault();
        }

        public String getnumber(int i)
        {
            return citypassDatabaseService.getAccNumber(i);
        }


        //Get api/Customers/getordersbydate/11-10-2000
        public List<Order> Get(DateTime date)
        {
            return citypassDatabaseService.getOrdersByDate(date);
        }

    
        // POST api/news
        public void Post([FromBody]News news)
        {
            //OhridCityPassEntities entities = CityPassRepository.OhridCityPassRepository;
            //if (entities.News.Where(n => n.Id == news.Id).FirstOrDefault() == null)
            //{   
            //    entities.News.Add(news);
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
