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
            using (cambrainsmms1Context ctx = new cambrainsmms1Context())
            {
                ctx.Subcategory.Add(subcategory);
                ctx.SaveChanges();
            }
        }

        public List<Subcategory> getSubcategory()
        {
            using (cambrainsmms1Context ctx = new cambrainsmms1Context())
            {
                return ctx.Subcategory.ToList();
            }
        }

        public Subcategory getSubcategoryByID(int id)
        {

            using (cambrainsmms1Context ctx = new cambrainsmms1Context())
            {
                return ctx.Subcategory.Where(Subcategory => Subcategory.SubcategoryId == id).First();

            }

        }

        public SuperMarketDAL()
        {
        }
    }
}
