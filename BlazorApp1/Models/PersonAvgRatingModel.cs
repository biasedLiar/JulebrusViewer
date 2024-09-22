using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class PersonAvgRatingModel
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public float Variance { get; set; }
    
    [Required]
    public float Avg_rating { get; set; }

}
