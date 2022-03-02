using FSH.WebApi.Application.WholeGame.MotorRacings;

namespace FSH.WebApi.Host.Controllers.WholeGame;

public class MotorRacingsController : VersionedApiController
{
    [HttpPost("search")]
    [MustHavePermission(FSHAction.Search, FSHResource.MotorRacings)]
    [OpenApiOperation("Search rounds using available filters.", "")]
    public Task<PaginationResponse<MotorRacingDto>> SearchAsync(SearchMotorRacingsRequest request)
    {
        return Mediator.Send(request);
    }
}

