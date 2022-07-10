using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MabizelaLB_Assignment1.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Enter title of the book")]
        [StringLength(100)]
        public string BookTitle { get; set; }

        [Required(ErrorMessage = "Enter author of the book")]
        public string BookAuthor { get; set; }

        [Required(ErrorMessage = "Enter ISBN number of the book")]
        [RegularExpression(@"^(?:ISBN(?:-1[03])?:?\\ )?(?=[0-9X]{10}$|(?=(?:[0-9]+[-\\ ]){3})[-\\ 0-9X]{13}$|97[89][0-9]{10}$|(?=(?:[0-9]+[-\\ ]){4})[-\\ 0-9]{17}$)(?:97[89][-\\ ]?)?[0-9]{1,5}[-\\ ]?[0-9]+[-\\ ]?[0-9]+[-\\ ]?[0-9X]$", 
            ErrorMessage = "Please enter a valid 10-digit or 13-digit ISBN number")]
        public string BookISBN { get; set; }

        [Required(ErrorMessage = "Indicate if you have already read this book")]
        public bool? BookIsRead { get; set; }
    }
}
