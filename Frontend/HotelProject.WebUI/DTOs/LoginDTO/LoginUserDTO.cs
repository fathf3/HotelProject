using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.LoginDTO
{
    public class LoginUserDTO
    {
        [Required(ErrorMessage ="Lutfen Kullanıcı Adı giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lutfen şifre giriniz")]

        public string Password { get; set; }
    }
}
