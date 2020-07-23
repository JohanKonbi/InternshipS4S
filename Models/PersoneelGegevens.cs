using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace InternShipPipeline.Models
{
    public class PersoneelGegevens
    {
        [Display(Name = "PersoneelID")]
        [Range(1000, 9999, ErrorMessage = "Vul een geldige PersoneelID in.")]
        public int PersoneelID { get; set; }
        [Display(Name = "Voornaam")]
        [Required(ErrorMessage = "Vul hier uw voornaam in.")]
        public string Voornaam { get; set; }
        [Display(Name = "Achternaam")]
        [Required(ErrorMessage = "Vul hier uw achternaam in.")]
        public string Achternaam { get; set; }
        [Display(Name = "Wachtwoord")]
        [Required(ErrorMessage = "Vul hier een wachtwoord in in.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Wachtwoord is niet lang genoeg.")]
        public string Wachtwoord { get; set; }
    }
}
