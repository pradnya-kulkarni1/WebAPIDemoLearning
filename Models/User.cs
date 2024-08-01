using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDemoLearning.Models
{
    [Table("User")] // a using will be needed :System.ComponentModel.DataAnnotations.Schema;
    public class User // POCO /"model" / "entity"
    {

    public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool Reviewer { get; set; }
        public bool Admin { get; set; }


    }
}
