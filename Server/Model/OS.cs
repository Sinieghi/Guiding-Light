using MySqlX.XDevAPI;

namespace GuidingLight.Model;
class OS
{
    public int Id { get; set; }
    public User? Creator { get; set; }
    public Client? Client { get; set; }
    public Company? Company { get; set; }
    //team selected only the ones selected from the company where gona serve this service call can update up to 10 workers
    public List<User>? TeamSelected { get; set; }

}