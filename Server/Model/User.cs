using System.ComponentModel.DataAnnotations;

namespace GuidingLight.Model;
class User
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public double Password { get; set; }
    public string? Avatar { get; set; }
    public Skills? MySkills { get; set; }
    public List<Service>? ServicesDone { get; set; }
    public Company? MyCompany { get; set; }

}