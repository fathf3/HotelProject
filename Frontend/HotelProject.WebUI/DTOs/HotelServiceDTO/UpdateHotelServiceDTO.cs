using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.HotelServiceDTO
{
    public class UpdateHotelServiceDTO
    {
        public int HotelServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet ikon link giriniz")]
        public string HotelServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet basligi link giriniz")]
        public string HotelServiceTitle { get; set; }
        [Required(ErrorMessage = "Hizmet Aciklamasi link giriniz")]
        public string HotelServiceDescription { get; set; }
    }
}
