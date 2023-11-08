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
        private AirConditionerShop2023DBContext context;
        public IEnumerable<AirConditioner> GetAll()
        {
            context = new AirConditionerShop2023DBContext();
            return context.AirConditioners.Include(x => x.Supplier);
        }
        public AirConditioner? GetAnAirConditioners(int id)
        {
            context = new AirConditionerShop2023DBContext();
            return context.AirConditioners.Include(x => x.Supplier).FirstOrDefault(x => x.AirConditionerId.Equals(id));
        }
        public bool CheckExistedItem(int id)
        {
            var existedItem = context.AirConditioners.FirstOrDefault(x => x.AirConditionerId.Equals(id));
            if (existedItem != null)
            {
                return true;
            }
            return false;
        }
        public IEnumerable<SupplierCompany> GetAllCompany()
        {
            context = new AirConditionerShop2023DBContext();
            return context.SupplierCompanies;
        }
        public void AddAnAirConditioner(AirConditioner airConditioner)
        {
            context = new AirConditionerShop2023DBContext();
            context.AirConditioners.Add(airConditioner);
            context.SaveChanges();
        }
        public void UpdateAnAirConditioner(AirConditioner airConditioner)
        {
            context = new AirConditionerShop2023DBContext();
            context.AirConditioners.Update(airConditioner);
            context.SaveChanges();
        }
        public List<AirConditioner> searchByQuantityOrFeature(string searchKeyword)
        {
            context = new AirConditionerShop2023DBContext();
            List<AirConditioner> list = context.AirConditioners.Include(x => x.Supplier).Where(x => x.FeatureFunction.ToLower().Contains(searchKeyword.ToLower()) || x.Quantity.ToString().Equals(searchKeyword)).ToList();
            return list;
        }

        public void DeleteAirConditionerByID(int id)
        {
            context = new AirConditionerShop2023DBContext();
            var existedProduct = context.AirConditioners.FirstOrDefault(x => x.AirConditionerId.Equals(id));
            if (existedProduct != null)
            {
                context.AirConditioners.Remove(existedProduct);
                context.SaveChanges();
            }
        }
    }
}
