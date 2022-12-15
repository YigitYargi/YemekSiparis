using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparis.Interfaces
{
    public interface IRestaurant
    {

        List<REST> GetAllRestaurantList();
        List<REST> GetRestaurantWithName(string name);
        REST GetRestaurantWithId(int id);
        

        void AddRestaurant(REST rest);
        void UpdateRestaurant(REST rest);

        void Restaurant(int id);

    }
}
