using System.ComponentModel.DataAnnotations;

namespace AssetManagementSystem.Models
{
    public enum TypeOfAsset
    {
        Book = 1,
        Software,
        Hardware
    };
    public class AssetModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [Display(Prompt = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [Display(Name = "Year of publish")]
        public string Year { get; set; }
        public TypeOfAsset AssetType { get; set; }
    }
}