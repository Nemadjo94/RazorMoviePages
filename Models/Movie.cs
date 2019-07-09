using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; } //Id is required by the database for the primary key
        public string Title { get; set; }

        // The DataType attribute specifies the type of the data (Date). With this attribute:
        //The user is not required to enter time information in the date field.
        //Only the date is displayed, not time information.      
        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
