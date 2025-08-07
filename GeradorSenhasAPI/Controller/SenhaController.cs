using GeradorSenhasAPI.Interface;
using GeradorSenhasAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace GeradorSenhasAPI.Controller;

[ApiController]
[Route("api/[controller]")]
public class SenhaController : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly ISenhaService _senhaService;

    public SenhaController(ISenhaService senhaService)
    {
        _senhaService = senhaService;
    }

    [HttpPost("gerar")]
    public ActionResult GetSenha()
    {
        var senha = _senhaService.GerarSenha();

        return Ok(new GerarSenhaResponse { Senha = senha });
    }
}