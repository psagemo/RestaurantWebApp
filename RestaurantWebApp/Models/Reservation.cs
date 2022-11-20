using RestaurantWebApp.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantWebApp.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Number of Guests")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public int Guests { get; set; }

        [DisplayName("Date")]
        [Required(ErrorMessage = "This Field Is Required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }        

        [DisplayName("Time")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public string Time { get; set; }

        [DisplayName("Additional Information")]
        public string? AdditionalInformation { get; set; }

        public string UserId { get; set; }

        //[ForeignKey("UserId")]

        public virtual ApplicationUser User { get; set; }
    }
}

