using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
using Microsoft.VisualBasic;

namespace Olaru_Adeline_Lab2.Models
{
    public class Book
    {
        private DateTime publishingDate;

        public int ID { get; set; }

        [Display(Name = "Book Title")]
        public string Title { get; set; }
        public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property
    } 
}

