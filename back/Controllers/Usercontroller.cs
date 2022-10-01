using Microsoft.AspNetCore.Mvc;
using dto;

namespace back.Controllers;

using Model;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    //cadastro
    [HttpPost("Login")]
    public IActionResult Login()
    {
        throw new NotImplementedException();
    }
    [HttpPost("register")]
    public IActionResult Register([FromBody] UserDTO user)
    {
        //parte de conexão do banco
        using TDSabadoContext context = new TDSabadoContext();
        //criar classe usuario
        Usuario usuario = new Usuario();
        //Relacionar classes
        usuario.Nome = user.Nome;
        usuario.DataNascimento = user.DataNascimento;
        usuario.Username = user.Username;
        usuario.Userpass = user.Userpass;
        //Adicionar e salvar  
        context.Add(usuario);
        context.SaveChanges();

        return Ok();
    }
    [HttpPost("Update")]
    public IActionResult UpdateName()
    {
        //manda mensagem de erro
        throw new NotImplementedException();
        
    }
}
