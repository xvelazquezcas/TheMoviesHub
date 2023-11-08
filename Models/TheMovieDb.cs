using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheMoviesHub.Models
{
    public class TheMovieDb
    {
        [Required]
        public string searchText { get; set; } 
        public bool adult { get; set; }
        public string also_known_as { get; set; }
        public string biography { get; set; }
        public string birthday { get; set; }
        public int deatday { get; set; }
        public int gender { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string place_of_birth { get; set; }
        public double pipularity { get; set; }
        public string profile_Path { get; set; }


    }
}