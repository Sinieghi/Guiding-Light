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
    [Required]
    public List<Role>? WorkersRole { get; set; }
    public List<User>? Workers { get; set; }
    public List<OS>? OSList { get; set; }
    public List<PMOC>? PMOCs { get; set; }
    public List<DDS>? DDs { get; set; }
    //here i can separate open and closed services
    public List<Service>? Services { get; set; }
}