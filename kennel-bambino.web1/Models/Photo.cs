using System.ComponentModel.DataAnnotations;

namespace kennel_bambino.web1.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [Required]
        public string PhotoName { get; set; }

        [Required]
        public int PetId { get; set; }

        #region Relations - Navigation Properties

        public Pet Pet { get; set; }

        #endregion
    }
}
