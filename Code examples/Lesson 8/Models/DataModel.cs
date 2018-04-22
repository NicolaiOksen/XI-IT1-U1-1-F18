using System.ComponentModel.DataAnnotations;

public class DataModel {
    [Required]
    [Display(Name = "First name")]
    public string FirstName { get; set; }
}