[HttpPost("login")]
public IActionResult Login(LoginDto dto)
{
    var driver = _db.Drivers.SingleOrDefault(x => x.Email == dto.Email);
    if (driver == null) return Unauthorized();

    var token = _jwt.Generate(driver);
    return Ok(new { token });
}
