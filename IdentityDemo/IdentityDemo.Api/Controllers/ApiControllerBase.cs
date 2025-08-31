using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityDemo.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ApiControllerBase : ControllerBase
{
}
