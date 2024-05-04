namespace GuidingLight.Model;
class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Password { get; set; }
    public string? Avatar { get; set; }
    public Skills? MySkills { get; set; }

}