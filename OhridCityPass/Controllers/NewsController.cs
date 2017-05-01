using OhridCityPassClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OhridCityPass.Controllers
{
    public class NewsController : ApiController
    {
        public static CityPassDataService ds = new CityPassDataService();
        
        // GET api/news
        public IEnumerable<News> Get()
        {
         return  ds.getNews();
        }

        // GET api/news/5
        public News Get(int id)
        {
            return ds.getNews(id);
        }

        //GET api/news/getauthor
        public String getAuthor(String author)
        {
            return ds.getByAuthor(author);
        }

        public String getStory(int id)
        {
            return ds.getStory(id);
        }

        //Get The Latest News Here
        public String getLatest()
        {
            return ds.getLast();
        }
        
            
   
      // POST api/news
      public List<News> Post([FromBody]News news)
        {

            return ds.insertNews(news);
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
