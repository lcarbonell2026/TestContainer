// File: Controllers/HolaController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")] // ← raíz del sitio
public class HolaController : ControllerBase
{
    // GET /hola
    [HttpGet("hola")]
    public IActionResult Hola() => Ok("Hola desde staging!");
}

