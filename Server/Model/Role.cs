using System.ComponentModel.DataAnnotations;

namespace GuidingLight.Model;
class Role
{
    public string? Id { get; set; }
    [Required]
    public string? RoleName { get; set; }
    [Required]
    public bool CanUpdate { get; set; }
    [Required]
    public bool CanCreate { get; set; }
    public string? RoleDescription { get; set; }
}