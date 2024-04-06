using Final_Project.Areas.Identity.Data;
using Final_Project.Data;
using Final_Project.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class ResturantController : Controller
    {
        private readonly ILogger<ResturantController> _logger;
        private readonly UserManager<Final_ProjectUser> _userManger;
        private readonly TableBookingDbContext tableBookingDbContext;

        public ResturantController(ILogger<ResturantController> logger,UserManager<Final_ProjectUser> userManager,TableBookingDbContext tableBookingDbContext)
        {
            _logger = logger;
            this._userManger = userManager;
            this.tableBookingDbContext = tableBookingDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Service() {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Booking()
        {
            return View();
        }       


        [HttpPost]
        public async Task<IActionResult> Booking(TableBookingViewmodel addToBookingTable) 
        {

            Random  random = new Random();
            int randomNumbeer = random.Next(1, 10);
            var tableBooking = new TableBooking()

            {
                id = _userManger.GetUserId(this.User)+randomNumbeer,
                name = addToBookingTable.name,
                email = addToBookingTable.email,
                bookingDate = addToBookingTable.bookingDate,
                numberOfPeople = addToBookingTable.numberOfPeople,
                specialRequest = addToBookingTable.specialRequest
            };

            await tableBookingDbContext.BookingTable.AddAsync(tableBooking);
            await tableBookingDbContext.SaveChangesAsync();
            return RedirectToAction("Index"); 
        }

    }
}
