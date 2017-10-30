using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewsProject.Models
{
    public class Review
    {
        //Properties for reviews
        [Key]
        public int ID { get; set; }
        [Display(Name = "Holiday Mascot")]
        public string Name { get; set; }
        [Display(Name = "First Appearance")]
        public DateTime OriginDate { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }

        [ForeignKey("Category"), Display(Name = "Catergory")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}