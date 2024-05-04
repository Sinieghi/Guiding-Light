namespace GuidingLight.Model;
class Service
{
    public int Id { get; set; }
    public Client? Client { get; set; }
    public DateTime DateOfService { get; set; }
    public List<User>? TeamSelected { get; set; }
    public string? Description { get; set; }
    //ex: helmet
    public string? EPIs { get; set; }
    //ex: NR 10
    public string? Security { get; set; }
    public string? Risks { get; set; }
    public bool IsDone { get; set; } = false;
}