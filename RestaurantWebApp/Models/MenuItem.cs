using MessagePack;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace RestaurantWebApp.Models
{
    public class MenuItem
    {
        [Key]
        public int MenuItemId { get; set; }

        [DisplayName("Title")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public string Title { get; set; }

        [DisplayName("Image URL")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public string ImgURL { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public string Description { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "This Field Is Required.")]
        public int Price { get; set; }


    }
}
