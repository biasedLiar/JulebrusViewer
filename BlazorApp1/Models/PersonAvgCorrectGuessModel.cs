using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class PersonAvgCorrectGuessModel
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    public float Riktige_gjett { get; set; }
    
    [Required]
    public int Max_riktige { get; set; }

}
