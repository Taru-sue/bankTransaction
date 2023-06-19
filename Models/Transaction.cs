
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bankTransaction.Models
{
    public class Transaction
    {
        [Key]

        public int Transaction_Id { get; set; }

        [Column(TypeName = "nvarchar(12)" )]
        [DisplayName(" Account Number")]
        [Required(ErrorMessage ="This Field is Required")]
        [MaxLength(12, ErrorMessage = "Maximum 12 Characters Only")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(100,ErrorMessage ="Maximum 100 Characters Only")]
        public string BeneficiaryName { get; set;}

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(100, ErrorMessage = "Maximum 100 Characters Only")]
        public string BankName{ get; set; }

        [DisplayName("SWIFT Code")]
        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(11, ErrorMessage = "Maximum 11 Characters Only")]
        public string SWIFTcode { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public int Amount { get; set; }

     
        public DateTime Date { get; set; }
    }
}
