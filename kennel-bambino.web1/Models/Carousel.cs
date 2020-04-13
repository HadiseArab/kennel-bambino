using System.ComponentModel.DataAnnotations;

namespace kennel_bambino.web1.Models
{
    public class Carousel
    {
        [Key]
        public int CarouselId { get; set; }

        [Required]
        [StringLength(75)]
        public string ImageName { get; set; }

        [Required]
        [StringLength(75)]
        public string Alt { get; set; }

        [Required]
        [StringLength(75)]
        public byte Number { get; set; }


    }
}
