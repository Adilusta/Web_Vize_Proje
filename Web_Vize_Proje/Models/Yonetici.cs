﻿using System.ComponentModel.DataAnnotations;

namespace Web_Vize_Proje.Models
{
    public class Yonetici
    {
        [Key]
        public int YoneticiID { get; set; }//Primary Key

        public string YoneticiKullanıcıAdi { get; set; }
        public string YoneticiSifre { get; set; }

    }
}
