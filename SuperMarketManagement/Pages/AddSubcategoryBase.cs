using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SuperMarketManagement.Data;
using SuperMarketManagement.Models;
using Microsoft.AspNetCore.Components;

namespace SuperMarketManagement.Pages
{
    public class AddSubcategoryBase : ComponentBase
    {

        public Subcategory subcategory
        {
            get;
            set;
        }

        protected override Task OnInitializedAsync()
        {
            subcategory = new Subcategory();

            return base.OnInitializedAsync();
        }

        public void SaveSubcategory()
        {
            using (SuperMarketDAL dal = new SuperMarketDAL())
            {
                dal.saveSubcategory(subcategory);
            }
        }

        public List<Subcategory> GetSubcategory()
        {
            using (SuperMarketDAL dal = new SuperMarketDAL())
            {
                List<Subcategory> subcategories = dal.getSubcategory();
                return subcategories;
            }
        }

        public Subcategory GetSubcategoryByID(int id)
        {
            using (SuperMarketDAL dal = new SuperMarketDAL())
            {
                Subcategory subcategory = dal.getSubcategoryByID(id);
                return subcategory;
            }
        }
    }
}
