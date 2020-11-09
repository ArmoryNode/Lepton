using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lepton.Data.Models
{
    public enum Origin
    {
        [Display(Name = "Badlander (Bruiser)")]
        BadBruiser,
        [Display(Name = "Badlander (Scavenger)")]
        BadScavenger,
        [Display(Name = "Gutter Punk")]
        GutterPunk,
        [Display(Name = "Korporate Kid (High Flyer)")]
        KorpHighFlyer,
        [Display(Name = "Korporate Kid (Sleeker)")]
        KorpSleeker,
        [Display(Name = "Regular Joe")]
        Joe,
        [Display(Name = "Synth (Houston Dynamics MK. IV)")]
        SynthHouston,
        [Display(Name = "Synth (Shenzen Solutions Paramour)")]
        SynthShenzen,
        [Display(Name = "Synth (Visser Robotics Advanced Synth)")]
        SynthVisser,
        [Display(Name = "Wormer")]
        Wormer,
    }
}
