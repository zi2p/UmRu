using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace BlazorAppUmRu.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LatexController : ControllerBase
    {
        [HttpPost]
        public IActionResult Save([FromBody] LatexData data)
        {
            try
            {
                var json = System.Text.Json.JsonSerializer.Serialize(data);
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "latex_data.json");
                System.IO.File.WriteAllText(path, json);
                return Ok(new { message = "Data saved successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }
    }

    public class LatexData
    {
        public string Latex { get; set; }
    }
}