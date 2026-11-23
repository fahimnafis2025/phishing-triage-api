using Microsoft.AspNetCore.Mvc;

namespace PhishingTriage.Api.Controllers;

[ApiController]
[Route("api/v1/submissions")]
public class SubmissionsController : ControllerBase
{
    // Day 2: wire this to HeaderParser + ScoringEngine + in-memory store.
    // Day 1 scaffold only — returns 501 so a live test proves the route exists.
    [HttpPost]
    public IActionResult Create([FromBody] object request)
        => StatusCode(501, new { error = "Not implemented yet — Day 2" });

    [HttpGet("{id}")]
    public IActionResult Get(string id)
        => StatusCode(501, new { error = "Not implemented yet — Day 2" });

    [HttpGet]
    public IActionResult List([FromQuery] string? verdict, [FromQuery] int limit = 20)
        => StatusCode(501, new { error = "Not implemented yet — Day 2" });
}
