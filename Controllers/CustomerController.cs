using AutoMapper;
using Geekosphere_backend.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Geekosphere_backend.Controllers;

[Route("api/customers")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly UserManager<Customer> _userManager;
    private readonly IMapper _mapper;
    public CustomerController(UserManager<Customer> userManager, IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }
    [HttpPost("registration")]
    public async Task<IActionResult> RegisterUser([FromBody] CustomerRegistration customerRegistration)
    {
        if (customerRegistration == null || !ModelState.IsValid)
            return BadRequest();

        var customer = _mapper.Map<Customer>(customerRegistration);
        var result = await _userManager.CreateAsync(customer, customerRegistration.Password);
        if (!result.Succeeded)
        {
            var errors = result.Errors.Select(e => e.Description);

            return BadRequest(new RegistrationResponse { Errors = errors });
        }

        return StatusCode(201);
    }
}
