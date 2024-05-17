using MySqlX.XDevAPI;

namespace GuidingLight.Model;
class OS
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public User? Creator { get; set; }
    public Client? Client { get; set; }
    public Company? Company { get; set; }
    //team selected only the ones selected from the company and they will serve this service call, can update up to 10 workers
    public List<User>? TeamSelected { get; set; }

}