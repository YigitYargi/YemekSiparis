using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparis.Interfaces
{
   public interface IFood
    {

        List<FOOD> GetAllFoodList();
        List<FOOD> GetFoodWithName(string name);
        FOOD GetFoodWithId(int id);
        List<FOOD> GetFoodWithRestaurant(string rest);

        void AddFood(FOOD food);
        void UpdateFood(FOOD food);

        void DeleteFood(int id);



    }
}
