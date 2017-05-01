using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhridCityPassClassLibrary
{
    public class CityPassDataService
    {
        protected OhridCityPassEntities db = new OhridCityPassEntities();



        //packageDataService
        public String getPackageDesc(int id)
        {

            Package pack = db.Packages.Where(x => x.Id == id).First();
            return pack.Description;
        }

        //administratorDataService
        public String getAccNumber(int id)
        {
            var admin = (from ad in db.Administrators
                         where ad.ID == id
                         select ad.AccountNumber).Single();
            return admin;
        }









        //customerDataService
        public List<Customer> getCustomers() {
            
            List<Customer> customers = db.Customers.ToList();
            return customers;
        }
        public Customer getCustomer(int id)
        {
            Customer selected = db.Customers.Where(x => x.ID == id).FirstOrDefault();
            return selected;
        }

        //ordersDataService
        public List<Order> getOrdersByDate(DateTime date)
        {
            List<Order> tempOrder = db.Orders.Where(x => x.Date > date).ToList();
            return tempOrder;
        }
        

        //attractionsDataService
        public List<Attraction> getAttractions()
        {      
            List<Attraction> attractions = db.Attractions.ToList();
            return attractions;
        }

        public Attraction getAttractions(int id)
        {
            Attraction attr = db.Attractions.Where(c => c.Id == id).SingleOrDefault();
            if (attr == null) throw new KeyNotFoundException("item doesn't exist database");
            return attr;

        }

        public List<String> getNames()
        {
            List<String> lista = new List<string>();

            List<Attraction> attr = db.Attractions.ToList();
            foreach (var attraction in attr)
            {
                lista.Add(attraction.Name);
            }

            return lista;
        }

        public List<String> getInfo(int id)
        {
            List<String> lista = new List<String>();
            Attraction attr = db.Attractions.Where(c => c.Id == id).FirstOrDefault();
            lista.Add(attr.Name);
            lista.Add(attr.Description);
            lista.Add(attr.Location);
            lista.Add(attr.Price.ToString());
            return lista;

        }
        //najdi opis na atrakcija so id 
        public String getDescription(int id)
        {
            var opis = (from att in db.Attractions
                        where att.Id == id
                        select att.Description.ToString()).Single();
            return opis;
        }

        public List<String> getByPackage(int packId)
        {
           
            Package pck = db.Packages.Where(c => c.Id == packId).SingleOrDefault();

            List<String> listattr = new List<String>();
            foreach (var attr in pck.Attractions)
            {
                listattr.Add(attr.Name);
            }


            return listattr ;
        }

        public List<String> getExpensive()
        {
            decimal maxPrice = db.Attractions.Max(p => p.Price).Value;
            List<String> newList = new List<String>();
            Attraction result = db.Attractions.Where(c => c.Price == maxPrice).First();
            newList.Add(result.Name);
            newList.Add(result.Price.ToString());
            newList.Add(result.Location);
            return newList; 
        }
        //get availabilities from a tour
     
       //getInfoFortheTourGuide
       public List<String> getTourGuide(int id)
        {
            List<String> novalista = new List<string>();

            Tour tour = db.Tours.Where(c => c.TourId == id).First();

            User user = db.Users.Where(c => c.Id == tour.TourOperator.Id).First();
            novalista.Add(user.FirstName);
            novalista.Add(user.LastName);
            novalista.Add(user.Contact);
            return novalista;
        }






        //newsDataService

      public String getStory(int id)
        {
            News story = null;
            using (var context = new OhridCityPassEntities())
            {
                story =  (context.News.Where(s => s.Id == id).FirstOrDefault());
            }
            if (story == null) return new DllNotFoundException().ToString();
            return story.News1;
        }

    
        //get the author
        public String getByAuthor(String author)
        {

            var avtorime = from author1 in db.Users
                           where author1.FirstName == author
                           select author1;

            var authorName = from author2 in avtorime
                             join author3 in db.News on author2.Id equals author3.Id
                             select new
                             {
                                 author3.News1
                             };

            String vrati = authorName.ToString();

            return vrati;
        }

       public String getLast()
        {
            String result = db.News.OrderByDescending(c => c.Id).Select(c => new { c.Author,c.News1}).First().ToString();
            return result;
        }





        //get all news to list
        public List<News> getNews()
        {
            return db.News.ToList();
        }
        //get a single news
        public News getNews(int id)
        {
            return db.News.Where(n => n.Id == id).FirstOrDefault();
        }
        //get news on date
        public List<News> getByDate(DateTime date)
        {
            List<News> news = db.News.Where(n => n.Date == date).ToList();
            return news;
        }


        public List<News> insertNews(News tempNews)
        {
         List<News> tempList=   db.News.ToList();
            tempList.Add(tempNews);
            db.News.Add(tempNews);
            db.SaveChanges();
            return db.News.ToList();
        }
    }
}
