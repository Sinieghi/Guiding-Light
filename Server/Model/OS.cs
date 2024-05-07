using MySqlX.XDevAPI;

namespace GuidingLight.Model;
class OS
{
    public int Id { get; set; }
    public User? Creator { get; set; }
    public Client? Client { get; set; }
    public List<User>? Team { get; set; }
    public List<Service>? Services { get; set; }
}