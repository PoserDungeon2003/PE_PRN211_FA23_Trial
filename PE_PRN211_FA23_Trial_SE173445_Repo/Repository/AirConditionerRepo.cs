using Microsoft.EntityFrameworkCore;
using PE_PRN211_FA23_Trial_SE173445_Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_PRN211_FA23_Trial_SE173445_Repo.Repository
{
    public class AirConditionerRepo
    {
        private AirConditionerShop2023DBContext context = new();
        public List<AirConditioner> searchByQuantityOrFeature(string searchKeyword)
        {
            List<AirConditioner> list = context.AirConditioners.Include(x => x.Supplier).Where(x => x.FeatureFunction.ToLower().Contains(searchKeyword.ToLower()) || x.Quantity.ToString().Equals(searchKeyword)).ToList();
            return list;
        }

        public void DeleteAirConditionerByID(string id)
        {
            var existedProduct = context.AirConditioners.FirstOrDefault(x => x.AirConditionerId.ToString().Equals(id));
            if (existedProduct != null)
            {
                context.AirConditioners.Remove(existedProduct);
                context.SaveChanges();
            }
        }
    }
}
