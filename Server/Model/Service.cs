using System.ComponentModel.DataAnnotations;

namespace GuidingLight.Model;
class Service
{
    public int Id { get; set; }
    [Required]
    public User? Client { get; set; }
    [Required]
    public DateTime DateOfService { get; set; }
    public Company? Company { get; set; }
    public bool IsDone { get; set; } = false;
    //rest of this date contractor and service provider can update
    public string? Description { get; set; }
    //ex: helmet
    public string? EPIs { get; set; }
    //ex: NR 10
    public string? Security { get; set; }
    public string? Risks { get; set; }
    public OS? Os { get; set; }
}