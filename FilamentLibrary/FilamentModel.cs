using System;
using System.Collections.Generic;
using System.Text;

namespace FilamentLibrary
{
    public enum FilamentType
    {
        PLA,
        PLA_PLUS,
        PETG,
        PLA_LW,
        TPU
       
    }

    public class FilamentModel
    {
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int RemainingGrams { get; set; }
        public DateOnly DatePurchased { get; set; }
        public FilamentType Type { get; set; }
    }

    
}
