using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFT.Utility.CustomValidations;

namespace HFT.Models
{
    public class ReservationModel
    {
        [Key]
        public int ReservationID { get; set; }
        [Required]
        [Length(1, 50, ErrorMessage = "Ime mora biti med 1 in 50 znaki!")]
        [DisplayName("Ime")]
        public string Name { get; set; }
        [Required]
        [Length(1, 50, ErrorMessage = "Priimek mora biti med 1 in 50 znaki!")]
        [DisplayName("Priimek")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Neveljaven elektronski naslov!")]
        [DisplayName("Elektronski naslov")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DateInFuture(ErrorMessage = "Dan prihoda ne sme biti v preteklosti!")]
        [DisplayName("Datum prihoda")]
        public DateTime CheckIn { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [ValidDate("CheckIn", ErrorMessage = "Datum odhoda mora biti po datumu prihoda!")]
        [DisplayName("Datum odhoda")]
        public DateTime CheckOut { get; set; }
        [Required]
        [DisplayName("Telefonska številka")]
        public string PhoneNumber { get; set; }
        [Required]
		[DataType(DataType.MultilineText)]
		[Length(1, 500, ErrorMessage = "Opomba mora biti med 1 in 500 znaki!")]
		[DisplayName("Opomba/Sporočilo")]
        public string Note { get; set; }
    }
}
