using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tallerGusDemo.Models;
using tallerGusDemo.Services;

namespace tallerGusDemo.Pages
{
    public class CarPriceGuessModel : PageModel
    {
        DatabaseContext _Context;
        CarService carService;

        [BindProperty]
        public Car  Car             { get; set; }
        public bool DisplaySuccess  { get; set; }
        public bool DisplayError    { get; set; }

        public CarPriceGuessModel(DatabaseContext databasecontext)
        {
            _Context    = databasecontext;
            carService  = new CarService();
        }

        public void OnGet(int? id, string DisplayError, string DisplaySuccess)
        {
            if (id != null)
            {
                Car = carService.GetCarByID((int)id, _Context);
            }

            this.DisplayError   = (!string.IsNullOrEmpty(DisplayError))     ? true : false;
            this.DisplaySuccess = (!string.IsNullOrEmpty(DisplaySuccess))   ? true : false;
        }

        public ActionResult OnPost()
        {
            var car = Car;

            _Context.Entry(car).Property(x => x.PriceGuess).IsModified = true;
            _Context.SaveChanges();

            bool data = carService.IsUserGuessWithin5kRange(car.CarID, (int)car.PriceGuess, _Context);

            if (data)
            {
                return RedirectToPage("CarPriceGuess", new { id = car.CarID, DisplaySuccess = true });
            }
            else
            {
                return RedirectToPage("CarPriceGuess", new { id = car.CarID, DisplayError = true });
            }
        }

    }
}
