using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models;

public class NumbStatModel
{
    public NumbStatModel(int _id, string _category, float _number, string _details)
    {
        Id = _id;
        Category = _category;
        Number = _number;
        Details = _details;
    }

    [Required]
    public int Id { get; set; }

    public string? Category { get; set; }
    
    [Required]
    public float Number { get; set; }

    public string? Details { get; set; }

    
    
}