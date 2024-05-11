namespace GuidingLight.Model;
class DDS
{
    public int ID { get; set; }
    public string? Theme { get; set; }
    public string? Description { get; set; }
    public List<User>? Participants { get; set; }
    public DateTime Date { get; set; }
    public Company? Company { get; set; }
}