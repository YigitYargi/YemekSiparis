using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparis.Repositories
{
    public class RestaurantRepo : IRestaurant
    {

        public void AddRestaurant(REST rest)
        {
            using (YemekSiparisContext context = new YemekSiparisContext())
            {
                context.Rest.Remove(rest);
                context.SaveChanges();
            }
        }
        public void DeleteRestaurant(int id)
        {
            using (YemekSiparisContext context = new YemekSiparisContext())
            {
                context.Rest.Remove(rest);
                context.SaveChanges();
            }

        }
        public List<REST> GetAllRestaurantList()
        {
            throw new NotImplementedException();
        }


    }
}
