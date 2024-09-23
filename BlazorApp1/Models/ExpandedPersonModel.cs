using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class ExpandedPersonModel
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public required string navn { get; set; }

    [Required]
    public int event_count { get; set; }
    
    [Required]
    public int gjett_count { get; set; }

    
    [Required]
    public string? img { get; set; }

}
