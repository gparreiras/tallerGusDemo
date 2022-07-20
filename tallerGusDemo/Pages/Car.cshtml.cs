using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using tallerGusDemo.Models;

namespace tallerGusDemo.Pages
{
    public class CarModel : PageModel
    {
        DatabaseContext _Context;
        public CarModel(DatabaseContext databasecontext)
        {
            _Context = databasecontext;
        }

        [BindProperty]
        public Car Car { get; set; }

        public void OnGet()
        {

        }

        public ActionResult OnPost()
        {
            var car = Car;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            car.CarID = 0;
            var result = _Context.Add(car);
            _Context.SaveChanges();

            return RedirectToPage("CarList");
        }
    }
}