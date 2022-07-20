using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tallerGusDemo.Models;
using System.Collections.Generic;
using tallerGusDemo.Services;

namespace tallerGusDemo.Pages
{
    public class CarListModel : PageModel
    {
        DatabaseContext _Context;
        CarService      carService;

        public CarListModel(DatabaseContext databasecontext)
        {
            _Context    = databasecontext;
            carService  = new CarService();
        }

        public List<Car> CarList { get; set; }

        public void OnGet()
        {
            CarList = carService.GetCarList(_Context);
        }

        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = carService.GetCarByID((int)id, _Context);

                _Context.Remove(data);
                _Context.SaveChanges();
            }
            return RedirectToPage("CarList");
        }

    }
}