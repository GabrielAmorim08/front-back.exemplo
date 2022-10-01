using System.Net.Http;
using System.Threading.Tasks;
using dto;
namespace front.Services;
public class UserServices
{   
    HttpClient client;
    public UserServices(string server)
    {
        client = new HttpClient();
        client.BaseAddress = new Uri(server);
    }
    public async Task Register(string Nome, string Username, DateTime DataNascimento, string Userpass)
    {
        UserDTO user = new UserDTO();
        user.Nome = Nome;
        user.Username = Username;
        user.DataNascimento = DataNascimento;
        user.Userpass = Userpass;

        var result = await client.PostAsJsonAsync("use/register", user);
    }
}