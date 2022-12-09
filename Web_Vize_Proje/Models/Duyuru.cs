using System.ComponentModel.DataAnnotations;
using System;

namespace Web_Vize_Proje.Models
{
    public class Duyuru
    {
        [Key]
        public int DuyuruID { get; set; }   //Primary Key 
        public string DuyuruBasligi { get; set; }
        public string DuyuruAciklamasi { get; set; }
        public DateTime DuyuruTarihi { get; set; }
    }
}
