using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CarBuilder.Models;
using System.Security.Cryptography.X509Certificates;

namespace CarBuilder.Pages
{
    public class CarModel : PageModel
    {
        public List<CarsModel> presetCarSelections = new List<CarsModel>()
        {
            new CarsModel(){
                CarName="Standard Compact",
                BodyType="compact",
                BodyColor="gray",
                WheelType="wheel1",
                WheelColor="silver"},
            new CarsModel(){
                CarName="Standard Hatchback",
                BodyType="hatchback",
                BodyColor="white",
                WheelType="wheel1",
                WheelColor="silver"},
            new CarsModel(){
                CarName="Standard Coupe",
				BodyType="coupe",
                BodyColor="red",
                WheelType="wheel1",
                WheelColor="silver"},
        };

        public void OnGet()
        {
        }
    }
}
