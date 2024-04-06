using Microsoft.Build.Framework;

namespace Final_Project.Models
{
    public class TableBooking
    {


        [Required]
        public String id { get; set; }

        [Required]
        public String name { get; set; }

        [Required]
        public String email { get; set; }

        [Required]
        public DateTime bookingDate { get; set; }


        [Required]
        public int numberOfPeople { get; set; }

        [Required]
        public String specialRequest { get; set; }

    }
}
