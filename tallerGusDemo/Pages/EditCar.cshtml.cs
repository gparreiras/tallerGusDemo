using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tallerGusDemo.Models;
using tallerGusDemo.Services;

namespace tallerGusDemo.Pages
{
    public class EditCarModel : PageModel
    {
        DatabaseContext _Context;
        CarService      carService;

        public EditCarModel(DatabaseContext databasecontext)
        {
            _Context    = databasecontext;
            carService  = new CarService();
        }


        [BindProperty]
        public Car Car { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                Car = carService.GetCarByID((int)id, _Context);
            }
        }


        public ActionResult OnPost()
        {
            var car = Car;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _Context.Entry(car).Property(x => x.Make).IsModified    = true;
            _Context.Entry(car).Property(x => x.Model).IsModified   = true;
            _Context.Entry(car).Property(x => x.Year).IsModified    = true;
            _Context.Entry(car).Property(x => x.Doors).IsModified   = true;
            _Context.Entry(car).Property(x => x.Color).IsModified   = true;
            _Context.Entry(car).Property(x => x.Price).IsModified   = true;
            _Context.SaveChanges();
            return RedirectToPage("CarList");
        }
    }
}