namespace GuidingLight.Model;
class Role
{
    public string? Id { get; set; }
    public string? RoleName { get; set; }
    public List<int>? Users { get; set; }
    public bool CanUpdate { get; set; }
    public bool CanCreate { get; set; }
    public string? RoleDescription { get; set; }
}