using Microsoft.AspNetCore.Mvc;
using SearchForPets.Application.Interfaces;
using SearchForPets.Application.Services.Volunteer.Create;

namespace SearchForPets.Api.Controllers
{
    public class VolunteerController() : ApplicationController
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateVolunteerRequest request,
                                [FromServices] IVolunteerService volunteerService,
                                CancellationToken cancellationToken = default)
        {
            var creationResult = await volunteerService.Create(request, cancellationToken);

            return Ok(creationResult.Value);
        }
    }
}
