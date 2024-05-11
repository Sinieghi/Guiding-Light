using System.ComponentModel.DataAnnotations;

namespace GuidingLight.Model;
class Company
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    //only owner can patch everything
    [Required]
    public User? Owner { get; set; }
}