

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UdemyElCore.Data.Entities
{
    //[Table(name:"Category",Schema ="c")]
    public class Category
    {
        [Column("category_Id")]
        public int Id { get; set; }

        //category_name
        [Required]
        //[MaxLength(255)]
        [Column("category_name",TypeName ="nvarchar(100)")]
        public string Name { get; set; }
    }
}
