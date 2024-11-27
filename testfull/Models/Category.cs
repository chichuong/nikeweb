using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace testfull.Models
{
    public class Category
    {

        //id
        [Key]
        public int Id { get; set; }
        
        //name
        [Required]
        [MaxLength(70)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        
        //displayorder
        [DisplayName("Display Order")]
        [Range(1,500,ErrorMessage ="Display Order must be between 1-500")]
        public int DisplayOrder { get; set; }

    }
}
