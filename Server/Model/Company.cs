namespace GuidingLight.Model;
class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }
    //only owner can patch everything
    public User? Owner { get; set; }
    public List<Role>? WorkersRole { get; set; }
    public List<User>? Workers { get; set; }
    public List<OS>? OSList { get; set; }
    public List<PMOC>? PMOCs { get; set; }
    public List<DDS>? DDs { get; set; }
}