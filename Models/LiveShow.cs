using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiveMusicFinder.Models
{
  public class LiveShow
  {
    public int Id { get; set; }
    [Required]
    public string Artist { get; set; }
    [Required]
    public string Venue { get; set; }
    public DateTime ShowDate { get; set; }
    public string EnteredBy { get; set; }
    
    public List<Venue> Venues { get; set; }
  }
}