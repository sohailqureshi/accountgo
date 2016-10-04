using System.ComponentModel.DataAnnotations;
namespace Dto.Administration
{
  public class Company : BaseDto
  {
    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; }
    [Required]
    [Display(Name = "Short Name")]
    public string ShortName { get; set; }
    [Required]
    [Display(Name = "Company Code")]
    public string CompanyCode { get; set; }
  }
}
