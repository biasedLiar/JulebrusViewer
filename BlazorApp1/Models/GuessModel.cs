using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class Guess
{
    [Required]
    public int ID { get; set; }

    [Required]
    public int personId { get; set; }

    [Required]
    public int eventId { get; set; }

    [Required]
    public int guess { get; set; }
    
    [Required]
    public int rating { get; set; }
    
}
