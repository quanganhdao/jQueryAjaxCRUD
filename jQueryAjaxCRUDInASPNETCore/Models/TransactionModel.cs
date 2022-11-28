using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jQueryAjaxCRUDInASPNETCore.Models
{
  public class TransactionModel
  {
    [Key]
    public int TransactionId { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    public int AccountNumber { get; set; }

    [Column(TypeName = "nvarchar(100)")]

    public string BeneficiaryName { get; set; }
    [Column(TypeName = "nvarchar(100)")]

    public string BankName { get; set; }
    [Column(TypeName = "nvarchar(100)")]
    public string SWIFTCode { get; set; }
    public int Amount { get; set; }
    public DateTime Date { get; set; }
  }
}
