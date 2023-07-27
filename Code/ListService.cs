using InfoTechLabProjeFabrikasi.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InfoTechLabProjeFabrikasi.Code
{
    public interface IListService
    {
        SelectList GetExpertList(object? selectedItem = null);
        SelectList GetCustomerList(object? selectedItem = null);
        SelectList GetCategoryList(object? selectedItem = null);
    }
    public class ListService : IListService
    {
        private readonly InfoTechLabContext db;
        public ListService(InfoTechLabContext context) 
        { 
            db=context;
        }
        public SelectList GetExpertList(object? selectedItem = null)
        {
            return new SelectList(db.Experts, "Id", "FullName", selectedItem);
        }
        public SelectList GetCustomerList(object? selectedItem = null) 
        { 
            return new SelectList(db.Customers, "Id", "Name", selectedItem);
        
        }
        public SelectList GetCategoryList(object? selectedItem= null) 
        { 
            return new SelectList(db.Categories, "Id", "Name", selectedItem);
        }
    }
}
