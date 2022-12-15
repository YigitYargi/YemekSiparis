using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparis.Repositories
{
    public class FoodRepo : IFood
    {

        public void AddFood(FOOD food)
        {
            using (YemekSiparisContext context = new YemekSiparisContext())
            {
                context.Food.Add(food);
                context.SaveChanges();
            }
        }
        public void DeleteFood(int id)
        {
            using (YemekSiparisContext context = new YemekSiparisContext())
            {
                context.Food.Remove(food);
                context.SaveChanges();
            }

        }
        public List<FOOD> GetAllFoodList()
        {
            throw new NotImplementedException();
        }


    }
}
