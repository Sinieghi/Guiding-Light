namespace GuidingLight.Model;
class PMOC
{
    public int Id { get; set; }
    public Company? Company { get; set; }
    public string[]? FieldName { get; set; } = new string[30];
    public string[]? FiledDescription { get; set; } = new string[30];

}