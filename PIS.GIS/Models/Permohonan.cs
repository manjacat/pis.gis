using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIS.GIS.Models
{
    public class Permohonan
    {
        public int ID { get; set; }

        [Display(Name = "Nama Pemohon")]
        public string NamaPemohon { get; set; }

        [Display(Name = "Emel")]
        public string Emel { get; set; }

        [Display(Name = "IPD / Kontinjen")]
        public string IpdKontinjen { get; set; }

        [Display(Name = "Nama Cadangan")]
        public string NamaCadangan { get; set; }
    }
}