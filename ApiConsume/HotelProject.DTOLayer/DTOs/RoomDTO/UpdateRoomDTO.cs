using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.DTOs.RoomDTO
{
    public class UpdateRoomDTO
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Lutfen Oda numarası giriniz")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Lutfen fiyat bilgisi giriniz")]
        
        public int RoomPrice { get; set; }
        [Required(ErrorMessage = "Lutfen baslik giriniz")]
        public string RoomTitle { get; set; }
        [Required(ErrorMessage = "Lutfen banyo sayisi giriniz")]
        public string RoomBathCount { get; set; }
        [Required(ErrorMessage = "Lutfen yatak bilgisi giriniz")]
        public string RoomBedCount { get; set; }
        [Required(ErrorMessage = "Lutfen aciklama giriniz")]
        public string RoomDescription { get; set; }
        [Required(ErrorMessage = "Lutfen wifi bilgisi giriniz")]
        public string RoomWifi { get; set; }
    }
}
