using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lepton.Data.Models
{
    public enum Class
    {
        [Display(Name = "Daimyo")]
        Daimyo,
        [Display(Name = "Doc")]
        Doc,
        [Display(Name = "Enforcer")]
        Enforcer,
        [Display(Name = "Hacker")]
        Hacker,
        [Display(Name = "Investigator")]
        Investigator,
        [Display(Name = "Scoundrel")]
        Scoundrel
    }
}
