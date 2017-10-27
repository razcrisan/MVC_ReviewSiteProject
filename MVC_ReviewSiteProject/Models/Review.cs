using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_ReviewSiteProject.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }       
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Rating")]
        public float Rating { get; set; }

        [Display(Name ="Date of Review")]
        public DateTime Date { get; set; }

     
        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}