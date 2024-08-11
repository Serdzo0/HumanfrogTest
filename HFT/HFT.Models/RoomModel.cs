using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HFT.Models
{
	public class RoomModel
	{
		[Key]
		public int RoomID { get; set; }
		[Required]
		[DisplayName("Ime Sobe")]
		[Length(1,50,ErrorMessage = "Ime sobe mora biti med 1 in 50 znaki!")]
		public string Name { get; set; }
		[Required]
		[DisplayName("Cena na noč")]
		[Range(1,double.MaxValue,ErrorMessage ="Cena ne sme biti 0!")]
		public double Cena { get; set; }
		[Required]
		[DisplayName("Kratek opis sobe")]
		[Length(1, 150, ErrorMessage = "Dolgi opis mora biti med 1 in 150 znaki!")]
		public string ShortDescription { get; set; }
		[Required]
		[DisplayName("Daljši opis sobe")]
		[DataType(DataType.MultilineText)]
		[Length(1, 500,ErrorMessage ="Dolgi opis mora biti med 1 in 500 znaki!")]
		public string LongDescription { get; set; }
	}
}
