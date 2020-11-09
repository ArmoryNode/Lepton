using System;
using System.ComponentModel.DataAnnotations;

namespace Lepton.Data.Models
{
    public enum VehicleType
    {
        [Display(Name = "")]
        None,
        Scooter,
        [Display(Name = "Scooter +")]
        ScooterPlus,
        Motorbike,
        [Display(Name = "Motorbike +")]
        MotorbikePlus,
        Hauler,
        Coupe,
        Minivan,
        SUV,
        [Display(Name = "Luxury Car")]
        LuxuryCar,
        [Display(Name = "Military SUV")]
        MilitarySUV,
        Tank
    }
}
