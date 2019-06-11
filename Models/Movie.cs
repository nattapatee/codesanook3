using System;
using System.ComponentModel.DataAnnotations;

namespace SanookMovie.Models
{
    public class Movie
    {
       public int id {get; set;}
       public string title {get; set;}
       public string Genre {get; set;}

    [DataType(DataType.Date)]
       public DateTime ReleaseDate {get; set;}
    }
}