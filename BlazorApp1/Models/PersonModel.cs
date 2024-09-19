using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class PersonModel
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public required string navn { get; set; }
    
    public List<EventModel>? events { get; set; }

}
