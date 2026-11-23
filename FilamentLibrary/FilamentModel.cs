using System;
using System.Collections.Generic;
using System.Text;

namespace FilamentLibrary
{
    public enum FilamentType
    {
        PLA,
        PETG
    }

    public class FilamentModel
    {
        public required string Manufacturer { get; set; }
        public required string Color { get; set; }
        public decimal Price { get; set; }
        public int RemainingGrams { get; set; }
        public DateOnly DatePurchased { get; set; }
        public FilamentType Type { get; set; }
    }

    
}
