[Authorize]
[HttpPost]
public async Task<IActionResult> Report(Breakdown breakdown)
{
    _db.Breakdowns.Add(breakdown);
    await _db.SaveChangesAsync();

    _email.SendBreakdownAlert(breakdown);
    return Ok();
}
