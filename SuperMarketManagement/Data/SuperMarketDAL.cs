using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarketManagement.Models;

namespace SuperMarketManagement.Data
{
    public class SuperMarketDAL : IDisposable
    {

        public void Dispose()
        {

        }

        public void saveSubcategory(Subcategory subcategory)
        {
            using (SuperMarketSystemContext ctx = new SuperMarketSystemContext())
            {
                ctx.Subcategory.Add(subcategory);
                ctx.SaveChanges();
            }
        }

        public List<Subcategory> getSubcategory()
        {
            using (SuperMarketSystemContext ctx = new SuperMarketSystemContext())
            {
                return ctx.Subcategory.ToList();
            }
        }

        public Subcategory getSubcategoryByID(int id)
        {
            using (SuperMarketSystemContext ctx = new SuperMarketSystemContext())
            {
                return ctx.Subcategory.Where(subcategory => subcategory.SubcategoryId == id).First();

            }

        }

        public SuperMarketDAL()
        {
        }
    }
}
