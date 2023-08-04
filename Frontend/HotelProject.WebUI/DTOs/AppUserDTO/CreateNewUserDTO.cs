using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.AppUserDTO
{
    public class CreateNewUserDTO
    {
        [Required(ErrorMessage ="Ad alanı gereklidir.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı alanı gereklidir.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail alanı gereklidir.")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar alanı gereklidir.")]
        [Compare("Password", ErrorMessage = " Şifreler uyusmadi")]
        public string ComfirmPassword { get; set; }
    }
}
