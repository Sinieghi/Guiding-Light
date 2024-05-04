namespace GuidingLight.Model;

class Client
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Service? Service { get; set; }
    //it's a complex topic to work on... But i'll try any way
    public string? Location { get; set; }
}