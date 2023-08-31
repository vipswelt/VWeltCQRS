using MediatR;
using Microsoft.AspNetCore.Mvc;
using VWelt.Application.UserProfile.CreateUserProfile;
using VWelt.Application.UserProfile.GetAllUserProfiles;

namespace VWelt.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserProfileController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserProfileController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var response = await _mediator.Send(new GetAllUserProfilesRequest());
        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync(CreateUserProfileRequest payload)
    {
        var newlyCreateItemId = await _mediator.Send(payload);
        return Ok(newlyCreateItemId);
    }
}