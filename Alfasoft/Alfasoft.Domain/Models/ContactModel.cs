using ExternalServices.ExternalInterface.Restcountries.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alfasoft.Domain.Models
{
    [Table("TB_CONTACT")]
    public class ContactModel
    {
        public int ID { get; set; }
        public string COUNTRY_CODE { get; set; }
        public int NUMBER { get; set; }
        public int PERSON_ID { get; set; }

        public List<RestcointriesModel> Restcointries { get; set; }
}
}
