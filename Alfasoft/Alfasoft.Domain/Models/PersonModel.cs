using System.ComponentModel.DataAnnotations.Schema;

namespace Alfasoft.Domain.Models
{
    [Table("TB_PERSON")]
    public class PersonModel
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
    }
}
