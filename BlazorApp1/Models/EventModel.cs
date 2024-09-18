using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class EventModel
{
    [Required]
    public int Id { get; set; }

    public string? Navn { get; set; }
    
    [Required]
    public DateOnly tid { get; set; }

}
