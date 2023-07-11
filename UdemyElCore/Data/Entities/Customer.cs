using System.ComponentModel.DataAnnotations;

namespace UdemyElCore.Data.Entities
{
    public class Customer
    {
        //[Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
