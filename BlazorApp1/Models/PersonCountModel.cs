using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class PersonCountModel
{
    [Required]
    public int person_id { get; set; }

    [Required]
    public int stat_count { get; set; }
}
